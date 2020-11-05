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
    class Template
    {
        public static bool createTemplate(string templateType)
        {
            bool uniquenessOfTempType = uniqueTemplateType(templateType);

            if (templateType != "" && uniquenessOfTempType)
            {
                string sqlQuery = ("INSERT INTO templates (feedbackType) VALUES ('" + templateType + "')");

                DBConnection.getInstanceOfDBConnection().uploadData(sqlQuery);

                return true;
            }
            else if(templateType == "")
            {
                MessageBox.Show("Please enter the name of the feedback type");
            }
            else if (!uniquenessOfTempType)
            {
                MessageBox.Show("A feedback template has already been called this");
            }
            else
            {
                MessageBox.Show("An error has occured");
            }
            return false;

        }

        private static bool uniqueTemplateType(string tempType)
        {
            //Retrives the users table from the database
            DataTable dt = DBConnection.getInstanceOfDBConnection().getDataTable("SELECT * FROM templates");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["feedbackType"].ToString() == tempType)
                {
                    return false;
                }
            }
            return true;
        }

        public static string getTemplateType(int templateID)
        {
            DataTable dt = DBConnection.getInstanceOfDBConnection().getDataTable("SELECT * FROM templates");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["templateID"].ToString() == templateID.ToString())
                {
                    return (dr["feedbackType"].ToString());
                }
            }
            return "-1";
        }

        public static int getTemplateID(string templateType)
        {
            DataTable dt = DBConnection.getInstanceOfDBConnection().getDataTable("SELECT * FROM templates");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["feedbackType"].ToString() == templateType)
                {
                    return Int32.Parse(dr["templateID"].ToString());
                }
            }
            return -1;
        }

        public static bool createSection(int templateID, string sectionName)
        {
            if (sectionName != "")
            {
                string sqlQuery = ("INSERT INTO sections (templateID, sectionName) VALUES ('"+templateID+"', '" + sectionName + "')");

                DBConnection.getInstanceOfDBConnection().uploadData(sqlQuery);

                return true;
            }
            else if (sectionName == "")
            {
                MessageBox.Show("Please enter the name of the section");
            }
            else
            {
                MessageBox.Show("An error has occured");
            }
            return false;
        }

    }
}
