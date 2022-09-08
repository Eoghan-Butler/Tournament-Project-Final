using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The unique identificator for the team
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Team name
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// List of team members in a team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();



    }
}
