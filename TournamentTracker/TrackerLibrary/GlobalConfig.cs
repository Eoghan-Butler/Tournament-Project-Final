using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";


        //public static List<IDataConnection> Connection { get; private set; } = new List<IDataConnection>();
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Represents where the info will be saved, a database or test file
        /// </summary>

        public static void InitializeConnections(bool database, bool textFiles)
        {

            if (database)
            {
                // TODO - Create SQL connection
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            if (textFiles)
            {
                // TODO - Create textFiles connection
                TextConnector text = new TextConnector();
                Connection = text;
            }

        }
    }
}
