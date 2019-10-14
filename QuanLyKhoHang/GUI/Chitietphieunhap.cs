
using QuanLyKhoHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhohang.GUI
{
    public partial class Chitietphieunhap : Form
    {
        string Id;
        private string DataAccess(string query)
        {
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(0);


            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlCommand apter = new SqlCommand(query, connect);
                var x = apter.ExecuteScalar();
                return x.ToString();
                connect.Close();
            }
        }
        public Chitietphieunhap(string id)
        {
            InitializeComponent();
            Id = id;
            
        }
        public void GetValue1(string pnid, string nccid)
        {
            txtPNID1.Text = pnid;
            txtNCCID.Text = nccid;
        }
        private void Chitietphieunhap_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(0);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {
                string query = "select * from Chitietphieunhap_view( " + Id + ")" ;
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                connect.Close();
            }
            dataGridView2.DataSource = data.Tables[0];
            txtSoluong.Text = DataAccess("select * from GetAmount(" + txtPNID.Text + ")");
            txtTongtien.Text = DataAccess("select * from GetTotal(" + txtPNID.Text + ")");
        }

        #region CellContentClick
        int trangThai = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            trangThai = 0;
            txtID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtSanpham.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            btnXoa.Enabled = false;
            txtSoluong.Focus();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            trangThai = 1;
            txtID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtSanpham.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtSoluong.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            btnXoa.Enabled = true;
            txtSoluong.Focus();
        }
        #endregion

        #region ButtonHandle
        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
          
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion


    }
}
