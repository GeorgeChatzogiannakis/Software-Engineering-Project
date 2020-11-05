﻿using System;
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
        public static Form1 Form1Instance;

        public Form1()
        {
            //Everyone eveywhere in the app should know me as Form1.Form1Instance
            Form1Instance = this;

            //Make sure I am kept hidden
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            InitializeComponent();

            //Open a managed form - the one the user sees..
            var login = new CreateAccount();
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
