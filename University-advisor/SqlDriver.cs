using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public static void Execute(string sql)
        {
            SQLiteConnection dbConnection = Connect();
            if(dbConnection == null)
            {
                Console.WriteLine("Failed to connect to database. Aborting query");
                return;
            }
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.StackTrace);
                return;
            }
            dbConnection.Close();
        }

        public static ArrayList Fetch(string sql)
        {
            SQLiteConnection dbConnection = Connect();
            if (dbConnection == null)
            {
                Console.WriteLine("Failed to connect to database. Aborting query");
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
    }
}
