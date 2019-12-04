using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Golf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.sql.CommandText = "SELECT `kód`, `név`, `született`, `magasság` FROM `tagok` ORDER BY `név`;";
            using (MySqlDataReader dr=Program.sql.ExecuteReader())
            {
                while (dr.Read()) // a datareader 1-1 rekordját olvassa be
                {
                    listBox_Tagok.Items.Add(new GolfTag(dr.GetInt32("kód"),dr.GetString("név"),dr.GetDateTime("született"),dr.GetInt32("magasság")));
                }
            }

        }
    }
}
