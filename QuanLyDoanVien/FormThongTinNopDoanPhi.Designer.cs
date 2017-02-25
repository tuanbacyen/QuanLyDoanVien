namespace QuanLyDoanVien
{
    partial class FormThongTinNopDoanPhi
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
            this.dtNgayNop = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtgNopDoanPhi = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCanBo = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNopDoanPhi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtNgayNop
            // 
            this.dtNgayNop.Enabled = false;
            this.dtNgayNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNop.Location = new System.Drawing.Point(282, 91);
            this.dtNgayNop.Name = "dtNgayNop";
            this.dtNgayNop.Size = new System.Drawing.Size(112, 20);
            this.dtNgayNop.TabIndex = 234;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 233;
            this.label6.Text = "Ngày nộp";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(464, 51);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(118, 20);
            this.txtDiaDiem.TabIndex = 232;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 231;
            this.label1.Text = "Số Tiền";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(184, 54);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(314, 29);
            this.txtTimKiem.TabIndex = 94;
            // 
            // dtgNopDoanPhi
            // 
            this.dtgNopDoanPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNopDoanPhi.Location = new System.Drawing.Point(0, 89);
            this.dtgNopDoanPhi.Name = "dtgNopDoanPhi";
            this.dtgNopDoanPhi.Size = new System.Drawing.Size(734, 263);
            this.dtgNopDoanPhi.TabIndex = 89;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(424, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 31);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "Xóa trắng";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(282, 55);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(112, 20);
            this.txtSoPhieu.TabIndex = 230;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(504, 19);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(74, 30);
            this.btnIn.TabIndex = 90;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(264, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 31);
            this.btnSua.TabIndex = 87;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(504, 56);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 31);
            this.btnTimKiem.TabIndex = 86;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(184, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 31);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(222, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 223;
            this.label3.Text = "THÔNG TIN NỘP ĐOÀN PHÍ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.dtgNopDoanPhi);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(4, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 356);
            this.groupBox1.TabIndex = 224;
            this.groupBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(344, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 31);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 229;
            this.label4.Text = "Số phiếu";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(81, 60);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(125, 20);
            this.txtMaSinhVien.TabIndex = 228;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 227;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 225;
            this.label5.Text = "Cán Bộ";
            // 
            // cbCanBo
            // 
            this.cbCanBo.FormattingEnabled = true;
            this.cbCanBo.Location = new System.Drawing.Point(82, 91);
            this.cbCanBo.Name = "cbCanBo";
            this.cbCanBo.Size = new System.Drawing.Size(125, 21);
            this.cbCanBo.TabIndex = 226;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(464, 87);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(234, 20);
            this.txtNoiDung.TabIndex = 236;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 235;
            this.label7.Text = "Nội Dung";
            // 
            // cbNo
            // 
            this.cbNo.AutoSize = true;
            this.cbNo.Location = new System.Drawing.Point(611, 54);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(87, 17);
            this.cbNo.TabIndex = 237;
            this.cbNo.Text = "Nợ đoàn phí";
            this.cbNo.UseVisualStyleBackColor = true;
            // 
            // FormThongTinNopDoanPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 499);
            this.Controls.Add(this.cbNo);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNgayNop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoPhieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCanBo);
            this.Name = "FormThongTinNopDoanPhi";
            this.Text = "FormThongTinNopDoanPhi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNopDoanPhi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNgayNop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtgNopDoanPhi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCanBo;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbNo;
    }
}