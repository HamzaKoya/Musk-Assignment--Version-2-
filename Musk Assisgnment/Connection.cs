﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musk_Assisgnment
{
    class Connection
    {
        // attribute
        // private object of the class itself
        private static Connection _instance;

        private string ConnectionString;

        //constructor
        private Connection()
        {
            //initialise the Connection
            ConnectionString = Properties.Settings.Default.ConnectionString;
        }

        //Method 
        //Static Method that gives acsess to the private object

        public static Connection getInstanceOfConnection()
        {
            if (_instance == null)
                _instance = new Connection(); 
            return _instance;
        }

        public DataSet getDataSet(string sqlQuery)
        {
            //create the dataset object
            DataSet dataset = new DataSet();

            using (SqlConnection connToConnection = new SqlConnection(ConnectionString))
            {
                //open Connection
                connToConnection.Open();

                //send SQL query to the database
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToConnection);
                
                //fill in the dataset
                adapter.Fill(dataset);
            }

            return dataset;

        }

        // Method to save parameters into the database. 
        public void saveToDb (string sqlQuery, string site, string completedby, string workarea, string jobdescription, string supervisor, string inspector, string date, string type)  
        {
            using (SqlConnection Connection = new SqlConnection (ConnectionString))
            {
                //Open connection
                Connection.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, Connection);

                //set sqlCommand's properties 
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("Site", site));
                sqlCommand.Parameters.Add(new SqlParameter("CompletedBy", completedby));
                sqlCommand.Parameters.Add(new SqlParameter("Work Area", workarea));
                sqlCommand.Parameters.Add(new SqlParameter("Job Description", jobdescription));
                sqlCommand.Parameters.Add(new SqlParameter("Supervisor", supervisor));
                sqlCommand.Parameters.Add(new SqlParameter("Inspector", inspector));
                sqlCommand.Parameters.Add(new SqlParameter("Date", date));
                sqlCommand.Parameters.Add(new SqlParameter("Type", type));

                //Execute the command
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}