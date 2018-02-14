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
    public partial class MainScreen : UserControl
    {

        public MainScreen()
        {
            InitializeComponent();

            outputLabel.Text = "Welcome back " + Form1.USERNAME + "!";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1.logout = true;

            Form f = this.FindForm();
            f.Controls.Remove(this);

            LoginScreen ls = new LoginScreen();
            f.Controls.Add(ls);
            this.Refresh();            
        }
    }
}
