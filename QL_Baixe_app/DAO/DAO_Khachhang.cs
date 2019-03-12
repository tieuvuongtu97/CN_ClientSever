using System;
using System.Collections.Generic;
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

        public bool insertKH(string hoten, string sdt, string diachi, string socccd, string avt, DateTime ngaydk, string id_vt, int sodu, string mode_xe, string bienso)
        {
            string query = string.Format("EXEC PR_DKKH_MOI @HOTENV ={0}, @SDT ={1}, @DIACHI ={2}, @SO_CCCD ={3}, @AVT ={4}, @ NGAY_DK ={5}, @ID_VE ={6}, @SODU ={7}, @MODE_XE ={8}, @BIENSO ={9}", hoten, sdt, diachi, socccd, avt, ngaydk, id_vt, sodu, mode_xe, bienso);
            int kq = DAO_DataProvider.Instance.ExcuteNonQuery(query);
            return kq > 0;
        }

    }
}
