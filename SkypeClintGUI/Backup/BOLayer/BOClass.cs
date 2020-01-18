using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace BOLayer
{
    public class BOClass
    {
        public static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=I:\SDP\SkypeClintGUI\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //public static string connectionString = @"Data Source= 192.168.1.3,1433;Network Library=DBMSSOCN;Initial Catalog= E:\SkypeClintGUI\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //public static string connectionString = @"Data Source=192.168.11.2;Initial Catalog=E:\SkypeClintGUI\data.mdf;Persist Security Info=True;User ID=FalconOfEdge;Password=aminarahman";
        //public static string connectionString = @"Data Source=192.168.11.2,1433;AttachDbFilename=E:\SkypeClintGUI\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //public static string connectionString = @"Data Source=FalconOfEdge\\SQLEXPRESS;Initial Catalog=E:\SkypeClintGUI\data.mdf;Integrated Security=False;User ID=Khaled Saifullah;Password=aminarahman;Connect Timeout=30";


        SqlConnection connection = new SqlConnection(connectionString);

        public void chatHistorySave(string texts)
        {
            openConnection();
            string query = "INSERT INTO tblChatHistory VALUES (@chat)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@chat", SqlDbType.VarChar, 50).Value = texts;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }

            closeConnection();

        }


        public SqlDataReader chatHistoryDisplay()
        {
            string query = "SELECT* FROM tblChatHistory";
            SqlCommand cmd = new SqlCommand(query, connection);
            openConnection();
            SqlDataReader DR1 = cmd.ExecuteReader();

            return DR1;
        }

        public void deleteChatHistory()
        {


            string query = "DELETE FROM tblChatHistory ";
            SqlCommand cmd = new SqlCommand(query, connection);
            openConnection();

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch { }

            closeConnection();

        }

        public void openConnection()
        {
            try
            {
                connection.Open();
            }
            catch 
            {
               
            }
           
        }

        public void closeConnection()
        {
            connection.Close();

        }



    }
}
