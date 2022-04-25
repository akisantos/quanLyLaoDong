using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        //ConnectionString
        private string con = "Data Source=REIKUN;Initial Catalog=quanLyLaoDong;Integrated Security=True";
        
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {

            DataTable dataset = new DataTable();

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] paraList = query.Split(' ');
                    int i = 0;
                    foreach (string item in paraList)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dataset);

                connection.Close();
            }

            

            return dataset;

        }

        public int  ExcuteNonQuery(string query, object[] parameter = null)
        {

            int data = 0;

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] paraList = query.Split(' ');
                    int i = 0;
                    foreach (string item in paraList)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                connection.Close();
            }



            return data;

        }


        public object ExcuteScalar(string query, object[] parameter = null)
        {

            object data = 0;

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] paraList = query.Split(' ');
                    int i = 0;
                    foreach (string item in paraList)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                connection.Close();
            }

            return data;

        }
    }
}
