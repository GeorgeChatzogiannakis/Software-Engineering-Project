using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
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
            Application.Run(new Form1());

        }

        private static int userID = -1;

        /// <summary>
        /// Takes two passwords (one of them hashed) and compares them to one another, return true if they are the same otherwise false
        /// </summary>
        /// <param name="password"></param>
        /// <param name="hashedPassword"></param>
        /// <returns></returns>
        private static bool compareHashedPassword(string password, string hashedPassword)
        {
            int saltSize = 16;

            int hashSize = 20;

            //convert the hashed password to bytes
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            //take the salt out of the string
            byte[] salt = new byte[saltSize];
            Array.Copy(hashBytes, 0, salt, 0, saltSize);

            //hash the password parameter with the salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);

            //put the hashed password in a byte array
            byte[] hash = pbkdf2.GetBytes(hashSize);


            //compare the two password byte by byte, if they are identical do nothing however if they are different set password check as false
            bool passwordCheck = true;
            for(int i = 0; i < hashSize; i++)
            {
                if(hashBytes[i+saltSize] != hash[i])
                {
                    passwordCheck = false;
                }
            }

            //if passwordCheck is true return true if not return false
            if (passwordCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Gets data out of the two forms "username" and "password" from the login page, check them with the database and logs the user in or tells them 
        /// if their username or password is wrong
        /// </summary>
        public static bool checkUserLogin(string username, string password)
        {
            //Retrives the users table from the database
            DataTable dt = DBConnection.getInstanceOfDBConnection().getDataTable("SELECT * FROM users");


            //Iterates though the table to see if any of the user names corresponds with a in the table, if one does then it take the password that 
            //goes with that username and compares it to the password that the user entered, if correct send the user to the options page
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["username"].ToString() == username)
                {
                    if (compareHashedPassword(password, dr["password"].ToString()))
                    {
                        userID = Int32.Parse(dr["userID"].ToString());
                        return true;
                    }
                }
            }
            //If the user name or password aren't correct then the user is told that they have inputted an incorrect username or password
            MessageBox.Show("Username or Password incorrect");
            return false;
        }

        /// <summary>
        /// Takes the username and password from the createAccounts from and use them to create a new account (saving them to the db)
        /// </summary>
        /// <returns></returns>
        public static bool createAccount(string username, string password, string conPassword, string name, string admin)
        {

            //Calls the username unique check methid and save the boolean output
            bool uniqueUsername = usernameUnique(username);

            //Calls the complexity check method and saves the boolean output
            bool passwordComplexity = passwordComplexityCheck(password);

            //check to see if the password meets the complexity check, if it does it hashes the password and saves it to the database
            if (passwordComplexity && uniqueUsername && username != "" && password == conPassword && name != "")
            {
                string hashedPassword = hashPassword(password);

                string sqlQuery = ("INSERT INTO users (username, password, admin, name) VALUES ('"+username+"', '"+hashedPassword+"', '"+admin+"', '"+name+"')");

                DBConnection.getInstanceOfDBConnection().uploadData(sqlQuery);

                //MessageBox.Show(hashedPassword);

                return true;
            }
            createAccountValidation(username, password, conPassword, name, uniqueUsername);
            return false;
        }

        public static void createAccountValidation(string username, string password, string conPassword, string name, bool uniqueUsername)
        {
            if (username == "")
            {
                MessageBox.Show("Enter a username");
            }
            else if(name == "")
            {
                MessageBox.Show("Enter a name");
            }
            else if (!uniqueUsername)
            {
                MessageBox.Show("This username already exists");
            }
            else if (password == conPassword)
            {
                MessageBox.Show("Passwords are not the same");
            }
            else
            {
                MessageBox.Show("An error has occured");
            }
        }

        private static bool usernameUnique(string username)
        {
            //Retrives the users table from the database
            DataTable dt = DBConnection.getInstanceOfDBConnection().getDataTable("SELECT * FROM users");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["username"].ToString() == username)
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns>returns the hashed password</returns>
        private static string hashPassword(string password)
        {
            int saltSize = 16;

            int hashSize = 20;

            //creates a byte called salt
            byte[] salt;
            //generate salt
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[saltSize]);
            //hash and salt it using PDBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            //mkae a new byte array to store the hashed password and the salt
            byte[] hash = pbkdf2.GetBytes(hashSize);
            //make a new byte array to store the hashed password and the salt
            byte[] hashBytes = new byte[saltSize+hashSize];
            //place the hash and the salt in their respective places
            Array.Copy(salt, 0, hashBytes, 0, saltSize);
            Array.Copy(hash, 0, hashBytes, saltSize, hashSize);
            //convert the byte array to string
            string hashedPassword = Convert.ToBase64String(hashBytes);
            //return the string containing the hashed password
            return hashedPassword;
        }

        /// <summary>
        /// checks the complexity of the password passed in as a parameter
        /// </summary>
        /// <param name="password"></param>
        /// <returns>return the boolean check True is meets complexity</returns>
        public static bool passwordComplexityCheck(string password)
        {

            //Checks to see if the password has been filled and tells the user if the password hasn't been entered
            if (password != "")
            {
                //Check to see if the password has a number in it and gives a boolean output
                bool containsInt = password.Any(char.IsDigit);
                //Check to see if the password has a uppercase letter in it and gives a boolean output
                bool containsUpper = password.Any(char.IsUpper);
                //Check to see if the password has a lowercase letter in it and gives a boolean output
                bool containsLower = password.Any(char.IsLower);
                //Check to see if the password has at least 8 characters in it and gives a boolean output
                int passwordLength = password.Length;

                //Checks if the password has all the features to meet the complexity, if it does it returns true and does then the user is told that the password doesn't neet the complexity
                //and returns false
                if (containsInt && containsUpper && containsLower  && passwordLength > 7)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Password needs to contain:\n - a number\n - a uppercase letter\n - a lowercase letter\n - at least 8 characters in total");
                    return false;
                }
            }
            else
            {
                return false;
            }
      
            
        }

        public static bool isAdmin()
        {
            //Retrives the users table from the database
            DataTable dt = DBConnection.getInstanceOfDBConnection().getDataTable("SELECT * FROM users WHERE userID = '"+userID+"'");


            //Iterates though the table to see if any of the user names corresponds with a in the table, if one does then it take the password that 
            //goes with that username and compares it to the password that the user entered, if correct send the user to the options page
            foreach (DataRow dr in dt.Rows)
            {
                if(dr["admin"].ToString() == "Y")
                {
                    MessageBox.Show("Is admin");
                    return true;
                }
            }
            return false;
        }

        public static void logout()
        {
            userID = -1;
        }


        /// <summary>
        /// Closes the program
        /// </summary>
        public static void endProgram()
        {
            Form1.Form1Instance.Close();
        }
    }
}
