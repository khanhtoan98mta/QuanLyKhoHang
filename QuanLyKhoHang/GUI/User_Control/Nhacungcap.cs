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
    public partial class Nhacungcap : UserControl
    {
        public Nhacungcap()
        {
            InitializeComponent();

        }
        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(1);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {
                string query = "select Nhacungcap.IDNCC as 'Mã nhà cc' , Nhacungcap.TenNCC as 'Tên nhà cc',Nhacungcap.Dienthoai as 'SĐT' , Diachi as 'Địa chỉ' , Nhacungcap.Email as 'Email' from Nhacungcap   ";
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                connect.Close();
            }
            dataGridView1.DataSource = data.Tables[0];
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }


        #region Handle button


        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void Text_Changed(object sender, EventArgs e)
        {


        }
    }
}
