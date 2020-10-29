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
    public partial class Form1 : Form
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

        public Form1()
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
            pass = password.Text;
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            user = username.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Program.checkUserLogin();
            //to test
        }
    }
}
