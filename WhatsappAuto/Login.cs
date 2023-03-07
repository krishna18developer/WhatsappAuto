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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WhatsappAuto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
        private void DoLogin()
        {
            string userid = userIdBox.Text;
            string password = passwordBox.Text;

            if (userid == Settings.Default.UserID && password == Settings.Default.password)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           passwordBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            userIdBox.Text = Settings.Default.UserID;
        }
    }
}
