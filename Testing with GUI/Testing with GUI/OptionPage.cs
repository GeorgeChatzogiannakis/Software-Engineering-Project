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
            Close();                 //closes the current form
        }

        private void editTemplate_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.logout();
            var login = new Login(); //create an instance of login page
            Hide();             //hides the current form
            login.Show();       //show login page
            Close();            //closes the current form
        }

        private void OptionPage_Load(object sender, EventArgs e)
        {
            if (Program.isAdmin())
            {
                // Creating and setting the properties of Button 
                Button createAccountButton = new Button();
                createAccountButton.Location = new System.Drawing.Point(432, 467);
                createAccountButton.Margin = new System.Windows.Forms.Padding(4);
                createAccountButton.Name = "deleteTemplate";
                createAccountButton.Size = new System.Drawing.Size(172, 65);
                createAccountButton.TabIndex = 4;
                createAccountButton.Text = "Delete Template";
                createAccountButton.UseVisualStyleBackColor = true;
                createAccountButton.Click += new EventHandler(createAccount_click);

                // Adding this button to form 
                this.Controls.Add(createAccountButton);
            }
        }

        private void createAccount_click(object sender, EventArgs e)
        {
            var createAcc = new CreateAccount(); //create an instance of create account from
            Hide();             //hides the current form
            createAcc.Show();       //shows the create account form
            Close();            //closes the current form
        }
    }
}
