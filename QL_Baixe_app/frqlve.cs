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
    public partial class frqlve : Form
    {
        public frqlve()
        {
            InitializeComponent();
            LoadInitial();
        }

        void LoadInitial()
        {
            Loadvengay();
            //Loadvethang();
        }

        void Loadvengay()
        {
            dtgv.DataSource = DAO_Vengay.Instance.GetListvengay();
        }

        void Loadvethang()
        {
            dtgv.DataSource = DAO_Vethang.Instance.GetListvethang();
        }


        private void btnvengay_Click(object sender, EventArgs e)
        {
            Loadvengay();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            frHome h = new frHome();
            this.Hide();
            h.ShowDialog();
        }

        private void btnvethang_Click(object sender, EventArgs e)
        {
            Loadvethang();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frthemve v = new frthemve();
            v.ShowDialog();
        }

        
    }
}
