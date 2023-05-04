using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file) 
        {
            if(!File.Exists(file))
            {
                return new List<string>() ;
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModal> ConvertToPrizeModals(this List<string> lines)
        {
        List<PrizeModal> output = new List<PrizeModal>();
            foreach (string line in lines) 
            {
                string[] cols = line.Split(',');
                PrizeModal p = new PrizeModal();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static List<PersonModal> ConvertToPersonModals(this List<string> lines)
        {
            List<PersonModal> output = new List<PersonModal>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModal p = new PersonModal();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToprizeFile(this List<PrizeModal> models) 
        {
            List<string> lines = new List<string>();

            foreach (PrizeModal p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModal> models)
        {
            List <string> lines = new List<string>();
            foreach (PersonModal p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModals(this List<string> lines)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModal> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModals();

            foreach (string line in lines)
            { 
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split("|");

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());

                }
                output.Add(t);
            }
            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }
            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModal> people)
        {
            string output = "";
            if (people.Count == 0)
            {
                return "";
            }

            foreach (PersonModal p in people) 
            {
                output += $"{p.Id}|";
                
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static List<TournamentModal> ConvertToTournamentsModels(this List<string> lines)
        {
            List<TournamentModal> output = new List<TournamentModal>();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModals();
            List<PrizeModal> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModals();
            List<MatchupModal> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModals();
            foreach (string line in lines) 
            {
                string[] cols = line.Split(',');

                TournamentModal tm = new TournamentModal();

                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds) 
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }
                string[] prizeIds = cols[4].Split('|');
                if (cols[4].Length > 0)
                {
                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }
                
                //Capture Rounds info
                string[] rounds = cols[5].Split('|');
                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');
                    List<MatchupModal> ms = new List<MatchupModal>();
                    foreach (string matchupModalTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModalTextId)).First());
                    }
                    tm.Rounds.Add(ms);
                }
                output.Add(tm);
            }
            return output;
        }

        public static void SaveToTournamentFile(this List<TournamentModal> modals)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModal tm in modals)
            {
                lines.Add($"{tm.Id},{tm.TournamentName},{tm.EntryFee},{ConvertTeamListToString(tm.EnteredTeams)},{ConvertPrizeListToString(tm.Prizes)},{ConvertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";

            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModal> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModal p in prizes)
            {
                output += $"{p.Id}|";

            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertRoundListToString(List<List<MatchupModal>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModal> r in rounds)
            {
                output += $"{ConvertMatchupListToSTring(r)}|";

            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertMatchupListToSTring(List<MatchupModal> matchups) 
        {
            string output = "";
            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModal m in matchups)
            {
                output += $"{m.Id}^";

            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static void SaveRoundsToFile(this TournamentModal modal)
        {
            foreach (List<MatchupModal> round in modal.Rounds)
            {
                foreach (MatchupModal matchup in round)
                {
                    matchup.SaveMatchupToFile();

                }
            }
        }

        public static void SaveMatchupToFile(this MatchupModal matchup)
        {
            List<MatchupModal> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModals();

            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;

            matchups.Add(matchup);

            foreach (MatchupEntryModal entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }

            //save to file
            List <string>lines = new List<string>();

            foreach (MatchupModal m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModal entry)
        {
            List<MatchupEntryModal> entries = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupEntryModals();

            int currentId = 1;

            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }

            entry.Id = currentId;
            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchupEntryModal e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string team = "";
                if (e.TeamCompeting != null)
                {
                    team = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{team},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);

        }

        public static List<MatchupModal> ConvertToMatchupModals(this List<string> lines)
        {
            List<MatchupModal> output = new List<MatchupModal>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModal m = new MatchupModal();
                m.Id = int.Parse(cols[0]);
                m.Entries = ConvertStringToMatchupEntryModal(cols[1]);
                if (cols[2].Length == 0)
                {
                    m.Winner = null;
                }
                else 
                {
                    m.Winner = LookupTeamById(int.Parse(cols[2]));
                }
                m.MatchupRound = int.Parse(cols[3]);
                output.Add(m);
            }
            return output;
        }

        public static List<MatchupEntryModal> ConvertToMatchupEntryModals(this List<string> lines)
        {
            List<MatchupEntryModal> output = new List<MatchupEntryModal>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModal m = new MatchupEntryModal();
                m.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    m.TeamCompeting = null;
                }
                else 
                {
                    m.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }
                m.Score = double.Parse(cols[2]);
                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    m.ParentMatchup = LookupMatchupById(parentId);
                }
                else 
                {
                    m.ParentMatchup = null;
                }
               
                output.Add(m);
            }
            return output;
        }

        private static List<MatchupEntryModal> ConvertStringToMatchupEntryModal(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModal> output = new List<MatchupEntryModal>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids) 
            {
                foreach (string entry in entries) 
                {
                    string[] cols = entry.Split(',');
                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }
            output = matchingEntries.ConvertToMatchupEntryModals();

            return output;
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();
            foreach(string team in teams) 
            {
                string[] cols = team.Split(",");
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModals().First();
                }
            }
            return null;
        }

        private static MatchupModal LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();
            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(",");
                if (cols[0] == id.ToString())
                { 
                    List<string > matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModals().First();
                }
            }
            return null;
        }

        private static string ConvertMatchupEntryListToString(List<MatchupEntryModal> entries)
        {
            string output = "";
            if (entries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModal me in entries)
            {
                output += $"{me.Id}|";

            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static void UpdateMatchupToFile(this MatchupModal matchup)
        {
            List<MatchupModal> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModals();

            MatchupModal oldMatchup = new MatchupModal();
            foreach(MatchupModal m in matchups) 
            {
                if (matchup.Id == matchup.Id)
                {
                    oldMatchup = m;
                }
            }
            matchups.Remove(oldMatchup);

            matchups.Add(matchup);

            foreach (MatchupEntryModal entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }

            //save to file
            List<string> lines = new List<string>();

            foreach (MatchupModal m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void UpdateEntryToFile(this MatchupEntryModal entry)
        {
            List<MatchupEntryModal> entries = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupEntryModals();
            MatchupEntryModal oldEntry = new MatchupEntryModal();

            foreach (MatchupEntryModal e in entries)
            {
                if (e.Id == entry.Id)
                {
                    oldEntry = e;
                }
            }

            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchupEntryModal e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string team = "";
                if (e.TeamCompeting != null)
                {
                    team = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{team},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);

        }
    }
}
