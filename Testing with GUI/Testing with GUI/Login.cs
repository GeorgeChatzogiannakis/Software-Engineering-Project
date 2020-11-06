using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_with_GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //set the default values for the variables, this is done everytime the form is called
            user = "";

            pass = "";
        }


        private static string user;


        private static string pass;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            bool loginSuccessful = Program.checkUserLogin(user, pass);
            if (loginSuccessful)
            {
                var optionPg = new OptionPage(); //create an instance of option page
                Hide();             //hides the current form
                optionPg.Show();       //show option page
                Close();            //closes the current form
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            user = Username.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            pass = Password.Text;
        }

    }
}
