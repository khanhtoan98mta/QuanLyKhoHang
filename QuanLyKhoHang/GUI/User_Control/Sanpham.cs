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
//using GUI;

namespace QuanlyKhohang.GUI
{
    public partial class Sanpham : UserControl
    {
      
        public Sanpham()
        {
            InitializeComponent();
            
        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(0);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {
                string query = "EXEC Sanpham_view";
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                connect.Close();
            }
            dataGridView1.DataSource = data.Tables[0];
        }
    }
}
