using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_with_GUI
{
    class DBConnection
    {
        //connection string
        private string connStr;

        //private object of the class itself
        private static DBConnection _instance;

        //connection to the DB
        private SqlConnection connToDB;

        //constructor
        private DBConnection()
        {
            connStr = Properties.Settings.Default.PersonalDBConnectionStr;
        }


        //a static method that creates an unique object of the class itself
        public static DBConnection GetInstanceOfDBConnection()
        {
            //create the object only if it doesn't exist
            if(_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        //Returns a datatable base on the aqlQuery used

        public DataSet GetDataSet(string sqlQuery)
        {
            //creates an empty data set
            DataSet dataSet = new DataSet();


            using (connToDB = new SqlConnection(connStr))
            {
                //open connection
                connToDB.Open();

                //create the object dataAdapter to send a query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill the empty data set
                dataAdapter.Fill(dataSet);

            }

            return dataSet;
        }

        /**
         * Method that saves data into the database
         */

        public void SaveToDB(string sqlQuery, string username, string password,bool admin)
        {
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                //open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sqlCommand
                sqlCommand.Parameters.Add(new SqlParameter("Username", username));
                sqlCommand.Parameters.Add(new SqlParameter("Password", password));
                sqlCommand.Parameters.Add(new SqlParameter("Admin", admin));

                //execute the command
                sqlCommand.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// Only user with sql statement that deals with one table
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sqlQuery)
        {

            //creates an empty data set
            DataTable dataTable = new DataTable();

            //Calls the getDataSet methood
            DataSet ds = GetInstanceOfDBConnection().GetDataSet(sqlQuery);

            //Converts the data set into the datatable
            dataTable = ds.Tables[0];

            return dataTable;
        }
        
    }
}
