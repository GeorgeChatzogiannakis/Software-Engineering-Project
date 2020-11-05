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

        private static string user = "";

        private static string pass = "";

        private static string fullName = "";

        private static string conPass = "";

        private static string admin = "N";


        public CreateAccount()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            user = username.Text;
        }

        private void create_Click(object sender, EventArgs e)
        {
            bool successful = Program.createAccount(user, pass, conPass, fullName, admin);
            if (successful)
            {
                var optionPg = new Login(); //create an instance of option page
                Hide();             //hides the current form
                optionPg.Show();       //show option page
                Close();            //closes the current form
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged_1(object sender, EventArgs e)
        {
            fullName = name.Text;
        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {
            pass = password.Text;
        }

        private void conPassword_TextChanged(object sender, EventArgs e)
        {
            conPass = conPassword.Text;
        }

        private void isAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (isAdmin.CheckState == CheckState.Checked)
            {
                admin = "Y";
            }
            else if (isAdmin.CheckState == CheckState.Unchecked)
            {
                admin = "N";
            }
        }
    }
}
