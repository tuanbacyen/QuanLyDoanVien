﻿namespace QuanLyDoanVien
{
    partial class FormLoaiHeDaoTao
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
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtgHeDaoTao = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHeDaoTao = new System.Windows.Forms.TextBox();
            this.txtMaHeDaoTao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHeDaoTao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 31);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.dtgHeDaoTao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(4, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 297);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 56);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(450, 29);
            this.txtTimKiem.TabIndex = 94;
            // 
            // dtgHeDaoTao
            // 
            this.dtgHeDaoTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHeDaoTao.Location = new System.Drawing.Point(6, 111);
            this.dtgHeDaoTao.Name = "dtgHeDaoTao";
            this.dtgHeDaoTao.Size = new System.Drawing.Size(564, 180);
            this.dtgHeDaoTao.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "DANH SÁCH LOẠI HỆ ĐÀO TẠO";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(462, 19);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(108, 30);
            this.btnIn.TabIndex = 90;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(120, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 31);
            this.btnSua.TabIndex = 87;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(462, 55);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 31);
            this.btnTimKiem.TabIndex = 86;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(348, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 31);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "Xóa trắng";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(234, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 31);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(147, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "THÔNG TIN LOẠI HỆ ĐÀO TẠO";
            // 
            // txtTenHeDaoTao
            // 
            this.txtTenHeDaoTao.Location = new System.Drawing.Point(124, 130);
            this.txtTenHeDaoTao.Name = "txtTenHeDaoTao";
            this.txtTenHeDaoTao.Size = new System.Drawing.Size(245, 20);
            this.txtTenHeDaoTao.TabIndex = 101;
            // 
            // txtMaHeDaoTao
            // 
            this.txtMaHeDaoTao.Location = new System.Drawing.Point(124, 92);
            this.txtMaHeDaoTao.Name = "txtMaHeDaoTao";
            this.txtMaHeDaoTao.Size = new System.Drawing.Size(245, 20);
            this.txtMaHeDaoTao.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Tên hệ đào tạo : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Mã hệ đào tạo : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "CẬP NHẬT THÔNG TIN LOẠI HỆ ĐÀO TẠO";
            // 
            // FormLoaiHeDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHeDaoTao);
            this.Controls.Add(this.txtMaHeDaoTao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLoaiHeDaoTao";
            this.Text = "FormLoaiHeDaoTao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHeDaoTao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtgHeDaoTao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHeDaoTao;
        private System.Windows.Forms.TextBox txtMaHeDaoTao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}