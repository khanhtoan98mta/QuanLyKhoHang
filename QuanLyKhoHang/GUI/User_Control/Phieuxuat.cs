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
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnChitietPX_Click(object sender, EventArgs e)
        {
            FormCT_Phieuxuat fr = new FormCT_Phieuxuat();
            int index = dataGridView1.SelectedRows.Count ;
            
        }
    }
}
