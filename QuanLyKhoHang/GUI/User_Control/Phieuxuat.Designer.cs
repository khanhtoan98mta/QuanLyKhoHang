namespace QuanlyKhohang.GUI
{
    partial class Phieuxuat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPXID = new System.Windows.Forms.TextBox();
            this.txtNVID = new System.Windows.Forms.TextBox();
            this.txtKHID = new System.Windows.Forms.TextBox();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.dtPNgayxuat = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChitietPX = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nhanvien = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTKTenKH = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTKNhanvien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPXID
            // 
            this.txtPXID.Location = new System.Drawing.Point(433, 110);
            this.txtPXID.Name = "txtPXID";
            this.txtPXID.Size = new System.Drawing.Size(143, 24);
            this.txtPXID.TabIndex = 26;
            this.txtPXID.Visible = false;
            // 
            // txtNVID
            // 
            this.txtNVID.Location = new System.Drawing.Point(433, 2);
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.Size = new System.Drawing.Size(143, 24);
            this.txtNVID.TabIndex = 25;
            this.txtNVID.Visible = false;
            // 
            // txtKHID
            // 
            this.txtKHID.Location = new System.Drawing.Point(137, 2);
            this.txtKHID.Name = "txtKHID";
            this.txtKHID.Size = new System.Drawing.Size(143, 24);
            this.txtKHID.TabIndex = 24;
            this.txtKHID.Visible = false;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(582, 29);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(27, 21);
            this.btnNhanvien.TabIndex = 23;
            this.btnNhanvien.Text = "...";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Visible = false;
            // 
            // btnKH
            // 
            this.btnKH.Location = new System.Drawing.Point(286, 29);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(27, 21);
            this.btnKH.TabIndex = 22;
            this.btnKH.Text = "...";
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Visible = false;
            // 
            // dtPNgayxuat
            // 
            this.dtPNgayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPNgayxuat.Location = new System.Drawing.Point(136, 84);
            this.dtPNgayxuat.Name = "dtPNgayxuat";
            this.dtPNgayxuat.Size = new System.Drawing.Size(143, 24);
            this.dtPNgayxuat.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPXID);
            this.groupBox1.Controls.Add(this.txtNVID);
            this.groupBox1.Controls.Add(this.txtKHID);
            this.groupBox1.Controls.Add(this.btnNhanvien);
            this.groupBox1.Controls.Add(this.btnKH);
            this.groupBox1.Controls.Add(this.btnChitietPX);
            this.groupBox1.Controls.Add(this.dtPNgayxuat);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txt_Tongtien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Nhanvien);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_KH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 137);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu xuất";
            // 
            // btnChitietPX
            // 
            this.btnChitietPX.BackColor = System.Drawing.Color.LightGray;
            this.btnChitietPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitietPX.Location = new System.Drawing.Point(654, 80);
            this.btnChitietPX.Name = "btnChitietPX";
            this.btnChitietPX.Size = new System.Drawing.Size(174, 25);
            this.btnChitietPX.TabIndex = 21;
            this.btnChitietPX.Text = "Chi tiết phiếu xuất";
            this.btnChitietPX.UseVisualStyleBackColor = false;
            this.btnChitietPX.Click += new System.EventHandler(this.btnChitietPX_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(334, 86);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 18);
            this.label.TabIndex = 9;
            this.label.Text = "Tổng tiền:";
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.Location = new System.Drawing.Point(433, 83);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.ReadOnly = true;
            this.txt_Tongtien.Size = new System.Drawing.Size(143, 24);
            this.txt_Tongtien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 7;
            // 
            // txt_Nhanvien
            // 
            this.txt_Nhanvien.Location = new System.Drawing.Point(433, 29);
            this.txt_Nhanvien.Name = "txt_Nhanvien";
            this.txt_Nhanvien.Size = new System.Drawing.Size(143, 24);
            this.txt_Nhanvien.TabIndex = 6;
            // 
            // diachi
            // 
            this.diachi.AutoSize = true;
            this.diachi.Location = new System.Drawing.Point(334, 31);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(77, 18);
            this.diachi.TabIndex = 5;
            this.diachi.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            // 
            // txt_KH
            // 
            this.txt_KH.Location = new System.Drawing.Point(137, 29);
            this.txt_KH.Name = "txt_KH";
            this.txt_KH.Size = new System.Drawing.Size(143, 24);
            this.txt_KH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng:";
            // 
            // txtTKTenKH
            // 
            this.txtTKTenKH.Location = new System.Drawing.Point(150, 25);
            this.txtTKTenKH.Name = "txtTKTenKH";
            this.txtTKTenKH.Size = new System.Drawing.Size(143, 24);
            this.txtTKTenKH.TabIndex = 5;
            this.txtTKTenKH.TextChanged += new System.EventHandler(this.txtTKTenKH_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 321);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu xuất";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(687, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTKNhanvien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTKTenKH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 63);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nhân viên:";
            // 
            // txtTKNhanvien
            // 
            this.txtTKNhanvien.Location = new System.Drawing.Point(448, 25);
            this.txtTKNhanvien.Name = "txtTKNhanvien";
            this.txtTKNhanvien.Size = new System.Drawing.Size(143, 24);
            this.txtTKNhanvien.TabIndex = 7;
            this.txtTKNhanvien.TextChanged += new System.EventHandler(this.txtTKNhanvien_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Khách hàng:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(729, 248);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 36);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Làm mới";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Aquamarine;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(729, 463);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 36);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Aquamarine;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(729, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 36);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(729, 328);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 36);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(628, 25);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(92, 23);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // Phieuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Phieuxuat";
            this.Size = new System.Drawing.Size(869, 541);
            this.Load += new System.EventHandler(this.Phieuxuat_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPXID;
        private System.Windows.Forms.TextBox txtNVID;
        private System.Windows.Forms.TextBox txtKHID;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.DateTimePicker dtPNgayxuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChitietPX;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_Tongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nhanvien;
        private System.Windows.Forms.Label diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTKTenKH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTKNhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_timkiem;
    }
}
