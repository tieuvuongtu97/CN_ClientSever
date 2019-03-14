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

            LoadListKhachhang();
            LoadVethang_RaCbx_themKH(cbxTheID);
        }
        int pageSize = 8;
        int page = 1;

        #region Method
      
        void LoadListKhachhang()
        {
            //dgvDSKH.DataSource = DAO_Khachhang.Instance.DSKhachhang();
            int tongkh = DAO_Khachhang.Instance.TongKh();
            int trangcuoi = tongkh / pageSize;
            if (tongkh % pageSize != 0)
                trangcuoi++;
            txbNow.Text = page.ToString() + "/" + trangcuoi.ToString();
            dgvDSKH.DataSource = DAO_Khachhang.Instance.DSKhachhang_Page(page , pageSize);
            lbLuotkhach.Text = "Số khách: " + tongkh.ToString();
         }
      
        void BingdingKH()
        {
            try {
                // - kiểu - sourse - tên cột - true: tự động ép kiểu - never: sửa bên txb nhưng không thay đổi bên dgv
                txbKhachhang.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
                txbBienso.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "BIENSO", true, DataSourceUpdateMode.Never));
                txbSdt.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "SDT", true, DataSourceUpdateMode.Never));
                txbDiachi.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
                txbModexe.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "MODE_XE", true, DataSourceUpdateMode.Never));
                txbTien.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "SODU", true, DataSourceUpdateMode.Never));
                txbCCCD.DataBindings.Add(new Binding("text", dgvDSKH.DataSource, "SO_CCCD", true, DataSourceUpdateMode.Never));
                LoadIdVeThangInCombobox(cbxTheID);
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

        string GetIdKhachhangbyCCCD(string cccd)
        {       
            string idkh = DAO_Khachhang.Instance.GetIdKhachhangbyCCCD(cccd);
            return idkh;
        }
        // dùng khi them khách hàng
        void LoadVethang_RaCbx_themKH(ComboBox cbx)
        {
            cbx.DataSource = DAO_Vethang.Instance.GetVeThangID();
            cbx.DisplayMember = "ID";
        }

        // dùng binding vé id
        public void LoadIdVeThangInCombobox(ComboBox cbx)
        {
            cbx.DataSource = DAO_Vethang.Instance.DSVeThang();
            cbx.DisplayMember = "ID";
        }

        void EnableTextbox()
        {
            txbKhachhang.Enabled = true;
            txbSdt.Enabled = true;
            txbCCCD.Enabled = true;
            txbDiachi.Enabled = true;
            txbTien.Enabled = true;
            txbModexe.Enabled = true;
            txbBienso.Enabled = true;   
        }

        void DisableTextbox()
        {
            txbKhachhang.Enabled = false;
            txbSdt.Enabled = false;
            txbCCCD.Enabled = false;
            txbDiachi.Enabled = false;
            txbTien.Enabled = false;
            txbModexe.Enabled = false;
            txbBienso.Enabled = false;
        }
        #endregion

        #region Events

        bool thaotac;

        private void btnThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            ClearTextbox();
            LoadVethang_RaCbx_themKH(cbxTheID);
            EnableTextbox();
            cbxTheID.Enabled = true;
        }

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

        private void btnDau_Click(object sender, EventArgs e)
        {
            page = 1;
            LoadListKhachhang();
            BingdingKH();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (page > 1)
                page = page - 1;
            LoadListKhachhang();
            BingdingKH();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int tongkh = DAO_Khachhang.Instance.TongKh();
            if (page * pageSize < tongkh)
                page = page + 1;
            LoadListKhachhang();
            BingdingKH();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            int tongkh = DAO_Khachhang.Instance.TongKh();
            int trangcuoi = tongkh / pageSize;
            if (tongkh % pageSize != 0)
                trangcuoi++;
            page = trangcuoi;
            LoadListKhachhang();
            BingdingKH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            thaotac = false;
         
            EnableTextbox();
            cbxTheID.Enabled = false;
            BingdingKH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BingdingKH();
                DisableTextbox();
                cbxTheID.Enabled = false;
                string cccd = txbCCCD.Text;
                string id = GetIdKhachhangbyCCCD(cccd);

                if (MessageBox.Show("Xóa toàn bộ thông tin liên quan đến Khách Hàng?", "Cảnh báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (DAO_Khachhang.Instance.delKH(id))
                    {
                        MessageBox.Show(String.Format("Xóa thành công Khách Hàng có mã {0}", id, "Thành Công!"));
                        ClearTextbox();
                    }
                }
                LoadListKhachhang();
            }
            catch { }
        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BingdingKH();
            cbxTheID.Enabled = false;
        }

        private void txbBiensoChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSKH.SelectedCells.Count > 0)
                {
                    string bienso = dgvDSKH.SelectedCells[0].OwningRow.Cells["BIENSO"].Value.ToString();
                    DTO_VeThang vt = DAO_Vethang.Instance.GetVeThangbyBienSo(bienso);

                    cbxTheID.SelectedItem = vt;

                    int index = -1;
                    int i = 0;
                    foreach (DTO_VeThang item in cbxTheID.Items)
                    {
                        if (item.Id == vt.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbxTheID.SelectedIndex = index;            
                }
            }
            catch { }
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

                        if (sdt.Length > 10)
                        {
                            MessageBox.Show(" Số điện thoại tối đa 10 số!", "THÔNG BÁO");
                        }
                        else if (socccd.Length > 12)
                        {
                            MessageBox.Show(" Số CCCD tối đa 12 số!", "THÔNG BÁO");
                        }
                        else if (bienso.Length > 10)
                        {
                            MessageBox.Show(" Biển số tối đa 10 kí tự!", "THÔNG BÁO");
                        }
                        else if (DAO_Khachhang.Instance.insertKH(hoten, sdt, diachi, socccd, avt, id_ve, sodu, mode_xe, bienso))
                        {
                            MessageBox.Show("Thành công!", "THÔNG BÁO");
                            LoadListKhachhang();
                            BingdingKH();
                        }
                                                  
                    }
                }
                catch
                {
                    MessageBox.Show(" Không Thành công!", "ERROR!");
                }
            }
            else // sửa
            {
                try
                {              
                    if (txbKhachhang.Text == "" || txbSdt.Text == "" || txbDiachi.Text == "" || txbCCCD.Text == "" || avt_openFileDialog1.FileName == "" || txbTien.Text == "" || txbModexe.Text == "" || txbBienso.Text == "")
                    {
                        MessageBox.Show("Nhập đầy đủ các TextBox", "ERROR!");
                    }
                    else
                    {
                        string veid = cbxTheID.Text;
                        string hoten = txbKhachhang.Text;      
                        string sdt = txbSdt.Text;
                        string socccd = txbCCCD.Text;
                        string diachi = txbDiachi.Text;
                        string avt = avt_openFileDialog1.FileName.ToString();
                        int sodu =Convert.ToInt32(txbTien.Text);
                        string modexe = txbModexe.Text;
                        string bienso = txbBienso.Text;
                        if (sdt.Length > 10)
                        {
                            MessageBox.Show(" Số điện thoại tối đa 10 số!", "THÔNG BÁO");
                        }
                        else if (socccd.Length > 12)
                        {
                            MessageBox.Show(" Số CCCD tối đa 12 số!", "THÔNG BÁO");
                        }
                        else if (bienso.Length > 10)
                        {
                            MessageBox.Show(" Biển số tối đa 10 kí tự!", "THÔNG BÁO");
                        }
                        else
                       if (DAO_Khachhang.Instance.editKH(veid, hoten, sdt, diachi, socccd, avt, sodu, modexe, bienso))
                        {
                            MessageBox.Show(" Sửa thành công!", "THÔNG BÁO");
                            LoadListKhachhang();
                            BingdingKH();
                        }
                    }
                }
                catch{
                    MessageBox.Show(" Không thành công!", "ERROR!");
                }       
            }
        }

    #endregion
    }
}
