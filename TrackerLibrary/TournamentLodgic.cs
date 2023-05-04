using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLodgic
    {
        public static void CreateRounds(TournamentModal model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            CreateOtherRounds(model, rounds);
        }

        private static void CreateOtherRounds(TournamentModal model, int rounds)
        {
            int round = 2;
            List<MatchupModal> previousRound = model.Rounds[0];
            List<MatchupModal> currRound = new List<MatchupModal>();
            MatchupModal currMatchup = new MatchupModal();

            while (round <= rounds)
            {
                foreach (MatchupModal match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModal { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModal();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;
                currRound = new List<MatchupModal>();
                round += 1;
            }
        }

        private static List<MatchupModal> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModal> output = new List<MatchupModal>();
            MatchupModal curr = new MatchupModal();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModal { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModal();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }

            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 0;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams;
            return output;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output += 1;
                val *= 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public static void UpdateTournamentResults(TournamentModal model)
        {
            int startingRound = model.CheckCurrentRound();
            List<MatchupModal> toScore = new List<MatchupModal>();

            foreach (List<MatchupModal> round in model.Rounds)
            {
                foreach (MatchupModal rm in round)
                {
                    if (rm.Winner == null && (rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
                    {
                        toScore.Add(rm);
                    }
                }
            }
            MarkWinnerInMatchup(toScore);

            AdvancedWinners(toScore, model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));
            int endingRound = model.CheckCurrentRound();

            if (endingRound > startingRound)
            {
                model.AlertUsersToNewRound();
            }
        }

        public static void AlertUsersToNewRound(this TournamentModal model)
        {
            int currRoundNumber = model.CheckCurrentRound();
            List<MatchupModal> currRound = model.Rounds.Where(x => x.First().MatchupRound == currRoundNumber).First();

            foreach (MatchupModal matchup in currRound)
            {
                foreach (MatchupEntryModal me in matchup.Entries)
                {
                    foreach (PersonModal p in me.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(p, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertPersonToNewRound(PersonModal p, string teamName, MatchupEntryModal competitor)
        {
            if (p.EmailAddress.Length == 0)
            {
                return;
            }

            string to = "";
            string subject = "";

            StringBuilder body = new StringBuilder();

            if (competitor != null)
            {
                subject = $"You have a new matchup with {competitor.TeamCompeting.TeamName}";

                body.AppendLine("<h1>You have a new matchup</h1>");
                body.Append("<strong>Competitor: </strong>");
                body.Append(competitor.TeamCompeting.TeamName);
                body.AppendLine();
                body.AppendLine();
                body.AppendLine("Have a great time!");
                body.AppendLine("~Tournament Tracker");
            }
            else
            {
                subject = "You have a bye week this round ";
                body.AppendLine("Enjoy your round off!");
                body.AppendLine("~Tournament Tracker");
            }

            to = p.EmailAddress;

            EmailLodgic.SendEmail(to, subject, body.ToString());
        }

        private static int CheckCurrentRound(this TournamentModal model)
        {
            int output = 1;

            foreach (List<MatchupModal> round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output += 1;
                }
                else
                {
                    return output;
                }
            }
            CompleteTournament(model);

            return output - 1;
        }

        private static void CompleteTournament(TournamentModal model)
        {
            GlobalConfig.Connection.CompleteTournament(model);

            TeamModel winners = model.Rounds.Last().First().Winner;
            TeamModel runnerUp = model.Rounds.Last().First().Entries.Where(x => x.TeamCompeting != winners).First().TeamCompeting;

            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;

            if (model.Prizes.Count > 0)
            {
                decimal totalIncome = model.EnteredTeams.Count * model.EntryFee;

                PrizeModal firstPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                PrizeModal secondPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 2).FirstOrDefault();
                if (firstPlacePrize != null)
                {
                    winnerPrize = firstPlacePrize.CalcPrizePayout(totalIncome);
                }
                if (secondPlacePrize != null)
                {
                    runnerUpPrize = secondPlacePrize.CalcPrizePayout(totalIncome);
                }
            }

            string subject = "";

            StringBuilder body = new StringBuilder();


            subject = $"In {model.TournamentName},  {winners.TeamName} has won!";

            body.AppendLine("<h1>We have a winner!</h1>");
            body.Append("<p><strong>Congrats to our winner on a great tournament</strong></p>");
            body.AppendLine("<br/>");
           if(winnerPrize > 0) 
            {
                body.AppendLine($"<p>{winners.TeamName} will receive ${winnerPrize}</p>");
            }
            if (runnerUpPrize > 0)
            {
                body.AppendLine($"<p>{runnerUp.TeamName} will receive ${runnerUpPrize}</p>");
            }
            body.AppendLine("<p>Thanks for a great tournament!</p>");
            body.AppendLine("~Tournament Tracker");

            List<string> bcc = new List<string>();

            foreach (TeamModel t in model.EnteredTeams)
            {
                foreach (PersonModal p in t.TeamMembers)
                {
                    if (p.EmailAddress.Length > 0)
                    {
                        bcc.Add(p.EmailAddress); 
                    }
                }
            }

            EmailLodgic.SendEmail(new List<string>(), bcc, subject, body.ToString());

            model.CompleteTournament();

        }

        private static decimal CalcPrizePayout(this PrizeModal prize, decimal totalIncome)
        {
            decimal output = 0;
            if (prize.PrizeAmount > 0)
            {
                output = prize.PrizeAmount;
            }
            else
            {
                output = Decimal.Multiply(totalIncome, Convert.ToDecimal(prize.PrizePercentage / 100));
            }

            return output;
        }

        private static void AdvancedWinners(List<MatchupModal> models, TournamentModal tournament)
        {
            foreach (MatchupModal m in models)
            {
                foreach (List<MatchupModal> round in tournament.Rounds)
                {
                    foreach (MatchupModal rm in round)
                    {
                        foreach (MatchupEntryModal me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.Id == m.Id)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(rm);
                                }
                            }
                        }
                    }
                }
            }

        }
        private static void MarkWinnerInMatchup(List<MatchupModal> models)
        {
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];
            foreach (MatchupModal m in models)
            {
                if (m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }

                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application.");
                    }
                }
                else
                {
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application.");
                    }
                }
            }
        }
    }
}
