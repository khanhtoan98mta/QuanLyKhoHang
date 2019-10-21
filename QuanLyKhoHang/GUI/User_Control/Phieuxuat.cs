using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QuanlyKhohang.BUS;
//using QuanlyKhohang.DataLayer;
using QuanlyKhohang.GUI;
using QuanLyKhoHang;
using System.Data.SqlClient;
using QuanLyKhoHang.GUI;
namespace QuanlyKhohang.GUI
{
    public partial class Phieuxuat : UserControl
    {

        SqlConnection conn;
        ConnectString cnn = new ConnectString();
        DataTable data = new DataTable();
        public Phieuxuat()
        {
            InitializeComponent();
        }
        void load()
        {
            dataGridView1.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(1);
            DataTable dt = new DataTable();

            using (SqlConnection connect = new SqlConnection(con))
            {
                string query = "select *from Phieuxuat_view";
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(dt);
                connect.Close();
            }
            dataGridView1.DataSource = dt;
            
        }
        void search(string searchStringKh,string searchStringNv)
        {
            
            //dataGridView1.Columns.Clear();
            string query = "";
           
                query = "select *from Phieuxuat_view where [Khách hàng] like N'%" + searchStringKh + "%'" +
                    "and [Nhân viên] like N'%"+searchStringNv+"%'";
            
            conn = new SqlConnection(cnn.getConnectionString(1));
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void Phieuxuat_Load_1(object sender, EventArgs e)
        {
           
            load();
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            txt_KH.Text = dataGridView1.Rows[index].Cells["Khách hàng"].Value.ToString();
            txt_Nhanvien.Text = dataGridView1.Rows[index].Cells["Nhân viên"].Value.ToString();
    
           
        }

        private void btnChitietPX_Click(object sender, EventArgs e)
        {
            FormCT_Phieuxuat fr = new FormCT_Phieuxuat();
            int index = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[index].Cells["Mã phiếu"].Value.ToString());
            fr.setId(id);
            fr.Show();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdd_PhieuXuat fr = new FormAdd_PhieuXuat();
                fr.Show();
            }
            catch
            {

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(cnn.getConnectionString(1));
            int index = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[index].Cells["Mã phiếu"].Value.ToString());
            SqlCommand cmd = new SqlCommand("Phieuxuat_delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            load();
            
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            load();
        }

        private void txtTKTenKH_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtTKNhanvien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            search(txtTKTenKH.Text.Trim(), txtTKNhanvien.Text.Trim());
        }
    }
}
