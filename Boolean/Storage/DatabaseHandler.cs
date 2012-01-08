using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

using Boolean.Enumerables;

namespace Boolean
{
    static class DatabaseHandler
    {
        public static string ConnectionString;

        public static SerializeResult Serialize()
        {
            try
            {
                var Builder = new MySqlConnectionStringBuilder();
                Builder.Server = Settings.GetValue("Database.Host");
                Builder.Port = uint.Parse(Settings.GetValue("Database.Port"));
                Builder.UserID = Settings.GetValue("Database.Username");
                Builder.Password = Settings.GetValue("Database.Password");
                Builder.Database = Settings.GetValue("Database.Database");
                Builder.Pooling = Settings.GetValue("Database.Pooling.Enabled").ToLower() == "true";
                Builder.MinimumPoolSize = uint.Parse(Settings.GetValue("Database.Pooling.Min"));
                Builder.MaximumPoolSize = uint.Parse(Settings.GetValue("Database.Pooling.Max"));

                ConnectionString = Builder.ConnectionString;

                var Connection = new MySqlConnection(ConnectionString);
                Connection.Open();

                Solution.AppendLine("DatabaseHandler: Connected with database: {0}({1})", Connection.Database, Connection.ServerVersion);
            }
            catch { return SerializeResult.Broken; }

            return SerializeResult.Finished;
        }
    }
}
