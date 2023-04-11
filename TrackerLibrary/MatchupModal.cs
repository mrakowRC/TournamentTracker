using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModal
    {
        public List<MatchupEntryModal> Entries  { get; set; } = new List<MatchupEntryModal>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
