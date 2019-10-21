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
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(cnn.getConnectionString(1));
                query = "select *from Sanpham";
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(data_sanpham);
                query = "select *from Nhanvien";
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(data_nhanvien);
                query = "select *from Phieuxuat order by IDPX desc";
                
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(dt);

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
            int maphieu = Convert.ToInt32(dt.Rows[0]["IDPX"].ToString());
            maphieu++;
            txt_MaPhieu.Text = maphieu.ToString();

        }
        private void Add_PhieuXuat_Load(object sender, EventArgs e)
        {
            listView_PhieuXuat.View = View.Details;
            listView_PhieuXuat.Columns.Add("", 1, HorizontalAlignment.Center);
            listView_PhieuXuat.Columns.Add("Mã sản phẩm", 50, HorizontalAlignment.Center);
            listView_PhieuXuat.Columns.Add("Sản phẩm", 250, HorizontalAlignment.Center);
            listView_PhieuXuat.Columns.Add("Đơn giá", 150, HorizontalAlignment.Center);
            listView_PhieuXuat.Columns.Add("Số lượng ", 150, HorizontalAlignment.Center);
     


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
            int i = 0;
            foreach (ListViewItem item in listView_PhieuXuat.Items)
            {
                i++;
                if(cb_Sanpham.Text.Trim()==item.SubItems[2].Text.Trim())
                {
                          
                    int temp = Convert.ToInt32(item.SubItems[4].Text.ToString().Trim());
                    temp++;
                    listView_PhieuXuat.Items[i-1].SubItems[4].Text = temp.ToString();
                    return;
                }
        }
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(cb_Sanpham.SelectedValue.ToString());
            lvi.SubItems.Add(cb_Sanpham.Text.Trim());
            lvi.SubItems.Add(txt_DonGia.Text.Trim());
            lvi.SubItems.Add("1");
            listView_PhieuXuat.Items.Add(lvi);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(txt_Khachhang.Text!="")
            {
                conn = new SqlConnection(cnn.getConnectionString(1));
                try
                {   
                    SqlCommand cmd = new SqlCommand("Khachhang_insert",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ten", txt_Khachhang.Text.Trim());
                    cmd.Parameters.AddWithValue("@diachi", txt_DiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@dienthoai", txt_SDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txt_Enail.Text.Trim());
                    cmd.ExecuteNonQuery();

                    string nvid = cb_Nhanvien.SelectedValue.ToString();
                    cmd = new SqlCommand("Phieuxuat_insert",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tenkh", txt_Khachhang.Text.Trim());
                    cmd.Parameters.AddWithValue("@nvid", Convert.ToInt32(nvid));
                    cmd.Parameters.AddWithValue("@ngayxuat", dtp_Ngayxuat.Value);
                    cmd.ExecuteNonQuery();

                    
                    foreach (ListViewItem item in listView_PhieuXuat.Items)
                    {
                        cmd = new SqlCommand("Chitietphieuxuat_insert_update",conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pxid", Convert.ToInt32(txt_MaPhieu.Text.Trim()));
                        cmd.Parameters.AddWithValue("@spid", Convert.ToInt32(item.SubItems["Mã sản phảm"].ToString()));
                        cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(item.SubItems["Số lượng"].ToString()));
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Thành công!");

                }
                catch
                {
                    MessageBox.Show("Thất bại!");
                }
                    
            }
        }
    }
}
