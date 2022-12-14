using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {

        /// <summary>
        /// Represents the unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the Entries of a matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        // TODO Only used for SQL, possibly delete later
        /// <summary>
        /// The ID that will be used to identify this matchup's winner.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Represents the winner of this matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round the matchup takes place in
        /// </summary>
        /// 

        // Was MyMatchupRound
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
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
