using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_advisor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ArrayList result = SqlDriver.Fetch("SELECT * FROM test");
            Debug.WriteLine("the result is: ");
            foreach (Object[] row in result)
            {
                foreach (object column in row)
                {
                    Debug.Write(column.ToString());
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
