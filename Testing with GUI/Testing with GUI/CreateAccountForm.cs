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
    public partial class CreateAccountForm : Form
    {

        private static string user;

        public static string GetUsername
        {
            get
            {
                return user;
            }
        }
        private static string pass;

        public static string GetPassword
        {
            get
            {
                return pass;
            }
        }

        private static bool admin;

        public static bool GetAdmin
        {
            get
            {
                return admin;
            }
        }

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            user = usernameTextBox.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            pass = passwordTextBox.Text;
        }


        private void Create_Click(object sender, EventArgs e)
        {
            Program.CreateAccount();
        }

        private void adminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            admin = true;
        }
    }
}
