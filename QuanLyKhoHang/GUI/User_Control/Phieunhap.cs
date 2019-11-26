using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhoHang;
//using QuanlyKhohang.BUS;
//using GUI;
//ousing QuanlyKhohang.DataLayer;

namespace QuanlyKhohang.GUI
{
    public partial class Phieunhap : UserControl
    {
        ConnectString cnn = null;
        public Phieunhap()
        {
            InitializeComponent();
            cnn = new ConnectString();

        }
        private void Phieunhap_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(1);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {
                string query = "EXEC Phieunhap_view";
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                connect.Close();
            }
            dataGridView1.DataSource = data.Tables[0];
        }

        private string DataAccess(string query)
        {
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(1);


            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlCommand apter = new SqlCommand(query, connect);
                var x = apter.ExecuteScalar();
                return x.ToString();
                connect.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPNID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNhanvien.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtPNgaynhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTongsoluong.Text = DataAccess("select * from GetAmount(" + txtPNID.Text + ")");
            txtTongtien.Text = DataAccess("select * from GetTotal(" + txtPNID.Text + ")");
            txtNCCID.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNVID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        #region hand click button
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region  load data with paramerter


        #endregion

        private void btnChitietPX_Click(object sender, EventArgs e)
        {
            //Chitietphieunhap f = new Chitietphieunhap(txtPNID.Text);
            //f.Show();
        }
    }

}
