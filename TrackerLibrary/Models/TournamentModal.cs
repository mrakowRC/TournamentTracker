using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModal
    {
        public int Id { get; set; } 
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModal> Prizes { get; set; } = new List<PrizeModal>();
        public List<List<MatchupModal>> Rounds { get; set; } = new List<List<MatchupModal>>();
    }
}
