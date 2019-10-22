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
//ousing QuanlyKhohang.DataLayer;

namespace QuanlyKhohang.GUI
{
    public partial class Phieunhap : UserControl
    {
       
        public Phieunhap()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetData("SELECT IDPN,TenNCC,TenNV,Ngaynhap FROM dbo.Phieunhap,dbo.Nhacungcap,dbo.Nhanvien WHERE NCCID = IDNCC AND NVID = IDNV ").Tables[0];
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }
        private void Phieunhap_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;\
            t

        }

        #region hand click button
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region  load data with paramerter
        private DataSet GetData(string query)
        {
            DataSet data = new DataSet();
            ConnectString b = new ConnectString();
            string con = b.getConnectionString(FormDangnhap.checkConnectionString);
            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, con);
                apter.Fill(data);
                connect.Close();
            }
            return data;
        }

        #endregion

    }

}
