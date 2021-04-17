/** Application Purpose: A class to define the database connection methods and variables
* Author: Yunna Jang 200455726
* Date: 17/4/2021
* Time: 10:40AM
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CollegeManagementSystem
{
    class Connection
    {
        // Set the OleDb variables related to connection
        public OleDbConnection con;
        public OleDbCommand cmd;
        public OleDbDataAdapter dta;
        public OleDbDataReader dtr;

        // The connection method to be called whenever we need to make a database connection
        public void link()
        {
            // Make a connection object
            con = new OleDbConnection();
            // Make a command object
            cmd = new OleDbCommand();
            // Define a connection string to the database
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\CollegeDB.accdb";
            // Set the connection to the new OleDbConnection
            cmd.Connection = con;

            // Connection method that will be called when we need to open a connection
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
        }
    }
}
