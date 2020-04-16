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
         
        List<SqlParameter> SqlParameters = new List<SqlParameter>();

        public SqlDataReader dataReader { get; set; }              

        public void AddParameterToList(string parameterName, System.Data.SqlDbType DataType, object value)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, DataType);
            sqlParameter.Value = value;

            SqlParameters.Add(sqlParameter);
        }       

        /// <summary>
        /// Method to execute non select querrys
        /// </summary>
        /// <param name="sp">Stored Procedure</param>
        public void Connection(string sp)
        {
            cnn.Open();
            command = new SqlCommand(sp, cnn);            
            command.CommandType = System.Data.CommandType.StoredProcedure;                       

            if (SqlParameters != null)
                command.Parameters.AddRange(SqlParameters.ToArray());

            command.ExecuteNonQuery();
            cnn.Close();            
            SqlParameters.Clear();
        }

        public void StartConnection(string sp)
        {
            cnn.Open();
            command = new SqlCommand(sp, cnn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
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
