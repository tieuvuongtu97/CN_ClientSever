using QL_Baixe_app.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Baixe_app.DAO
{
    class DAO_Vengay
    {
        private static DAO_Vengay instance;

        public static DAO_Vengay Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vengay();
                return DAO_Vengay.instance;
            }
            set => instance = value;
        }
        public DAO_Vengay() { }

        public List<DTO_VeNgay> GetListvengay()
        {
            List<DTO_VeNgay> lstve = new List<DTO_VeNgay>();

            string query = "SELECT * FROM dbo.VE_NGAY";
            DataTable data = DAO_DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_VeNgay vn = new DTO_VeNgay(item);
                lstve.Add(vn);
            }
            return lstve;
        }

        public bool themvengay(string id, bool trangthai)
        {

            string query = string.Format("INSERT dbo.ve_ngay ( id, trangthai) VALUES  ( N'{0}', N'{1}')", id, trangthai);
            int result = DAO_DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
