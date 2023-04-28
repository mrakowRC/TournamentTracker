using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModals.csv";
        public const string PeopleFile = "PersonModals.csv";
        public const string TeamFile = "TeamModals.csv";
        public const string TournamentFile = "TournamentsModals.csv";
        public const string MatchupFile = "MatchupModals.csv";
        public const string MatchupEntryFile = "MatchupEntryModal.csv";

        public static IDataConnection Connection { get; private set; } 



        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //Set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                //Create Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
