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
    public partial class OptionPage : Form
    {
        public OptionPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createTemplate_Click(object sender, EventArgs e)
        {
            var createTemp = new CreateTemplate(); //create an instance of create template form
            Hide();             //hides the current form
            createTemp.Show();       //show shows the create template form
            Close();
        }

        private void editTemplate_Click(object sender, EventArgs e)
        {

        }
    }
}
