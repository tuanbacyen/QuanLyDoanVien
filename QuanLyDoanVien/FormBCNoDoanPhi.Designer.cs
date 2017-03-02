namespace QuanLyDoanVien
{
    partial class FormBCNoDoanPhi
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
            this.v_SVNoDoanPhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLDV = new QuanLyDoanVien.QLDV();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.v_SVNoDoanPhiTableAdapter = new QuanLyDoanVien.QLDVTableAdapters.v_SVNoDoanPhiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtToYear = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.v_SVNoDoanPhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDV)).BeginInit();
            this.SuspendLayout();
            // 
            // v_SVNoDoanPhiBindingSource
            // 
            this.v_SVNoDoanPhiBindingSource.DataMember = "v_SVNoDoanPhi";
            this.v_SVNoDoanPhiBindingSource.DataSource = this.QLDV;
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
            reportDataSource1.Name = "NoDoanPhi";
            reportDataSource1.Value = this.v_SVNoDoanPhiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDoanVien.SinhVienNoDoanPhi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(902, 457);
            this.reportViewer1.TabIndex = 0;
            // 
            // v_SVNoDoanPhiTableAdapter
            // 
            this.v_SVNoDoanPhiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Từ ngày";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtToYear
            // 
            this.dtToYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToYear.Location = new System.Drawing.Point(277, 12);
            this.dtToYear.Name = "dtToYear";
            this.dtToYear.Size = new System.Drawing.Size(109, 20);
            this.dtToYear.TabIndex = 10;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(75, 12);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(109, 20);
            this.dtFrom.TabIndex = 11;
            // 
            // FormBCNoDoanPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtToYear);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBCNoDoanPhi";
            this.Text = "FormBCNoDoanPhi";
            this.Load += new System.EventHandler(this.FormBCNoDoanPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_SVNoDoanPhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource v_SVNoDoanPhiBindingSource;
        private QLDV QLDV;
        private QLDVTableAdapters.v_SVNoDoanPhiTableAdapter v_SVNoDoanPhiTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtToYear;
        private System.Windows.Forms.DateTimePicker dtFrom;
    }
}