using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Baixe_app.DAO
{
    class DAO_DataProvider
    {
        private string conn = @"Data Source=.\SQLEXPRESS;;Initial Catalog=QL_BAIXE_THONGMINH;Integrated Security=True";

        private static DAO_DataProvider instance; // Đóng gói : Ctrl + R + E
        //
        public static DAO_DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DAO_DataProvider();
                return DAO_DataProvider.instance;
            }
            private set => instance = value;
        }


        private DAO_DataProvider() { }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                SqlCommand comd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            comd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(comd);

                adapter.Fill(dt);
                connect.Close();
                return dt;
            }

        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                SqlCommand comd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            comd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = comd.ExecuteNonQuery();

                connect.Close();
                return data;
            }
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object dt = 0;
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                SqlCommand comd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            comd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                dt = comd.ExecuteScalar();
                connect.Close();
                return dt;
            }
        }
    }
}
