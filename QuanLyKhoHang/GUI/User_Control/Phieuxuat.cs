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
       
        public Phieuxuat()
        {
            InitializeComponent();
        }
        void load(int index)
        {
            txt_KH.Text = dataGridView1.Rows[index].Cells["Khách hàng"].Value.ToString();
            txt_Nhanvien.Text = dataGridView1.Rows[index].Cells["Nhân viên"].Value.ToString();
        }
        private void Phieuxuat_Load_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(1);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {
                string query = "EXEC Phieuxuat_view";
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                connect.Close();
            }
            dataGridView1.DataSource = data.Tables[0];
            load(0);
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            load(index);
           
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
            FormAdd_PhieuXuat fr = new FormAdd_PhieuXuat();
            fr.Show();

        }
    }
}
