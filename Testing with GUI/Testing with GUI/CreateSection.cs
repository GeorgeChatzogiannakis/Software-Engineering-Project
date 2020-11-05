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
    public partial class CreateSection : Form
    {
        private string secName = "";

        private int templateID;

        public CreateSection(int templateID)
        {
            InitializeComponent();
            this.templateID = templateID;
        }

        private void sectionName_TextChanged(object sender, EventArgs e)
        {
            secName = sectionName.Text;
        }

        private void createSec_Click(object sender, EventArgs e)
        {
            bool sectionCreated = Template.createSection(templateID, secName);
            if (sectionCreated)
            {
                var templateEditor = new TemplateEditor(templateID); //create an instance of option page
                Hide();             //hides the current form
                templateEditor.Show();       //show option page
                Close();            //closes the current form
            }
        }
    }
}
