using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Baixe_app.DTO
{
   public class DTO_Khachhang
    {
        public DTO_Khachhang(string id, string hoten, string sdt, string diachi, string so_cccd, string avt, DateTime ngay_dk, bool trangthai)
        {
            this.Id = id;
            this.Hoten = hoten;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.So_CCCD = so_cccd;
            this.Avt = avt;
            this.Ngay_dk = ngay_dk;
            this.Trangthai = trangthai;
        }

        public DTO_Khachhang(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Hoten = row["HOTEN"].ToString();
            this.Sdt = row["SDT"].ToString();
            this.Diachi = row["DIACHI"].ToString();
            this.So_CCCD = row["SO_CCCD"].ToString();
            this.Avt = row["AVT"].ToString();
            this.Trangthai = (bool)row["TRANGTHAI"];
            this.Ngay_dk = (DateTime)row["NGAY_DK"];
        }

        private string id;
        private string hoten;
        private string sdt;
        private string diachi;
        private string so_CCCD;
        private string avt;
        private DateTime ngay_dk;
        private bool trangthai;

        public string Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string So_CCCD { get => so_CCCD; set => so_CCCD = value; }
        public string Avt { get => avt; set => avt = value; }
        public DateTime Ngay_dk { get => ngay_dk; set => ngay_dk = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
    }
}
