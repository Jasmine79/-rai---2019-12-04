using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Golf
{
    static class Program
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        

        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "Golf";
            sb.CharacterSet = "utf8";

            conn = new MySqlConnection(sb.ToString());
            //tesztelés az Open metódussal
            try
            {
                conn.Open();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message,"Adatelérési hiba.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return; //visszatér az op.rsz-hez
            }

            sql = conn.CreateCommand();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
