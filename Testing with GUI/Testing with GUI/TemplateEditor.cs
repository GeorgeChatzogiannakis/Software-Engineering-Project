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
    public partial class TemplateEditor : Form
    {
        private int templateID;

        private int numberOfSections;

        private int spacingBetweenSections = 90;

        private int firstSectionStartingYCoord = 120;

        public TemplateEditor(int templateID)
        {
            InitializeComponent();
            this.templateID = templateID;
        }

        private void TemplateEditor_Load(object sender, EventArgs e)
        {
            string templateName = Template.getTemplateType(templateID);

            createHeading(templateName);

            getSection(templateID);
            
            createAddSectionButton();
        }

        private void addSection_Click(object sender, EventArgs e)
        {
            var createSection = new CreateSection(templateID); //create an instance of option page
            Hide();             //hides the current form
            createSection.Show();       //show option page
            Close();            //closes the current form
        }

        private void createAddSectionButton()
        {
            // Creating and setting the properties of Button 
            Button addSection = new Button();
            addSection.Location = new Point(30, 120+numberOfSections*spacingBetweenSections);
            addSection.Text = "Add Section";
            addSection.AutoSize = true;
            addSection.BackColor = Color.LightBlue;
            addSection.Padding = new Padding(6);
            addSection.Font = new Font("Microsoft Sans Serif", 8);
            addSection.Click += new EventHandler(addSection_Click);

            // Adding this button to form 
            this.Controls.Add(addSection);
        }

        private void createHeading(string templateName)
        {
            // Creating and setting the properties of label 
            Label header = new Label();
            header.AutoSize = true;
            header.Text = "This is the template for: " + templateName;
            header.Location = new Point(30, 30);
            header.Font = new Font("Microsoft Sans Serif", 14);
            // Adding this label to form 
            this.Controls.Add(header);
            createSeporator(22 + templateName.Length, 30);
        }

        private void createSeporator(int numOfLetters, int yLocation)
        {
            string line = "";

            int lengthOfLine = numOfLetters * 2;

            for (int i = 0; i < lengthOfLine; i++)
            {
                line = line + "_";
            }

            Label seperator = new Label();
            seperator.AutoSize = true;
            seperator.Text = line;
            seperator.Location = new Point(30, yLocation+15);
            this.Controls.Add(seperator);
        }

        private void getSection(int templateID)
        {
            //Retrives the users table from the database
            DataTable dt = DBConnection.getInstanceOfDBConnection().getDataTable("SELECT * FROM sections WHERE templateID='"+templateID+"'");


            numberOfSections = 0;
            foreach (DataRow dr in dt.Rows)
            {
                // Creating and setting the properties of label 
                Label section = new Label();
                section.AutoSize = true;
                section.Text =  dr["sectionName"].ToString();
                section.Location = new Point(30, firstSectionStartingYCoord + numberOfSections * spacingBetweenSections);
                section.Font = new Font("Microsoft Sans Serif", 14);
                // Adding this label to form 
                this.Controls.Add(section);
                createSeporator(dr["sectionName"].ToString().Length, firstSectionStartingYCoord + numberOfSections * spacingBetweenSections);
                numberOfSections++;
            }    
        }
    }
}
