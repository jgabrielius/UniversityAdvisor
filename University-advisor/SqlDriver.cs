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
        private static SQLiteConnection connect()
        {
            try
            {
                SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
                dbConnection.Open();
                return dbConnection;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public static void exec(string sql)
        {
            SQLiteConnection dbConnection = connect();
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

        public static ArrayList fetch(string sql)
        {
            SQLiteConnection dbConnection = connect();
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
                    Object[] temp = new object[reader.FieldCount];
                    reader.GetValues(temp);
                    al.Add(temp);
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
