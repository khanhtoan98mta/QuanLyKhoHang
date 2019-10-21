namespace QuanLyKhoHang.GUI
{
    partial class FormAdd_PhieuXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Sanpham = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_PhieuXuat = new System.Windows.Forms.ListView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DonGia = new Guna.UI.WinForms.GunaTextBox();
            this.cb_Nhanvien = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Enail = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Khachhang = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.dtp_Ngayxuat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhân viên:";
            // 
            // cb_Sanpham
            // 
            this.cb_Sanpham.FormattingEnabled = true;
            this.cb_Sanpham.Location = new System.Drawing.Point(582, 32);
            this.cb_Sanpham.Name = "cb_Sanpham";
            this.cb_Sanpham.Size = new System.Drawing.Size(160, 24);
            this.cb_Sanpham.TabIndex = 4;
            this.cb_Sanpham.SelectedIndexChanged += new System.EventHandler(this.cb_Sanpham_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sản phẩm:";
            // 
            // listView_PhieuXuat
            // 
            this.listView_PhieuXuat.HideSelection = false;
            this.listView_PhieuXuat.Location = new System.Drawing.Point(13, 316);
            this.listView_PhieuXuat.Name = "listView_PhieuXuat";
            this.listView_PhieuXuat.Size = new System.Drawing.Size(775, 283);
            this.listView_PhieuXuat.TabIndex = 6;
            this.listView_PhieuXuat.UseCompatibleStateImageBehavior = false;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(166, 261);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 36);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(296, 261);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 36);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(427, 261);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(98, 36);
            this.btn_luu.TabIndex = 9;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đơn giá:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BaseColor = System.Drawing.Color.White;
            this.txt_DonGia.BorderColor = System.Drawing.Color.Silver;
            this.txt_DonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DonGia.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DonGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DonGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DonGia.Location = new System.Drawing.Point(582, 68);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.PasswordChar = '\0';
            this.txt_DonGia.Size = new System.Drawing.Size(160, 34);
            this.txt_DonGia.TabIndex = 11;
            // 
            // cb_Nhanvien
            // 
            this.cb_Nhanvien.FormattingEnabled = true;
            this.cb_Nhanvien.Location = new System.Drawing.Point(582, 132);
            this.cb_Nhanvien.Name = "cb_Nhanvien";
            this.cb_Nhanvien.Size = new System.Drawing.Size(160, 24);
            this.cb_Nhanvien.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 228);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Enail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Khachhang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // txt_Enail
            // 
            this.txt_Enail.BaseColor = System.Drawing.Color.White;
            this.txt_Enail.BorderColor = System.Drawing.Color.Silver;
            this.txt_Enail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Enail.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Enail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Enail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Enail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Enail.Location = new System.Drawing.Point(120, 166);
            this.txt_Enail.Name = "txt_Enail";
            this.txt_Enail.PasswordChar = '\0';
            this.txt_Enail.Size = new System.Drawing.Size(160, 30);
            this.txt_Enail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BaseColor = System.Drawing.Color.White;
            this.txt_SDT.BorderColor = System.Drawing.Color.Silver;
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_SDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.Location = new System.Drawing.Point(120, 120);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.Size = new System.Drawing.Size(160, 30);
            this.txt_SDT.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BaseColor = System.Drawing.Color.White;
            this.txt_DiaChi.BorderColor = System.Drawing.Color.Silver;
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DiaChi.Location = new System.Drawing.Point(120, 73);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.Size = new System.Drawing.Size(160, 30);
            this.txt_DiaChi.TabIndex = 2;
            this.txt_DiaChi.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Khachhang
            // 
            this.txt_Khachhang.BaseColor = System.Drawing.Color.White;
            this.txt_Khachhang.BorderColor = System.Drawing.Color.Silver;
            this.txt_Khachhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Khachhang.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Khachhang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Khachhang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Khachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Khachhang.Location = new System.Drawing.Point(120, 22);
            this.txt_Khachhang.Name = "txt_Khachhang";
            this.txt_Khachhang.PasswordChar = '\0';
            this.txt_Khachhang.Size = new System.Drawing.Size(160, 30);
            this.txt_Khachhang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã phiếu:";
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(582, 226);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Size = new System.Drawing.Size(160, 22);
            this.txt_MaPhieu.TabIndex = 15;
            // 
            // dtp_Ngayxuat
            // 
            this.dtp_Ngayxuat.Location = new System.Drawing.Point(582, 183);
            this.dtp_Ngayxuat.Name = "dtp_Ngayxuat";
            this.dtp_Ngayxuat.Size = new System.Drawing.Size(160, 22);
            this.dtp_Ngayxuat.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày xuất:";
            // 
            // FormAdd_PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_Ngayxuat);
            this.Controls.Add(this.txt_MaPhieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_Nhanvien);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.listView_PhieuXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Sanpham);
            this.Controls.Add(this.label2);
            this.Name = "FormAdd_PhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu xuất";
            this.Load += new System.EventHandler(this.Add_PhieuXuat_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Sanpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_PhieuXuat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_DonGia;
        private System.Windows.Forms.ComboBox cb_Nhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaTextBox txt_DiaChi;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txt_Khachhang;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_Enail;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txt_SDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.DateTimePicker dtp_Ngayxuat;
        private System.Windows.Forms.Label label9;
    }
}