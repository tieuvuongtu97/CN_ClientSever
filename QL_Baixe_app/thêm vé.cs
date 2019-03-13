using QL_Baixe_app.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Baixe_app
{
    public partial class frthemve : Form
    {
        
        string mave = "vn";
        string mave1 = "vt";
        //int trangthai = 0;
        int sodu=0;
        string khachhangid="null";
        string modexe ="";
        string bienso="";
        public frthemve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool trangthai = false;
            string mv = textBox1.Text;
            if (mv.Contains(mave))
            {
                bool t = vedao.Instance.themvengay(mv, trangthai);
                if (t)
                {
                    MessageBox.Show("Thêm vn thành công");
                }
                else
                {
                    MessageBox.Show("lỗi");
                }

            }

            if (mv.Contains(mave1))
            {
                bool t= vedao.Instance.themvethang(mv, sodu, modexe, bienso, trangthai);
                if (t)
                {
                    MessageBox.Show("Thêm vt thành công");
                }
                else
                {
                    MessageBox.Show("lỗi");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
