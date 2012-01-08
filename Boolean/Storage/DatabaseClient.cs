using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;

namespace Boolean.Storage
{
    class DatabaseClient : IDisposable
    {
        public string Query;
        public List<MySqlParameter> Parameters;

        public DatabaseClient(string Query)
        {
            this.Query = Query;
            this.Parameters = new List<MySqlParameter>();
        }

        public void AddParam(string Name, object Obj)
        {
            Parameters.Add(new MySqlParameter("@" + Name, Obj));
        }

        public DataRow GetRow()
        {
            try
            {
                return MySqlHelper.ExecuteDataRow(DatabaseHandler.ConnectionString, Query, Parameters.ToArray());
            }
            catch { return new DataTable().NewRow(); }
        }

        public DataTable GetTable()
        {
            try
            {
                return MySqlHelper.ExecuteDataset(DatabaseHandler.ConnectionString, Query, Parameters.ToArray()).Tables[0];
            }
            catch { return new DataTable(); }
        }

        public void Dispose() { }
    }
}
