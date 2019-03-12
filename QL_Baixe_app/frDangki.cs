using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Baixe_app.DAO;
using QL_Baixe_app.DTO;
namespace QL_Baixe_app
{
    public partial class frDangki : Form
    {
        public frDangki()
        {
            InitializeComponent();

            LoadVethang_RaCbx(cbxTheID);
        }

        #region Method

        void LoadVethang_RaCbx(ComboBox cbx)
        {
            cbx.DataSource = DAO_Vethang.Instance.GetVeThangID();
            cbx.DisplayMember = "ID";
        }

        void AddKhachhang(string hoten, string sdt, string diachi, string socccd, string avt, DateTime ngaydk, string id_ve, int sodu, string mode_xe, string bienso)
        {
            if (txbKhachhang.Text == "" || txbSdt.Text == "" || txbDiachi.Text == "" || txbCCCD.Text == "" || avt_openFileDialog1.FileName == "" || txbTien.Text == "" || txbModexe.Text == "" || txbBienso.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ các TextBox", "ERROR!");
            }
            else
            {
                if (DAO_Khachhang.Instance.insertKH(hoten, sdt, diachi, socccd, avt, ngaydk, id_ve, sodu, mode_xe, bienso))
                {
                    MessageBox.Show("Thành công!", "THÔNG BÁO");
                }
                else MessageBox.Show("Không thành công", "LỖI!");
            }
        }
        #endregion

        #region Events
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frHome h = new frHome();
            this.Hide();
            h.ShowDialog();
        }

        private void btn_opflieAVT_Click(object sender, EventArgs e)
        {
            try
            {
                avt_openFileDialog1.ShowDialog();
                string file = avt_openFileDialog1.FileName;
                Image avt = Image.FromFile(file.ToString());
                ptbAvt.Image = avt;
                ptbAvt.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch { }
        }

        #endregion

        private void frDangki_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try{            
                 if (txbKhachhang.Text == "" || txbSdt.Text == "" || txbDiachi.Text == "" || txbCCCD.Text == "" || avt_openFileDialog1.FileName == "" || txbTien.Text == "" || txbModexe.Text == "" || txbBienso.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ các TextBox", "ERROR!");
                }
                else
                {
                    string hoten = txbKhachhang.Text;
                    string sdt = txbSdt.Text;
                    string diachi = txbDiachi.Text;
                    string socccd = txbCCCD.Text;
                    string avt = avt_openFileDialog1.FileName.ToString();
                    DateTime ngaydk = DateTime.Now;
                    string id_ve = (cbxTheID.SelectedItem as DTO_VeThang).Id.ToString();
                    int sodu = Convert.ToInt32(txbTien.Text);
                    string mode_xe = txbModexe.Text;
                    string bienso = txbBienso.Text;
                    if (DAO_Khachhang.Instance.insertKH(hoten, sdt, diachi, socccd, avt, ngaydk, id_ve, sodu, mode_xe, bienso))
                    {
                        MessageBox.Show("Thành công!", "THÔNG BÁO");
                    }
                    else MessageBox.Show("Không thành công", "LỖI!");
                }
            }
            catch { }
        }
    }
}
