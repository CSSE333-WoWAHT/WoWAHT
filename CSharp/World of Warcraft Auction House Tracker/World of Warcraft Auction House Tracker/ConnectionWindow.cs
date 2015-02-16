using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            /*
            var fileMap = new ConfigurationFileMap(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            var configuration = ConfigurationManager.OpenMappedMachineConfiguration(fileMap);
            var sectionGroup = configuration.GetSectionGroup("applicationSettings"); // This is the section group name, change to your needs
            var section = (ClientSettingsSection)sectionGroup.Sections.Get("World_of_Warcraft_Auction_House_Tracker.Properties.Settings"); // This is the section name, change to your needs
            section.

            var setting = section.Settings.Get("wowahtPublicConnectionString"); // This is the setting name, change to your needs
            */
            Properties.Settings.Default.wowahtPublicConnectionString = connectionStringEntry.Text;
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
