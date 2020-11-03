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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
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
        
        

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            //back to login page//
        }

        private void CreateButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EditButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_CheckedChanged(object sender, EventArgs e)
        {
            //should integrate in edit
        }

        private void SendButton_CheckedChanged(object sender, EventArgs e)
        {
            //fro admin accounts only
        }
    }
}
