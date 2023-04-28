using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List < MatchupModal > currRound = new List<MatchupModal>();
            MatchupModal currMatchup = new MatchupModal();

            while (round <= rounds)
            {
                foreach (MatchupModal match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModal {ParentMatchup = match});

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
    }
}
