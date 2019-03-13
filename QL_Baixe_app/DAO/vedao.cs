using QL_Baixe_app.DAO;
using QL_Baixe_app.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Baixe_app.DAO
{
    class vedao
    {
        private static vedao instance;

        public static vedao Instance
        {
            get
            {
                if (instance == null) instance = new vedao();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private vedao() { }

        public List<vengay> GetListvengay()
        {
            List<vengay> lstve = new List<vengay>();

            string query = "SELECT * FROM dbo.VE_NGAY";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                vengay vn = new vengay(item);
                lstve.Add(vn);
            }
            return lstve;
        }

        public List<vethang> GetListvethang()
        {
            List<vethang> lstve = new List<vethang>();

            string query = "SELECT * FROM dbo.ve_thang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                vethang vt = new vethang(item);
                lstve.Add(vt);
            }
            return lstve;
        }

        public bool themvengay(string id, bool trangthai)
        {

            string query = string.Format("INSERT dbo.ve_ngay ( id, trangthai) VALUES  ( N'{0}', N'{1}')", id, trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool themvethang(string mave, int sodu, string modexe, string bienso, bool trangthai)
        {

            string query = string.Format("INSERT dbo.ve_thang ( id, sodu, mode_xe,bienso, trangthai) VALUES  ( N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')", mave, sodu, modexe, bienso,trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Deletevengay(int id)
        {
            string query = string.Format("Delete dbo.ve_ngay WHERE id = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Deletevethang(int id)
        {
            string query = string.Format("Delete dbo.ve_thang WHERE id = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
