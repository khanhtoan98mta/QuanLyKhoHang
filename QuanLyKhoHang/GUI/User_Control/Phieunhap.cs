﻿using System;
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
            string con = cnn.getConnectionString(FormDangnhap.checkConnectionString);
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
        private void reloadData()
        {
            dataGridView1.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(FormDangnhap.checkConnectionString);
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
            string con = cnn.getConnectionString(FormDangnhap.checkConnectionString);


            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlCommand apter = new SqlCommand(query, connect);
                var x = apter.ExecuteScalar();
                return x.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string nccid = txtNCCID.Text;
            string nvid = txtNVID.Text;
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(FormDangnhap.checkConnectionString);
            string query = "EXEC dbo.Phieunhap_insert @nccid = @nccid, @nvid = @nvid, @ngaynhap =  @ngaynhap";
            DataSet data = new DataSet();
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@nccid", nccid);
                command.Parameters.AddWithValue("@nvid", nvid);
                command.Parameters.AddWithValue("@ngaynhap", DateTime.Now.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
                connect.Close();
            }
            MessageBox.Show("Thêm thành công");
            reloadData();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string con = cnn.getConnectionString(FormDangnhap.checkConnectionString);
            string query = "EXEC dbo.Phieunhap_delete @id = @id";
            DataSet data = new DataSet();
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@id", txtPNID.Text);
                command.ExecuteNonQuery();
                connect.Close();
            }
            MessageBox.Show("Xóa thành công");
            reloadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtPNgaynhap.Value.ToString("yyyy-MM-dd"));
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(FormDangnhap.checkConnectionString);
            string query = "EXEC dbo.Phieunhap_update  @id = @id, @nccid = @nccid, @nvid = @nvid, @ngaynhap =  @ngaynhap";
            DataSet data = new DataSet();
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@id", txtPNID.Text);
                command.Parameters.AddWithValue("@nccid", txtNCCID.Text);
                command.Parameters.AddWithValue("@nvid", txtNVID.Text);
                command.Parameters.AddWithValue("@ngaynhap", dtPNgaynhap.Value.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
                connect.Close();
            }
            MessageBox.Show("Chỉnh sửa thành công");
            reloadData();
        }

        private void txtTKTenNCC_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
