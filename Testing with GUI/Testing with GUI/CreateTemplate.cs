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
    public partial class CreateTemplate : Form
    {
        public CreateTemplate()
        {
            InitializeComponent();
        }

        private string tempType = "";

        private void templateType_TextChanged(object sender, EventArgs e)
        {
            tempType = templateType.Text;
        }

        private void createTemp_Click(object sender, EventArgs e)
        {
            bool successfulCreation = Template.createTemplate(tempType);
            if (successfulCreation)
            {
                int templateID = Template.getTemplateID(tempType);

                var tempEditor = new TemplateEditor(templateID); //create an instance of option page
                Hide();             //hides the current form
                tempEditor.Show();       //show option page
                Close();            //closes the current form
            }
        }
    }
}
