using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModal
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents one team in matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// the score for particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// matchup that this team came from as the winner
        /// </summary>
        public MatchupModal ParentMatchup { get; set; }
    }
}
