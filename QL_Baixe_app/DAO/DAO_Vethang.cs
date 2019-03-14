using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_Baixe_app.DTO;
namespace QL_Baixe_app.DAO
{
    public class DAO_Vethang
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

        public List<DTO_VeThang> DSVeThang()
        {
            List<DTO_VeThang> list = new List<DTO_VeThang>();

            string query = "SELECT * FROM VE_THANG";

            DataTable data = DAO_DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_VeThang vt = new DTO_VeThang(item);
                list.Add(vt);
            }
            return list;
        }

        // DÙNG ĐỂ BINGDING CBX VÉ
        public DTO_VeThang GetVeThangbyBienSo(string bienso)
        {
            DTO_VeThang vt = null;

            string query = string.Format("SELECT * FROM VE_THANG WHERE BIENSO like  N'{0}'", bienso);
            DataTable data = DAO_DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                vt = new DTO_VeThang(item);
                return vt;
            }
            return vt;
        }
    }
}
