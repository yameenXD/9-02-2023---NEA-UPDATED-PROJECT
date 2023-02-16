﻿using System;
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
        private static string DBasePath = System.Environment.CurrentDirectory;
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            DBasePath + "/dbQuizGame.accdb";

        public static DataSet dataConnect(string SQL)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(SQL, con);

                    DataSet dataSet = new DataSet();
                    userAdapter.Fill(dataSet, "DATA");

                    return dataSet;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }

        }
        public static OleDbConnection Connect()
        {
            string DBasePath = System.Environment.CurrentDirectory;
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + 
                    DBasePath + "/dbQuizGame.accdb");
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
       /* public static DataSet dataConnect(string SQL)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(SQL, con);

                    DataSet dataSet = new DataSet();
                    userAdapter.Fill(dataSet, "DATA");

                    return dataSet;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }*/
        public static DataSet getDataSet(string SQL)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(SQL, con);
                    DataSet UserData = new DataSet();

                    userAdapter.Fill(UserData, "Users");
                    return UserData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public static void dataConnect()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbQuizGame.accdb");
            try
            {
                con.Open();
                MessageBox.Show("Connected");
            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
            try
            {
                string queryString = "SELECT UserName, LoginDateTime FROM tblLogin";
                OleDbCommand cmd = new OleDbCommand(queryString, con);
                DataSet Login = new DataSet();

                string queryString_2 = "SELECT UserName, TestDate, Score FROM tblUserScores";
                OleDbCommand cmd_2 = new OleDbCommand(queryString_2, con);
                DataSet UserScores = new DataSet();

                string queryString_3 = "SELECT UserName, Forname, Surname, Form, DOB FROM tblUser";
                OleDbCommand cmd_3 = new OleDbCommand(queryString_3, con);
                DataSet UserDetails = new DataSet();

                /*userAdapter.Fill(users, "Users");*/
                MessageBox.Show("Database Connected");

                /*foreach (DataRow row in users.Tables["Users"].Rows)
                {
                    MessageBox.Show(row["UserID"]);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dataset Failed");
            }
            con.Close();
        }


        public static void AmendAddInsertData(string SQL) 
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(SQL, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static void AmendAddInsertData_2(string SQL_2) 
        {
            OleDbConnection con = Connect();
            try
            {
                OleDbCommand cmd_2 = con.CreateCommand();
                cmd_2.CommandText = SQL_2;
                cmd_2.Connection = con;
                cmd_2.ExecuteNonQuery();
                MessageBox.Show("Data inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed");
            }
            try
            {
                string queryString_2 = "SELECT UserName, TestDate, Score FROM tblUserScores";
                OleDbCommand cmd_2 = new OleDbCommand(queryString_2, con);
                DataSet scores = new DataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed");
            }
            con.Close();
        }

        public static void AmendAddInsertData_3(string SQL_3)
        {
            OleDbConnection con = Connect();
            try
            {
                OleDbCommand cmd_3 = con.CreateCommand();
                cmd_3.CommandText = SQL_3;
                cmd_3.Connection = con;
                cmd_3.ExecuteNonQuery();
                MessageBox.Show("Data inserted");
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
    }
}