namespace QuanLyDoanVien
{
    partial class FormBaoCaoChuyenTruong
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtf = new System.Windows.Forms.DateTimePicker();
            this.dtt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.QLDV = new QuanLyDoanVien.QLDV();
            this.V_SVChuyenTruongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.V_SVChuyenTruongTableAdapter = new QuanLyDoanVien.QLDVTableAdapters.V_SVChuyenTruongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_SVChuyenTruongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ChuyenTruong";
            reportDataSource1.Value = this.V_SVChuyenTruongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDoanVien.SinhVienChuyenTruong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1114, 409);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(311, 11);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(86, 21);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Chọn";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // dtf
            // 
            this.dtf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtf.Location = new System.Drawing.Point(64, 12);
            this.dtf.Name = "dtf";
            this.dtf.Size = new System.Drawing.Size(85, 20);
            this.dtf.TabIndex = 4;
            this.dtf.Value = new System.DateTime(1999, 9, 9, 0, 0, 0, 0);
            // 
            // dtt
            // 
            this.dtt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtt.Location = new System.Drawing.Point(220, 9);
            this.dtt.Name = "dtt";
            this.dtt.Size = new System.Drawing.Size(85, 20);
            this.dtt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến ngày";
            // 
            // QLDV
            // 
            this.QLDV.DataSetName = "QLDV";
            this.QLDV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // V_SVChuyenTruongBindingSource
            // 
            this.V_SVChuyenTruongBindingSource.DataMember = "V_SVChuyenTruong";
            this.V_SVChuyenTruongBindingSource.DataSource = this.QLDV;
            // 
            // V_SVChuyenTruongTableAdapter
            // 
            this.V_SVChuyenTruongTableAdapter.ClearBeforeFill = true;
            // 
            // FormBaoCaoChuyenTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 471);
            this.Controls.Add(this.dtt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBaoCaoChuyenTruong";
            this.Text = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_SVChuyenTruongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtf;
        private System.Windows.Forms.DateTimePicker dtt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource V_SVChuyenTruongBindingSource;
        private QLDV QLDV;
        private QLDVTableAdapters.V_SVChuyenTruongTableAdapter V_SVChuyenTruongTableAdapter;
    }
}