namespace QuanLyDoanVien
{
    partial class FormBCChuyenLop
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
            this.v_SVChuyenLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLDV = new QuanLyDoanVien.QLDV();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.v_SVChuyenLopTableAdapter = new QuanLyDoanVien.QLDVTableAdapters.v_SVChuyenLopTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.dtToYear = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.v_SVChuyenLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDV)).BeginInit();
            this.SuspendLayout();
            // 
            // v_SVChuyenLopBindingSource
            // 
            this.v_SVChuyenLopBindingSource.DataMember = "v_SVChuyenLop";
            this.v_SVChuyenLopBindingSource.DataSource = this.QLDV;
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
            reportDataSource1.Name = "ChuyenLop";
            reportDataSource1.Value = this.v_SVChuyenLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDoanVien.SinhVienChuyenLop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(923, 431);
            this.reportViewer1.TabIndex = 0;
            // 
            // v_SVChuyenLopTableAdapter
            // 
            this.v_SVChuyenLopTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Từ ngày";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(388, 9);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(92, 24);
            this.btnClick.TabIndex = 11;
            this.btnClick.Text = "Lọc";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // dtToYear
            // 
            this.dtToYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToYear.Location = new System.Drawing.Point(273, 12);
            this.dtToYear.Name = "dtToYear";
            this.dtToYear.Size = new System.Drawing.Size(109, 20);
            this.dtToYear.TabIndex = 9;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(71, 12);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(109, 20);
            this.dtFrom.TabIndex = 10;
            // 
            // FormBCChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.dtToYear);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBCChuyenLop";
            this.Text = "FormBCChuyenLop";
            this.Load += new System.EventHandler(this.FormBCChuyenLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_SVChuyenLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource v_SVChuyenLopBindingSource;
        private QLDV QLDV;
        private QLDVTableAdapters.v_SVChuyenLopTableAdapter v_SVChuyenLopTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.DateTimePicker dtToYear;
        private System.Windows.Forms.DateTimePicker dtFrom;
    }
}