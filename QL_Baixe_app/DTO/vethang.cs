using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Baixe_app.dto
{
    public class vethang
    {
        public vethang(string id, int sodu, string mode_xe, string bienso, string khachhang_id, bool trangthai)
        {
            this.Id = id;
            this.Sodu = sodu;
            this.Mode_xe = mode_xe;
            this.Bienso = bienso;
            this.Khachhang_id = khachhang_id;
            this.Trangthai = trangthai;
        }

        public vethang(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Sodu = (int)row["SODU"];
            this.Mode_xe = row["MODE_XE"].ToString();
            this.Bienso = row["BIENSO"].ToString();
            this.Khachhang_id = row["KHACHHANG_ID"].ToString();
            this.Trangthai = (bool)row["TRANGTHAI"];
        }

        private string id;
        private int sodu;
        private string mode_xe;
        private string bienso;
        private string khachhang_id;
        private bool trangthai;

        public string Id { get => id; set => id = value; }
        public int Sodu { get => sodu; set => sodu = value; }
        public string Mode_xe { get => mode_xe; set => mode_xe = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public string Khachhang_id { get => khachhang_id; set => khachhang_id = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        
    }
}
