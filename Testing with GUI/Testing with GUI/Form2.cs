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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void editCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            editCheckBox.Checked = submitButton.Enabled;
            //go to edit page//
        }

        private void createCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            createCheckBox.Checked = submitButton.Enabled;
            //go to create template page//
        }

        private void deteleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            deteleCheckBox.Checked = submitButton.Enabled;
            //go to templates page//
        }

        private void sendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sendCheckBox.Checked = submitButton.Enabled;
            //for admin page only//
            //propt for confirmation, then sends the database//
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //go to next forms//
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //back to login page//
        }
    }
}
