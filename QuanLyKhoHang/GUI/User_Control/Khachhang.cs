using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhoHang;
using System.Data.SqlClient;
//using QuanlyKhohang.BUS;

namespace QuanlyKhohang.GUI
{
    public partial class Khachhang : UserControl
    {
     
        public Khachhang()
        {
            InitializeComponent();
      
        }
        private void Khachhang_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(0);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {
                string query = " select Khachhang.IDKH as 'Mã khách hàng', Khachhang.TenKH as 'Họ tên' , Khachhang.Dienthoai as 'SĐT' " 
 + ", Khachhang.Email as 'Email', Khachhang.Diachi as 'Địa chỉ' from Khachhang ";
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                connect.Close();
            }
            dataGridView1.DataSource = data.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        

        #region 
        private void btnThem_Click(object sender, EventArgs e)
        {
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
          
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
        }
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
         
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }
        #endregion

        private void txtTKTenKH_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
