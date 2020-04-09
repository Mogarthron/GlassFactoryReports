using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Core3Library
{
    public class DBConnection
    {
        static private string connetionString = @"Data Source=DESKTOP-C82KD4L;Initial Catalog=Raporty;User ID=sa;Password=Cyklopentan1";
        private SqlConnection cnn = new SqlConnection(connetionString);

        static private SqlCommand command;        

        public SqlDataReader dataReader { get; set; }        

        public void InsertConnection(string sql)
        {
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        public void StartConnection(string sql)
        {
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
        }

        public void EndConnection()
        {
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}
