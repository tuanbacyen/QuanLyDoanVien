namespace QuanLyDoanVien
{
    partial class FormCanBoVanPhongDoan
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtgCanBo = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCanBo = new System.Windows.Forms.TextBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCanBo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(88, 89);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(319, 40);
            this.txtDiaChi.TabIndex = 186;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 183;
            this.label7.Text = "Địa chỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 181;
            this.label13.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 168;
            this.label5.Text = "Chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.dtgCanBo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(11, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 396);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(122, 50);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(314, 29);
            this.txtTimKiem.TabIndex = 94;
            // 
            // dtgCanBo
            // 
            this.dtgCanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCanBo.Location = new System.Drawing.Point(6, 111);
            this.dtgCanBo.Name = "dtgCanBo";
            this.dtgCanBo.Size = new System.Drawing.Size(654, 280);
            this.dtgCanBo.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "DANH SÁCH CÁN BỘ";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(442, 15);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(74, 30);
            this.btnIn.TabIndex = 90;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(202, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 31);
            this.btnSua.TabIndex = 87;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(442, 52);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 31);
            this.btnTimKiem.TabIndex = 86;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(362, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 31);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "Xóa trắng";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(282, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 31);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(122, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 31);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(88, 63);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(129, 20);
            this.txtHoVaTen.TabIndex = 165;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(252, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 166;
            this.label3.Text = "THÔNG TIN CÁN BỘ";
            // 
            // txtMaCanBo
            // 
            this.txtMaCanBo.Location = new System.Drawing.Point(88, 37);
            this.txtMaCanBo.Name = "txtMaCanBo";
            this.txtMaCanBo.Size = new System.Drawing.Size(129, 20);
            this.txtMaCanBo.TabIndex = 164;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(293, 58);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(114, 21);
            this.cbChucVu.TabIndex = 169;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 163;
            this.label4.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 162;
            this.label2.Text = "Mã Cán Bộ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(510, 35);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(143, 20);
            this.txtSDT.TabIndex = 189;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(234, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 191;
            this.label18.Text = "Giới Tính";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbGioiTinh.Location = new System.Drawing.Point(293, 32);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(114, 21);
            this.cbGioiTinh.TabIndex = 192;
            // 
            // FormCanBoVanPhongDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 537);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaCanBo);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FormCanBoVanPhongDoan";
            this.Text = "FormCanBoVanPhongDoan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCanBo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtgCanBo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaCanBo;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbGioiTinh;
    }
}