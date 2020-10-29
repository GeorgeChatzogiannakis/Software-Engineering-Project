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

        public static DBConnection getInstanceOfDBConnection()
        {
            if(_instance == null)
            
            _instance = new DBConnection();
            return _instance;
        }

        //Returns a datatable base on the aqlQuery used

        public DataSet getDataSet(string sqlQuery)
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

        /// <summary>
        /// Only user with sql statement that deals with one table
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        public DataTable getDataTable(string sqlQuery)
        {

            //creates an empty data set
            DataTable dataTable = new DataTable();

            //Calls the getDataSet methood
            DataSet ds = getInstanceOfDBConnection().getDataSet(sqlQuery);

            //Converts the data set into the datatable
            dataTable = ds.Tables[0];

            return dataTable;
        }
    }
}
