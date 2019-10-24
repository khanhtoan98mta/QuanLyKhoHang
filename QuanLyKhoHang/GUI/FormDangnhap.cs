using QuanlyKhoHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class FormDangnhap : Form
    {
        internal static int checkConnectionString;

        public FormDangnhap()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void FormDăngnhap_Load(object sender, EventArgs e)
        {

        }
        public void check()
        {
            ConnectString check = new ConnectString();
            checkConnectionString = check.checkCnn();
        }
        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {
            QLKhohang f1 = new QLKhohang();
            this.Hide();
            f1.Show();
        }
    }
}
