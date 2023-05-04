using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Reflection;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePrize(PrizeModal model)
        {
            List<PrizeModal> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModals();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            prizes.Add(model);

            //convert the prizes to list<string>
            //save the list<string> to text file
            prizes.SaveToprizeFile();
        }

        public void CreatePerson(PersonModal model)
        {
            List<PersonModal> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModals();

            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);

            people.SaveToPeopleFile();
        }

        public List<PersonModal> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModals();
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModals();
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();
        }

        public List<TeamModel> GetTeam_All() 
        {
           return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModals();
        }

        public void CreateTournament(TournamentModal modal)
        {
            List<TournamentModal> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentsModels();

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modal.Id = currentId;

            modal.SaveRoundsToFile();

            tournaments.Add(modal);

            tournaments.SaveToTournamentFile();

            TournamentLodgic.UpdateTournamentResults(modal);
        }

        public List<TournamentModal> GetTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentsModels();
        }

        public void UpdateMatchup(MatchupModal model)
        {
            model.UpdateMatchupToFile();
        }

        public void CompleteTournament(TournamentModal model)
        {
            List<TournamentModal> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentsModels();

            tournaments.Remove(model);

            tournaments.SaveToTournamentFile();

            TournamentLodgic.UpdateTournamentResults(model);
        }
    }
}
