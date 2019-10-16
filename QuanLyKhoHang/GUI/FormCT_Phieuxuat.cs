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
        int TinhTien()
        {
            int temp = Convert.ToInt32(dtgv_CtPhieuXuat.Rows[0].Cells["Giá"].Value.ToString());
            int Sum = 0;
            for(int i=0;i<dtgv_CtPhieuXuat.Rows.Count;i++)
            {
                Sum = Sum + Convert.ToInt32(dtgv_CtPhieuXuat.Rows[i].Cells["Giá"].Value.ToString());
            }
            return Sum;
        }
        void load()
        {
            try
            {
                conn = new SqlConnection(cnn.getConnectionString(1));
                SqlCommand cmd = new SqlCommand("Chitietphieuxuat_view", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                adap = new SqlDataAdapter(cmd);
                DataTable data_ct = new DataTable();
                adap.Fill(data_ct);
                dtgv_CtPhieuXuat.DataSource = data_ct;
            }
            catch
            {
                
            }
            txt_MaPhieu.Text = id.ToString();
            txt_TongTien.Text = TinhTien().ToString();
              
            
        }

        private void FormCT_Phieuxuat_Load(object sender, EventArgs e)
        {
            txt_MaPhieu.Enabled = false;
            txt_TongTien.Enabled = false;
            load();
            

        }
    }
}
