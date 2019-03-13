using QL_Baixe_app.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Baixe_app.DAO
{
    class DAO_Vethang
    {
        private static DAO_Vethang instance;

        public static DAO_Vethang Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vethang();
                return DAO_Vethang.instance;
            }
            set => instance = value;
        }
        public DAO_Vethang() { }

        public List<DTO_VeThang> GetListvethang()
        {
            List<DTO_VeThang> lstve = new List<DTO_VeThang>();

            string query = "SELECT * FROM dbo.ve_thang";
            DataTable data = DAO_DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_VeThang vt = new DTO_VeThang(item);
                lstve.Add(vt);
            }
            return lstve;
        }

        public List<DTO_VeThang> GetVeThangID()
        {
            List<DTO_VeThang> list = new List<DTO_VeThang>();
            string query = "SELECT * FROM VE_THANG WHERE TRANGTHAI = 0";
            DataTable dt = DAO_DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTO_VeThang vt = new DTO_VeThang(item);
                list.Add(vt);
            }
            return list;
        }

        public bool themvethang(string mave, int sodu, string modexe, string bienso, bool trangthai)
        {

            string query = string.Format("INSERT dbo.ve_thang ( id, sodu, mode_xe,bienso, trangthai) VALUES  ( N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')", mave, sodu, modexe, bienso, trangthai);
            int result = DAO_DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
