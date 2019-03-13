using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Baixe_app.dto
{
    public class vengay
    {
        public vengay(string id, bool trangthai)
        {
            this.Id = id;
            this.Trangthai = trangthai;
        }

        public vengay(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Trangthai = (bool)row["TRANGTHAI"];
        }
        private string id;
        private bool trangthai;
        public string Id { get => id; set => id = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
    }
}
