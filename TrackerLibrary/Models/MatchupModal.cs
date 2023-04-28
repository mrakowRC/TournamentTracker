using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModal
    {
        public int Id { get; set; }
        public List<MatchupEntryModal> Entries { get; set; } = new List<MatchupEntryModal>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
