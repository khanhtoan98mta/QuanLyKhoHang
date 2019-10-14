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
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        #region hand click button
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region  load data with paramerter
        private DataSet GetData(string query)
        {
            DataSet res;
            using (SqlConnection connection = new SqlConnection(cnn.getConnectionString())
            {
                connection.Open();

               


                connection.Close();
            }
            return res;
        }

        #endregion

    }

}
