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
            LoadListKhachhang();
        }

        #region Method

        void LoadVethang_RaCbx(ComboBox cbx)
        {
            cbx.DataSource = DAO_Vethang.Instance.GetVeThangID();
            cbx.DisplayMember = "ID";
        }

        void LoadListKhachhang()
        {
            dgvDSKH.DataSource = DAO_Khachhang.Instance.DSKhachhang();
        }

        void BingdingKH()
        {
            try {              
                txbKhachhang.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
                txbBienso.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "BIENSO", true, DataSourceUpdateMode.Never));
                txbSdt.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "SDT", true, DataSourceUpdateMode.Never));
                txbDiachi.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
                txbModexe.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "MODE_XE", true, DataSourceUpdateMode.Never));
                txbTien.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "SODU", true, DataSourceUpdateMode.Never));
                txbCCCD.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "SO_CCCD", true, DataSourceUpdateMode.Never));
 
            }
            catch { }
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

        void ClearTextbox()
        {
            txbKhachhang.Clear();
            txbSdt.Clear();
            txbDiachi.Clear();
            txbCCCD.Clear();
            txbTien.Clear();
            txbModexe.Clear();
            txbBienso.Clear();
            avt_openFileDialog1.FileName = "";
        }
        #endregion

        private void frDangki_Load(object sender, EventArgs e)
        {

        }
        bool thaotac;
        private void btnThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            ClearTextbox();
            cbxTheID.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            thaotac = false;
            BingdingKH();
            cbxTheID.Visible = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (thaotac == true) // thêm
            {
                try
                {
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
                        string id_ve = (cbxTheID.SelectedItem as DTO_VeThang).Id.ToString();
                        int sodu = Convert.ToInt32(txbTien.Text);
                        string mode_xe = txbModexe.Text;
                        string bienso = txbBienso.Text;

                        if (DAO_Khachhang.Instance.insertKH(hoten, sdt, diachi, socccd, avt, id_ve, sodu, mode_xe, bienso))
                        {
                            MessageBox.Show("Thành công!", "THÔNG BÁO");
                        }
                        else MessageBox.Show("Không thành công", "LỖI!");
                    }
                }
                catch
                {
                    MessageBox.Show(" Không Thành công!", "ERROR!");
                }
            }
            else // sửa
            {

            }
        }

       
    }
}
