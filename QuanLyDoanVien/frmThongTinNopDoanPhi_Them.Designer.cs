namespace QuanLyDoanVien
{
    partial class frmThongTinNopDoanPhi_Them
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
            this.gbxCongCuLoc = new System.Windows.Forms.GroupBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbxLoc = new System.Windows.Forms.Button();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.lblNganh = new System.Windows.Forms.Label();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cbxNganh = new System.Windows.Forms.ComboBox();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.DaThuTien = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cbxCanBo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayNop = new System.Windows.Forms.DateTimePicker();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.chkXacNhan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCongCuLoc.SuspendLayout();
            this.gbxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).BeginInit();
            this.gbxThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCongCuLoc
            // 
            this.gbxCongCuLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCongCuLoc.Controls.Add(this.lblKhoa);
            this.gbxCongCuLoc.Controls.Add(this.cbxLoc);
            this.gbxCongCuLoc.Controls.Add(this.cbxLop);
            this.gbxCongCuLoc.Controls.Add(this.lblNganh);
            this.gbxCongCuLoc.Controls.Add(this.cbxKhoa);
            this.gbxCongCuLoc.Controls.Add(this.lblLop);
            this.gbxCongCuLoc.Controls.Add(this.cbxNganh);
            this.gbxCongCuLoc.Location = new System.Drawing.Point(459, 81);
            this.gbxCongCuLoc.Name = "gbxCongCuLoc";
            this.gbxCongCuLoc.Size = new System.Drawing.Size(252, 140);
            this.gbxCongCuLoc.TabIndex = 9;
            this.gbxCongCuLoc.TabStop = false;
            this.gbxCongCuLoc.Text = "CÔNG CỤ LỌC";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(15, 27);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Khoa";
            // 
            // cbxLoc
            // 
            this.cbxLoc.Location = new System.Drawing.Point(171, 105);
            this.cbxLoc.Name = "cbxLoc";
            this.cbxLoc.Size = new System.Drawing.Size(64, 23);
            this.cbxLoc.TabIndex = 7;
            this.cbxLoc.Text = "LỌC";
            this.cbxLoc.UseVisualStyleBackColor = true;
            this.cbxLoc.Click += new System.EventHandler(this.cbxLoc_Click);
            // 
            // cbxLop
            // 
            this.cbxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(58, 78);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(177, 21);
            this.cbxLop.TabIndex = 3;
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLop_SelectedIndexChanged);
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Location = new System.Drawing.Point(15, 54);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(39, 13);
            this.lblNganh.TabIndex = 5;
            this.lblNganh.Text = "Ngành";
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(58, 24);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(177, 21);
            this.cbxKhoa.TabIndex = 1;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(15, 81);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(25, 13);
            this.lblLop.TabIndex = 6;
            this.lblLop.Text = "Lớp";
            // 
            // cbxNganh
            // 
            this.cbxNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNganh.FormattingEnabled = true;
            this.cbxNganh.Location = new System.Drawing.Point(58, 51);
            this.cbxNganh.Name = "cbxNganh";
            this.cbxNganh.Size = new System.Drawing.Size(177, 21);
            this.cbxNganh.TabIndex = 2;
            this.cbxNganh.SelectedIndexChanged += new System.EventHandler(this.cbxNganh_SelectedIndexChanged);
            // 
            // gbxDanhSach
            // 
            this.gbxDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDanhSach.Controls.Add(this.lblTimKiem);
            this.gbxDanhSach.Controls.Add(this.dgvDanhSachSinhVien);
            this.gbxDanhSach.Controls.Add(this.txtTimKiem);
            this.gbxDanhSach.Controls.Add(this.btnTimKiem);
            this.gbxDanhSach.Location = new System.Drawing.Point(12, 81);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Size = new System.Drawing.Size(441, 465);
            this.gbxDanhSach.TabIndex = 10;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "DANH SÁCH SINH VIÊN";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(9, 441);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(72, 13);
            this.lblTimKiem.TabIndex = 11;
            this.lblTimKiem.Text = "Nhập từ khóa";
            // 
            // dgvDanhSachSinhVien
            // 
            this.dgvDanhSachSinhVien.AllowUserToAddRows = false;
            this.dgvDanhSachSinhVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DaThuTien});
            this.dgvDanhSachSinhVien.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhSachSinhVien.Name = "dgvDanhSachSinhVien";
            this.dgvDanhSachSinhVien.Size = new System.Drawing.Size(429, 411);
            this.dgvDanhSachSinhVien.TabIndex = 0;
            // 
            // DaThuTien
            // 
            this.DaThuTien.HeaderText = "Đã thu tiền";
            this.DaThuTien.Name = "DaThuTien";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(87, 436);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(267, 21);
            this.txtTimKiem.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(360, 436);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxThongTin.Controls.Add(this.label7);
            this.gbxThongTin.Controls.Add(this.txtNoiDung);
            this.gbxThongTin.Controls.Add(this.cbxCanBo);
            this.gbxThongTin.Controls.Add(this.label5);
            this.gbxThongTin.Controls.Add(this.label3);
            this.gbxThongTin.Controls.Add(this.label2);
            this.gbxThongTin.Controls.Add(this.dateNgayNop);
            this.gbxThongTin.Controls.Add(this.txtSoTien);
            this.gbxThongTin.Location = new System.Drawing.Point(462, 227);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(249, 183);
            this.gbxThongTin.TabIndex = 11;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "THÔNG TIN THU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(90, 113);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(142, 47);
            this.txtNoiDung.TabIndex = 13;
            // 
            // cbxCanBo
            // 
            this.cbxCanBo.FormattingEnabled = true;
            this.cbxCanBo.Location = new System.Drawing.Point(90, 86);
            this.cbxCanBo.Name = "cbxCanBo";
            this.cbxCanBo.Size = new System.Drawing.Size(142, 21);
            this.cbxCanBo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cán bộ thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày nộp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số tiền/người";
            // 
            // dateNgayNop
            // 
            this.dateNgayNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNop.Location = new System.Drawing.Point(90, 60);
            this.dateNgayNop.Name = "dateNgayNop";
            this.dateNgayNop.Size = new System.Drawing.Size(142, 20);
            this.dateNgayNop.TabIndex = 2;
            this.dateNgayNop.Value = new System.DateTime(2017, 2, 28, 23, 11, 51, 0);
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(90, 34);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(142, 20);
            this.txtSoTien.TabIndex = 1;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyBo.Location = new System.Drawing.Point(646, 508);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(65, 32);
            this.btnHuyBo.TabIndex = 15;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Location = new System.Drawing.Point(517, 509);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(123, 30);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // chkXacNhan
            // 
            this.chkXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkXacNhan.AutoSize = true;
            this.chkXacNhan.Location = new System.Drawing.Point(517, 472);
            this.chkXacNhan.Name = "chkXacNhan";
            this.chkXacNhan.Size = new System.Drawing.Size(193, 30);
            this.chkXacNhan.TabIndex = 16;
            this.chkXacNhan.Text = "Tôi đã kiểm tra lại toàn bộ thông tin\r\n  và đồng ý thêm danh sách này.";
            this.chkXacNhan.UseVisualStyleBackColor = true;
            this.chkXacNhan.CheckedChanged += new System.EventHandler(this.chkXacNhan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 96;
            this.label1.Text = "THÊM SINH VIÊN NỘP ĐOÀN PHÍ";
            // 
            // frmThongTinNopDoanPhi_Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(723, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkXacNhan);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.gbxThongTin);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.gbxDanhSach);
            this.Controls.Add(this.gbxCongCuLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinNopDoanPhi_Them";
            this.Text = "frmThongTinNopDoanPhi_Them";
            this.gbxCongCuLoc.ResumeLayout(false);
            this.gbxCongCuLoc.PerformLayout();
            this.gbxDanhSach.ResumeLayout(false);
            this.gbxDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).EndInit();
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCongCuLoc;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Button cbxLoc;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cbxNganh;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSachSinhVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cbxCanBo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgayNop;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.CheckBox chkXacNhan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaThuTien;
        private System.Windows.Forms.Label label1;
    }
}