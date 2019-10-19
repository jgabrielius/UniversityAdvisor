using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_advisor.Tools;
using University_advisor.Constants;

namespace University_advisor
{
    class SqlDriver
    {
        private static SQLiteConnection Connect()
        {
            try
            {
                SQLiteConnection dbConnection = new SQLiteConnection("Data Source=../../Database.sqlite;Version=3;");
                dbConnection.Open();
                return dbConnection;
            }
            catch (SQLiteException e)
            {
                Logger.Log(e.StackTrace);
                return null;
            }
        }

        public static bool Execute(string sql)
        {
            SQLiteConnection dbConnection = Connect();
            if(dbConnection == null)
            {
                Logger.Log(Messages.dbConnectFailed);
                return false;
            }
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();
                Logger.Log(Messages.queryExecuteSuccess);
            }
            catch (SQLiteException e)
            {
                Logger.Log(e.Message);
                return false;
            }
            dbConnection.Close();
            return true;
        }

        public static ArrayList Fetch(string sql)
        {
            SQLiteConnection dbConnection = Connect();
            if (dbConnection == null)
            {
                Console.WriteLine(Messages.dbConnectFailed);
                return null;
            }
            try
            {
                ArrayList al = new ArrayList();
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        dictionary[reader.GetName(i)]=reader.GetValue(i);
                    }
                    al.Add(dictionary);
                }
                reader.Close();
                dbConnection.Close();
                return al;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e.StackTrace);
                return null;
            }
        }

        public static bool Exists(string sql)
        {
            var result = Fetch(sql);
            if(result.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
