using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
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


        public static void SaveToprizeFile(this List<PrizeModal> models, string fileName) 
        {
            List<string> lines = new List<string>();

            foreach (PrizeModal p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static void SaveToPeopleFile(this List<PersonModal> models, string fileName)
        {
            List <string> lines = new List<string>();
            foreach (PersonModal p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModals(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModal> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModals();

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

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
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

        public static List<TournamentModal> ConvertToTournamentsModels(this List<string> lines, string teamFileName, string peopleFileName, string prizeFileName)
        {
            List<TournamentModal> output = new List<TournamentModal>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModals(peopleFileName);
            List<PrizeModal> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModals();
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

                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                //TODO - Capture Rounds info

                output.Add(tm);
            }
            return output;
        }

        public static void SaveToTournamentFile(this List<TournamentModal> modals, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModal tm in modals)
            {
                lines.Add($"{tm.Id},{tm.TournamentName},{tm.EntryFee},{ConvertTeamListToString(tm.EnteredTeams)},{ConvertPrizeListToString(tm.Prizes)},{ConvertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
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
    }
}
