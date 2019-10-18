using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyKhoHang.GUI
{
    public partial class FormAdd_PhieuXuat : Form
    {
        ConnectString cnn = new ConnectString();
        SqlConnection conn;
        SqlDataAdapter adap;
        string query = "";
        DataTable data_sanpham = new DataTable();
        DataTable data_nhanvien = new DataTable();
        
        public FormAdd_PhieuXuat()
        {
            InitializeComponent();
        }

        void load()
        {
             
            try
            {
                conn = new SqlConnection(cnn.getConnectionString(1));
                query = "select *from Sanpham";
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(data_sanpham);
                query = "select *from Nhanvien";
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(data_nhanvien);
            }
            catch
            {

            }

            cb_Sanpham.ValueMember = "IDSP";
            cb_Sanpham.DisplayMember = "TenSP";
            cb_Sanpham.DataSource = data_sanpham;
            cb_Nhanvien.ValueMember = "IDNV";
            cb_Nhanvien.DisplayMember = "TenNV";
            cb_Nhanvien.DataSource = data_nhanvien;

            
        }
        private void Add_PhieuXuat_Load(object sender, EventArgs e)
        {
            listView_PhieuXuat.View = View.Details;
            listView_PhieuXuat.Columns.Add("", 1, HorizontalAlignment.Center);
            listView_PhieuXuat.Columns.Add("Mã sản phẩm", 100, HorizontalAlignment.Center);
            listView_PhieuXuat.Columns.Add("Sản phẩm", 350, HorizontalAlignment.Center);
            listView_PhieuXuat.Columns.Add("Đơn giá", 200, HorizontalAlignment.Left);

            load();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_Sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(cb_Sanpham.SelectedValue.ToString());
                txt_DonGia.Text = data_sanpham.Rows[value-1]["Gia"].ToString();
            }
           catch{ }


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(cb_Sanpham.SelectedValue.ToString());
            lvi.SubItems.Add(cb_Sanpham.Text.Trim());
            lvi.SubItems.Add(txt_DonGia.Text.Trim());
            listView_PhieuXuat.Items.Add(lvi);
        }
    }
}
