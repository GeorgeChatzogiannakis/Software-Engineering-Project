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
    public partial class LogInForm : Form
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

        public LogInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            pass = passwordTextBox.Text;
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            user = usernameTextBox.Text;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Program.CheckUserLogin();
        }
    }
}
