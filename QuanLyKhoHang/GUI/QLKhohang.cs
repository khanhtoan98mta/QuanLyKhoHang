
using QuanlyKhohang.GUI;
using QuanLyKhoHang;
using System;
using System.Windows.Forms;

namespace QuanlyKhoHang
{
    public partial class QLKhohang : Form
    {
        public QLKhohang()
        {
            InitializeComponent();
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ToolStripDropDownItem ts = (ToolStripDropDownItem)sender;
            if (ts.Text == "Nhà cung cấp")
                panel1.Controls.Add(new Nhacungcap());
            else if (ts.Text == "Khách hàng")
                panel1.Controls.Add(new Khachhang());
            else if (ts.Text == "Sản phẩm")
                panel1.Controls.Add(new Sanpham());
            else if (ts.Text == "Phiếu nhập")
                panel1.Controls.Add(new Phieunhap());
            else if (ts.Text == "Phiếu xuất")
                panel1.Controls.Add(new Phieuxuat());
            else if (ts.Text == "Hướng dẫn")
                panel1.Controls.Add(new Huongdan());
            else if(ts.Text == "Đăng xuất")
            {
                FormDangnhap frr = new FormDangnhap();
                this.Hide();
                frr.Show();
            }
            else if (ts.Text == "Thoát")
                Application.Exit();

        }

        private void QLKhohang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
