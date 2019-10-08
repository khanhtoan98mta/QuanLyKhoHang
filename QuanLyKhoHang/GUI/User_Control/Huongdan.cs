using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhohang.GUI
{
    public partial class Huongdan : UserControl
    {
        public Huongdan()
        {
            InitializeComponent();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text=="Nhà cung cấp")
                webBrowser1.Navigate(@"C:\Users\dell\Documents\Visual Studio 2015\Projects\QuanlyKhohang\QuanlyKhohang\Guide\Nhacungcap.html");
            if (e.Node.Text == "Khách hàng")
                webBrowser1.Navigate(@"C:\Users\dell\Documents\Visual Studio 2015\Projects\QuanlyKhohang\QuanlyKhohang\Guide\Khachhang.html");
            if (e.Node.Text == "Sản phẩm")
                webBrowser1.Navigate(@"C:\Users\dell\Documents\Visual Studio 2015\Projects\QuanlyKhohang\QuanlyKhohang\Guide\Sanpham.html");
            if (e.Node.Text == "Phiếu xuất")
                webBrowser1.Navigate(@"C:\Users\dell\Documents\Visual Studio 2015\Projects\QuanlyKhohang\QuanlyKhohang\Guide\Phieuxuat.html");
            if (e.Node.Text == "Phiếu nhập")
                webBrowser1.Navigate(@"C:\Users\dell\Documents\Visual Studio 2015\Projects\QuanlyKhohang\QuanlyKhohang\Guide\Phieunhap.html");
        }
    }
}
