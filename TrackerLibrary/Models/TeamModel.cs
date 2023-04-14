using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public List<PersonModal> TeamMembers { get; set; } = new List<PersonModal>();

        public string TeamName { get; set; }
    }
}
