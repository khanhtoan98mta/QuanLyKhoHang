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
    public partial class FormCT_Phieuxuat : Form
    {
        int id;
        ConnectString cnn = new ConnectString();
        SqlConnection conn;
        SqlDataAdapter adap;
        string query = "";
        public FormCT_Phieuxuat()
        {
            InitializeComponent();
        }
        public void setId(int _id)
        {
            id = _id;
        }
        void load()
        {
            conn = new SqlConnection(cnn.getConnectionString(1));
            query = "select *from ChitietPhieuxuat where PXID='" + id.ToString() + "'";
            
        }

        private void FormCT_Phieuxuat_Load(object sender, EventArgs e)
        {

        }
    }
}
