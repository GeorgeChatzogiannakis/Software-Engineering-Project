using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_with_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (createButton.Checked)
            {
                //go to create page
            }

            if (editButton.Checked)
            {
                //go to list of templates
            }

            if (deleteButton.Checked)
            {
                //go to list of templates (shouldn't it be the same thing with the edit though?)
            }

            if (sendButton.Checked)
            {
                //send all templates
            }
            
        }
        
        

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //back to login page//
        }

        private void createButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void editButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_CheckedChanged(object sender, EventArgs e)
        {
            //should integrate in edit
        }

        private void sendButton_CheckedChanged(object sender, EventArgs e)
        {
            //fro admin accounts only
        }
    }
}
