using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the unique identifier for the matchup entry
        /// </summary>
        public int Id { get; set; }

        // TODO possibly only needed for SQL
        /// <summary>
        /// The unique identifier for the team competing.
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represents one player/team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The unique identifier for the parent matchup (the matchuUpId where the team in this entry came from).
        /// </summary>
        public int parentMatchupId { get; set; }

        /// <summary>
        /// Represents the matchup that this team 
        /// previously came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }


    }
}
