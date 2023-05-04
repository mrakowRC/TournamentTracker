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
        public int WinnerId { get; set; }
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModal me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $"vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else 
                    {
                        output = "Matchup not yet determined";
                        break;
                    }
                    
                }
                return output;
            }
        }
    }
}
