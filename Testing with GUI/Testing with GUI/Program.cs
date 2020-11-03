using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_with_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CreateAccountForm());
            //Application.Run(new Form2());//just for testing
            
        }
        /// <summary>
        /// Gets data out of the two forms "username" and "password" from the login page, check them with the database and logs the user in or tells them 
        /// if their username or password is wrong
        /// </summary>
        public static void CheckUserLogin()
        {
            //Retrives the users table from the database
            DataTable dt = DBConnection.GetInstanceOfDBConnection().GetDataTable("SELECT * FROM users");


            //Iterates though the table to see if any of the user names corresponds with a in the table, if one does then it take the password that 
            //goes with that username and compares it to the password that the user entered, if correct send the user to the options page
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["username"].ToString() == LogInForm.GetUsername)
                {
                    if (dr["password"].ToString() == LogInForm.GetPassword)
                    {
                        EndProgram();
                        break;
                    }
                }
            }
            //If the user name or password aren't correct then the user is told that they have inputted an incorrect username or password
            MessageBox.Show("Username or Password incorrect");
        }

        public static void CreateAccount()
        {
            bool passwordComplexity = PasswordComplexityCheck();
            if (passwordComplexity)
            {
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                var pbkdf2 = new Rfc2898DeriveBytes(CreateAccountForm.GetPassword, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                string savedPasswordHash = Convert.ToBase64String(hashBytes);
                MessageBox.Show(savedPasswordHash);
            }
             
        }

        public static bool PasswordComplexityCheck()
        {
            bool containsInt = CreateAccountForm.GetPassword.Any(char.IsDigit);//error occurs if no password is input
            bool containsUpper = CreateAccountForm.GetPassword.Any(char.IsUpper);
            bool containsLower = CreateAccountForm.GetPassword.Any(char.IsLower);
            int passwordLength = CreateAccountForm.GetPassword.Length;
            if (!containsInt)
            {
                MessageBox.Show("Password needs to contain a number");
                return false;
            }
            else if(!containsUpper)
            {
                MessageBox.Show("Password needs to contain a uppercase character");
                return false;
            }
            else if (!containsLower)
            {
                MessageBox.Show("Password needs to contain a lowercase character");
                return false;
            }
            else if(passwordLength < 8)
            {
                MessageBox.Show("Password needs to contain at least 8 characters");
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Closes the program
        /// </summary>
        public static void EndProgram()
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
