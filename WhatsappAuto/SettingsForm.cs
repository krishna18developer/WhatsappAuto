using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsappAuto.Properties;

namespace WhatsappAuto
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            profilePathBox.Text = Settings.Default.ProfilePath;
            profileDirectoryBox.Text = Settings.Default.ProfileDirectory;
            edgeDriverBox.Text = Settings.Default.EdgeDriverLocation;
            overallDeletionBox.Text = Settings.Default.OverallCount.ToString();
        }

        private void reloadDataBox_Click(object sender, EventArgs e)
        {
            profilePathBox.Text = Settings.Default.ProfilePath;
            profileDirectoryBox.Text = Settings.Default.ProfileDirectory;
            edgeDriverBox.Text = Settings.Default.EdgeDriverLocation;
            overallDeletionBox.Text = Settings.Default.OverallCount.ToString();
        }

        private void saveDataBox_Click(object sender, EventArgs e)
        {
            Settings.Default.ProfilePath = profilePathBox.Text;
            Settings.Default.ProfileDirectory = profileDirectoryBox.Text;
            Settings.Default.EdgeDriverLocation = edgeDriverBox.Text;
            Settings.Default.OverallCount = Int32.Parse(overallDeletionBox.Text);
            Settings.Default.Save();
        }
    }
}
