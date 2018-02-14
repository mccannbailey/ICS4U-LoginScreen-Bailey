using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS4U_LoginScreen_Bailey
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();

            if (Form1.logout)
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Successfully logged out";
                Form1.logout = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            statusLabel.Controls.Clear();

            if (userBox.Text == Form1.USERNAME && passBox.Text == Form1.PASSWORD)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                MainScreen ms = new MainScreen();
                f.Controls.Add(ms);
                this.Refresh();
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Incorrect login.";
                userBox.Clear();
                passBox.Clear();
                userBox.Focus();
            }
        }
    }
}
