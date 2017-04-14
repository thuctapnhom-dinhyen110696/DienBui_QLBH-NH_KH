namespace QuanLyBanHang
{
    partial class frmKhachHang
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxThongtinKH = new System.Windows.Forms.GroupBox();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiemtl = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblDiemtl = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lbltenkh = new System.Windows.Forms.Label();
            this.lblMakh = new System.Windows.Forms.Label();
            this.gbxTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.gbxThongtinKH.SuspendLayout();
            this.gbxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(25, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(135, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(245, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(465, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(480, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxThongtinKH
            // 
            this.gbxThongtinKH.Controls.Add(this.dateNgaysinh);
            this.gbxThongtinKH.Controls.Add(this.txtDiemtl);
            this.gbxThongtinKH.Controls.Add(this.txtSdt);
            this.gbxThongtinKH.Controls.Add(this.txtDiachi);
            this.gbxThongtinKH.Controls.Add(this.txtTenkh);
            this.gbxThongtinKH.Controls.Add(this.txtMakh);
            this.gbxThongtinKH.Controls.Add(this.lblSdt);
            this.gbxThongtinKH.Controls.Add(this.lblDiemtl);
            this.gbxThongtinKH.Controls.Add(this.lblNgaysinh);
            this.gbxThongtinKH.Controls.Add(this.lblDiachi);
            this.gbxThongtinKH.Controls.Add(this.lbltenkh);
            this.gbxThongtinKH.Controls.Add(this.lblMakh);
            this.gbxThongtinKH.Location = new System.Drawing.Point(12, 41);
            this.gbxThongtinKH.Name = "gbxThongtinKH";
            this.gbxThongtinKH.Size = new System.Drawing.Size(598, 130);
            this.gbxThongtinKH.TabIndex = 6;
            this.gbxThongtinKH.TabStop = false;
            this.gbxThongtinKH.Text = "Thông tin khách hàng";
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Location = new System.Drawing.Point(406, 32);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(178, 20);
            this.dateNgaysinh.TabIndex = 11;
            // 
            // txtDiemtl
            // 
            this.txtDiemtl.Location = new System.Drawing.Point(406, 93);
            this.txtDiemtl.Name = "txtDiemtl";
            this.txtDiemtl.Size = new System.Drawing.Size(178, 20);
            this.txtDiemtl.TabIndex = 10;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(406, 62);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(178, 20);
            this.txtSdt.TabIndex = 9;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(122, 96);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(169, 20);
            this.txtDiachi.TabIndex = 8;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(122, 65);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(169, 20);
            this.txtTenkh.TabIndex = 7;
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(123, 32);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(168, 20);
            this.txtMakh.TabIndex = 6;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(322, 65);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(70, 13);
            this.lblSdt.TabIndex = 5;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // lblDiemtl
            // 
            this.lblDiemtl.AutoSize = true;
            this.lblDiemtl.Location = new System.Drawing.Point(322, 96);
            this.lblDiemtl.Name = "lblDiemtl";
            this.lblDiemtl.Size = new System.Drawing.Size(69, 13);
            this.lblDiemtl.TabIndex = 4;
            this.lblDiemtl.Text = "Điểm tích lũy";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(322, 32);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaysinh.TabIndex = 3;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(30, 96);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 2;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lbltenkh
            // 
            this.lbltenkh.AutoSize = true;
            this.lbltenkh.Location = new System.Drawing.Point(30, 65);
            this.lbltenkh.Name = "lbltenkh";
            this.lbltenkh.Size = new System.Drawing.Size(86, 13);
            this.lbltenkh.TabIndex = 1;
            this.lbltenkh.Text = "Tên khách hàng";
            // 
            // lblMakh
            // 
            this.lblMakh.AutoSize = true;
            this.lblMakh.Location = new System.Drawing.Point(30, 32);
            this.lblMakh.Name = "lblMakh";
            this.lblMakh.Size = new System.Drawing.Size(82, 13);
            this.lblMakh.TabIndex = 0;
            this.lblMakh.Text = "Mã khách hàng";
            // 
            // gbxTimKiem
            // 
            this.gbxTimKiem.Controls.Add(this.txtTimkiem);
            this.gbxTimKiem.Controls.Add(this.lblTimkiem);
            this.gbxTimKiem.Controls.Add(this.btnTimKiem);
            this.gbxTimKiem.Location = new System.Drawing.Point(12, 177);
            this.gbxTimKiem.Name = "gbxTimKiem";
            this.gbxTimKiem.Size = new System.Drawing.Size(600, 70);
            this.gbxTimKiem.TabIndex = 7;
            this.gbxTimKiem.TabStop = false;
            this.gbxTimKiem.Text = "Tìm kiếm thông tin";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(168, 29);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(224, 20);
            this.txtTimkiem.TabIndex = 11;
            this.txtTimkiem.Text = "Nhập thông tin cần tìm kiếm";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(30, 32);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(109, 13);
            this.lblTimkiem.TabIndex = 6;
            this.lblTimkiem.Text = "Tìm kiếm khách hàng";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Location = new System.Drawing.Point(242, 250);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(112, 13);
            this.lblThongtin.TabIndex = 8;
            this.lblThongtin.Text = "Thông tin khách hàng";
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Location = new System.Drawing.Point(14, 280);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.Size = new System.Drawing.Size(598, 105);
            this.dgvKhachhang.TabIndex = 9;
            this.dgvKhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellClick);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 388);
            this.Controls.Add(this.dgvKhachhang);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.gbxTimKiem);
            this.Controls.Add(this.gbxThongtinKH);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.Name = "frmKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load_1);
            this.gbxThongtinKH.ResumeLayout(false);
            this.gbxThongtinKH.PerformLayout();
            this.gbxTimKiem.ResumeLayout(false);
            this.gbxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxThongtinKH;
        private System.Windows.Forms.GroupBox gbxTimKiem;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblDiemtl;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lbltenkh;
        private System.Windows.Forms.Label lblMakh;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.TextBox txtDiemtl;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.DataGridView dgvKhachhang;
    }
}

