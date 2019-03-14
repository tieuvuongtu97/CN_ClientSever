using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Baixe_app.DAO
{
   public class DAO_Khachhang
    {
        private static DAO_Khachhang instance;

        public static DAO_Khachhang Instance{
            get
            {
                if (instance == null) instance = new DAO_Khachhang();
                return DAO_Khachhang.instance;
            }
            set => instance = value;
        }

        public DAO_Khachhang() {}

        public bool insertKH(string hoten, string sdt, string diachi, string socccd, string avt, string id_vt, int sodu, string mode_xe, string bienso)
        {
            string query ="EXEC PR_DKKH_MOI @HOTEN , @SDT , @DIACHI , @SO_CCCD , @AVT , @ID_VE , @SODU , @MODE_XE , @BIENSO";
            int kq = DAO_DataProvider.Instance.ExcuteNonQuery(query, new object[] { hoten ,sdt ,diachi ,socccd ,avt ,id_vt ,sodu ,mode_xe ,bienso});
            return kq > 0;
        }    

        public bool editKH(string veid, string hoten, string sdt, string diachi, string socccd, string avt, int sodu, string mode_xe, string bienso)
        {
            string query = "EXEC PR_EDIT_KH @VE_ID , @HOTEN , @SDT , @DIACHI , @SO_CCCD , @AVT , @SODU , @MODE_XE , @BIENSO";
            int kq = DAO_DataProvider.Instance.ExcuteNonQuery(query, new object[] { veid ,hoten ,sdt ,diachi ,socccd ,avt ,sodu ,mode_xe ,bienso});
            return kq > 0;
        }

        public bool delKH(string id)
        {
            string query = "EXEC PR_DEL_KH @ID";
            int kq = DAO_DataProvider.Instance.ExcuteNonQuery(query, new object[] { id});
            return kq > 0;
        }

        public string GetIdKhachhangbyCCCD(string cccd)
        {
            string query = "EXEC PR_GET_ID_KH @CCCD";
            string idkh = DAO_DataProvider.Instance.ExcuteScalar(query, new object[] { cccd }).ToString();
            return idkh;
        }
        public DataTable DSKhachhang()
        {
            string query = "EXEC PR_DSKH_VEDK";
            DataTable dt = DAO_DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public DataTable DSKhachhang_Page(int page, int pagesize)
        {          
            return DAO_DataProvider.Instance.ExcuteQuery("EXEC PR_DSKH_VEDK_IN_PAGE @PAGE , @PAGE_SIZE", new object[] { page , pagesize});
        }

        public int TongKh()
        {
            return (int)DAO_DataProvider.Instance.ExcuteScalar("EXEC PR_TONG_KH");
        }
    }
}
