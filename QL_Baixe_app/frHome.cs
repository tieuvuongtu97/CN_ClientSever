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
    public partial class frHome : Form
    {
        public frHome()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frLogin l = new frLogin();
            this.Hide();
            l.ShowDialog();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            frDangki dk = new frDangki();
            this.Hide();
            dk.ShowDialog();
        }
    }
}
