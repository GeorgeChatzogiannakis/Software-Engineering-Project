using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_with_GUI
{
    public partial class CreateAccount : Form
    {

        private static string user;

        public static string getUsername
        {
            get
            {
                return user;
            }
        }
        private static string pass;

        public static string getPassword
        {
            get
            {
                return pass;
            }
        }

        private static bool admin;

        public static bool getAdmin
        {
            get
            {
                return admin;
            }
        }

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            user = username.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            pass = password.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            admin = true; 
        }

        private void create_Click(object sender, EventArgs e)
        {
            Program.createAccount();
        }
    }
}
