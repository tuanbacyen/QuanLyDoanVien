namespace QuanLyDoanVien
{
    partial class FormBCTongThuChi
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
            this.v_TongThuChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLDV = new QuanLyDoanVien.QLDV();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtToYear = new System.Windows.Forms.DateTimePicker();
            this.btnClick = new System.Windows.Forms.Button();
            this.v_TongThuChiTableAdapter = new QuanLyDoanVien.QLDVTableAdapters.v_TongThuChiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.v_TongThuChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDV)).BeginInit();
            this.SuspendLayout();
            // 
            // v_TongThuChiBindingSource
            // 
            this.v_TongThuChiBindingSource.DataMember = "v_TongThuChi";
            this.v_TongThuChiBindingSource.DataSource = this.QLDV;
            // 
            // QLDV
            // 
            this.QLDV.DataSetName = "QLDV";
            this.QLDV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "TongThuChi";
            reportDataSource1.Value = this.v_TongThuChiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDoanVien.TongThuDoanPhi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(882, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(78, 11);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(109, 20);
            this.dtFrom.TabIndex = 1;
            // 
            // dtToYear
            // 
            this.dtToYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToYear.Location = new System.Drawing.Point(280, 11);
            this.dtToYear.Name = "dtToYear";
            this.dtToYear.Size = new System.Drawing.Size(109, 20);
            this.dtToYear.TabIndex = 1;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(395, 8);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(92, 24);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Lọc";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // v_TongThuChiTableAdapter
            // 
            this.v_TongThuChiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // FormBCTongThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.dtToYear);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBCTongThuChi";
            this.Text = "FormBCTongThuChi";
            this.Load += new System.EventHandler(this.FormBCTongThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_TongThuChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtToYear;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.BindingSource v_TongThuChiBindingSource;
        private QLDV QLDV;
        private QLDVTableAdapters.v_TongThuChiTableAdapter v_TongThuChiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}