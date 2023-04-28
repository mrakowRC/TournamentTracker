using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModals.csv";
        private const string PeopleFile = "PersonModals.csv";
        private const string TeamFile = "TeamModals.csv";
        private const string TournamentFile = "TournamentsModals.csv";
        private const string MatchupFile = "MatchupModals.csv";
        private const string MatchupEntryFile = "MatchupEntryModal.csv";
        public PrizeModal CreatePrize(PrizeModal model)
        {
            List<PrizeModal> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModals();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            prizes.Add(model);

            //convert the prizes to list<string>
            //save the list<string> to text file
            prizes.SaveToprizeFile(PrizesFile);

            return model;

        }

        public PersonModal CreatePerson(PersonModal model)
        {
            List<PersonModal> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModals();

            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        public List<PersonModal> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModals();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModals(PeopleFile);
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;

        }

        public List<TeamModel> GetTeam_All() 
        {
           return TeamFile.FullFilePath().LoadFile().ConvertToTeamModals(PeopleFile);
        }

        public void CreateTournament(TournamentModal modal)
        {
            List<TournamentModal> tournaments = TournamentFile.FullFilePath().LoadFile().ConvertToTournamentsModels(TeamFile, PeopleFile, PrizesFile);

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modal.Id = currentId;

            modal.SaveRoundsToFile(MatchupFile, MatchupEntryFile);

            tournaments.Add(modal);

            tournaments.SaveToTournamentFile(TournamentFile);

        }
    }
}
