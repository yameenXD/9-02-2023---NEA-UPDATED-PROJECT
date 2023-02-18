using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
namespace Quiz_game_design_and_coded_solution
{
    public static class DBCon

    {
        private static string DBasePath = System.Environment.CurrentDirectory; // This retrieves the path of the current directory
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            DBasePath + "/dbQuizGame.accdb"; // This specifies the connection string for the access database that will be used

        //This method will execute the SELECT statement on the database and it returns the result as a Dataset. 
        public static DataSet dataConnect(string SQL)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString)) // This creates an instance of the OleDbConnection class with the specified connection string 
            {
                try
                {
                    con.Open(); // This will open the connection to the database
                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(SQL, con); // This creates a new instance of the OleDbDataAdapter class to get the required data that is needed 

                    DataSet dataSet = new DataSet();// instantiation of the Dataset class
                    userAdapter.Fill(dataSet, "DATA");// This will fill the dataset object with the results of the SELECT statement and gives the DataTable and name called Data

                    return dataSet; // This returns the dataset
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // this will display the error message
                    return null; // this will return null
                }
            }

        }
        // Creates a new to the database and returns thje OleDbConnection object
        public static OleDbConnection Connect()
        {
            string DBasePath = System.Environment.CurrentDirectory; // This retrieves the path for the current directory
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                    DBasePath + "/dbQuizGame.accdb");// instantiation of the OleDbConnection class
                con.Open(); // This will open the database connnection
                return con; // this will return the OleDbConnection object
            }
            catch (Exception ex)
            {
                return null;// this will return null
            }
        }
        //This will execute select statement on the database and returns the results 
        public static DataSet getDataSet(string SQL)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString)) // instantiation of the OleDbConnection with the specified connection string 
            {
                try
                {
                    con.Open();
                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(SQL, con);//creates a new instance of the OleDbDataAdapter class to retrieve data from the database
                    DataSet UserData = new DataSet();

                    userAdapter.Fill(UserData, "Users");
                    return UserData; // returns the Dataset
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // displays error message
                    return null; // returns null
                }
            }
        }

        public static void dataConnect()
        {
            // This creates a new OleDbConnection object with a connection string for the database file
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbQuizGame.accdb");
            try
            {
                con.Open(); // opens the connection for the database
                MessageBox.Show("Connected"); // this will display that it has been connected
            }
            catch
            {
                MessageBox.Show("Connection failed"); // This will display that the connection has failed
            }
            try
            {
                // This defines the SQL query for tblLogin
                string queryString = "SELECT UserName, LoginDateTime FROM tblLogin";
                // Create a new OleDbCommand object with the query string and the connection
                OleDbCommand cmd = new OleDbCommand(queryString, con);
                //This creates a new dataset object for it to store the results in the query
                DataSet Login = new DataSet();

                //This defines the SQL query for tblUserScores
                string queryString_2 = "SELECT UserName, TestDate, Score, Subject FROM tblUserScores";
                OleDbCommand cmd_2 = new OleDbCommand(queryString_2, con);
                DataSet UserScores = new DataSet();

                //This defines the SQL query for tblUser
                string queryString_3 = "SELECT UserName, Forname, Surname, Form, DOB FROM tblUser";
                OleDbCommand cmd_3 = new OleDbCommand(queryString_3, con);
                DataSet UserDetails = new DataSet();

                string queryString_4 = "SELECT Subject FROM tblTest";
                OleDbCommand cmd_4 = new OleDbCommand(queryString_4, con);
                DataSet UserSubject = new DataSet();


                MessageBox.Show("Database Connected"); // It will display that the Database has been connected
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dataset Failed");
            }
            con.Close(); // This will close the connection to the database
        }


        public static void AmendAddInsertData(string SQL)
        {
            // This creates an instance of the OleDbConnection class with the specified connection string 
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open(); // open the connection to the database
                    OleDbCommand cmd = new OleDbCommand(SQL, con); // This will create a new OleDbCommand object with the SQL query string and for the connection object
                    cmd.ExecuteNonQuery(); // This will execute the query and insert the data into the database
                    /* MessageBox.Show("Data inserted"); // It will display that the data has been inserted into the database*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // This will display the error message
                }
            }
        }

        public static void AmendAddInsertData_2(string SQL_2)
        {
            //This will create a new OleDbConnection object with the connnection string to the database
            OleDbConnection con = Connect();
            try
            {
                // Create a new OleDCommand object with the SQL query string and the connection object 
                OleDbCommand cmd_2 = con.CreateCommand();

                cmd_2.CommandText = SQL_2;
                cmd_2.Connection = con;
                //This will execute the query and insert the data into the database
                cmd_2.ExecuteNonQuery();
                //This will display that the data has been inserted into the database
                /* MessageBox.Show("Data inserted");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed"); // This will display that the insert has failed
            }
            try
            {
                // SQL query for tblUserScores
                string queryString_2 = "SELECT UserName, TestDate, Score, Subject FROM tblUserScores";

                OleDbCommand cmd_2 = new OleDbCommand(queryString_2, con);
                //Create a new dataset object which will hold the results of the query
                DataSet scores = new DataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed"); // this will display that the insert has failed
            }
            con.Close(); // This will close the connection with the database
        }
        // Same as code previous method above
        public static void AmendAddInsertData_3(string SQL_3)
        {
            OleDbConnection con = Connect();
            try
            {
                OleDbCommand cmd_3 = con.CreateCommand();
                cmd_3.CommandText = SQL_3;
                cmd_3.Connection = con;
                cmd_3.ExecuteNonQuery();
                /*MessageBox.Show("Data inserted");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed");
            }
            try
            {
                string queryString_3 = "SELECT UserName, Forname, Surname, Form, DOB FROM tblUser";
                OleDbCommand cmd_3 = new OleDbCommand(queryString_3, con);
                DataSet user_details = new DataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed");
            }
            con.Close();
        }
        /*public static void AmendAddInsertData_4(string SQL_4)
        {
            //This will create a new OleDbConnection object with the connnection string to the database
            OleDbConnection con = Connect();
            try
            {
                // Create a new OleDCommand object with the SQL query string and the connection object 
                OleDbCommand cmd_4 = con.CreateCommand();

                cmd_4.CommandText = SQL_4;
                cmd_4.Connection = con;
                //This will execute the query and insert the data into the database
                cmd_4.ExecuteNonQuery();
                //This will display that the data has been inserted into the database
                *//* MessageBox.Show("Data inserted");*//*
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed"); // This will display that the insert has failed
            }
            try
            {
                // SQL query for tblUserScores
                string queryString_4 = "SELECT Subject FROM tblTest";

                OleDbCommand cmd_4 = new OleDbCommand(queryString_4, con);
                //Create a new dataset object which will hold the results of the query
                DataSet user_Scores = new DataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed"); // this will display that the insert has failed
            }
            con.Close(); // This will close the connection with the database


        }*/
    }
}
