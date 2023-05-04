using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModal model);
        void CreatePerson(PersonModal model);
        List<PersonModal> GetPerson_All();
        void CreateTeam(TeamModel model);
        List<TeamModel> GetTeam_All();
        void CreateTournament(TournamentModal model);
        List<TournamentModal> GetTournament_All();
        void UpdateMatchup(MatchupModal model);
        void CompleteTournament(TournamentModal model);
    }
}
