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
        PrizeModal CreatePrize(PrizeModal model);
        PersonModal CreatePerson(PersonModal model);
        List<PersonModal> GetPerson_All();
        TeamModel CreateTeam(TeamModel model);
        List<TeamModel> GetTeam_All();
        void CreateTournament(TournamentModal model);
    }
}
