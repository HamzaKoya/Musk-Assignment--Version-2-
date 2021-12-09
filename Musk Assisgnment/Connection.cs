using System;
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

        public static Connection GetInstanceOfConnection()
        {
            if (_instance == null)
                _instance = new Connection(); 
            return _instance;
        }

        public DataSet GetDataSet(string sqlQuery)
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
        public void SaveToDb (string sqlQuery, string Site, string Completed_By, string Work_Area, string Job_Description, string Supervisor, string Inspector, string Date, string Type)  
        {
            using (SqlConnection Connection = new SqlConnection (ConnectionString))
            {
                //Open connection
                Connection.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, Connection);

                //set sqlCommand's properties 
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("Site", Site));
                sqlCommand.Parameters.Add(new SqlParameter("Completed_By", Completed_By));
                sqlCommand.Parameters.Add(new SqlParameter("Work_Area", Work_Area));
                sqlCommand.Parameters.Add(new SqlParameter("Job_Description", Job_Description));
                sqlCommand.Parameters.Add(new SqlParameter("Supervisor", Supervisor));
                sqlCommand.Parameters.Add(new SqlParameter("Inspector", Inspector));
                sqlCommand.Parameters.Add(new SqlParameter("Date", Date));
                sqlCommand.Parameters.Add(new SqlParameter("Type", Type));

                //Execute the command
                sqlCommand.ExecuteNonQuery();
            }
        }

     
    }
}
    

