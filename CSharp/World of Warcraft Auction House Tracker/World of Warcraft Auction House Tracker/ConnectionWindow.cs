using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_of_Warcraft_Auction_House_Tracker
{
    public partial class ConnectionWindow : Form
    {
        public ConnectionWindow()
        {
            InitializeComponent();
            connectionStringEntry.Text = World_of_Warcraft_Auction_House_Tracker.Properties.Settings.Default.wowahtPublicConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //World_of_Warcraft_Auction_House_Tracker.Properties.Settings.Default.wowahtPublicConnectionString = connectionStringEntry.Text;
            Application.Restart();
        }
    }
}
