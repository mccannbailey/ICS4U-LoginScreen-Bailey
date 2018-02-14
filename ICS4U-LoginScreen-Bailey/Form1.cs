using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS4U_LoginScreen_Bailey
{
    public partial class Form1 : Form
    {
        public static string USERNAME = "Bill";
        public static string PASSWORD = "1234";
        public static Boolean logout = false;

        public Form1()
        {
            InitializeComponent();

            LoginScreen ls = new LoginScreen();
            this.Controls.Add(ls);
        }
    }
}
