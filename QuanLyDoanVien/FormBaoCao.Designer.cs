namespace QuanLyDoanVien
{
    partial class FormBaoCao
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
            this.cbBaoCao = new System.Windows.Forms.ComboBox();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.V_SVChuyenTruongTableAdapter = new QuanLyDoanVien.QLDVChuyenTruongTableAdapters.V_SVChuyenTruongTableAdapter();
            this.QLDVChuyenTruong = new QuanLyDoanVien.QLDVChuyenTruong();
            this.V_SVChuyenTruongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QLDVChuyenTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_SVChuyenTruongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "TableSVChuyenTruong";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDoanVien.SinhVienChuyenTruong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1114, 409);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbBaoCao
            // 
            this.cbBaoCao.FormattingEnabled = true;
            this.cbBaoCao.Items.AddRange(new object[] {
            "Báo cáo sinh viên chuyển trường",
            "Báo cáo sinh viên chuyển lớp",
            "Báo cáo sinh viên nợ đoàn phí",
            "Báo cáo Tổng đoàn phí"});
            this.cbBaoCao.Location = new System.Drawing.Point(12, 12);
            this.cbBaoCao.Name = "cbBaoCao";
            this.cbBaoCao.Size = new System.Drawing.Size(252, 21);
            this.cbBaoCao.TabIndex = 1;
            this.cbBaoCao.Text = "Chọn Loại Báo Cáo";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(270, 12);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(86, 21);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Chọn báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // V_SVChuyenTruongTableAdapter
            // 
            this.V_SVChuyenTruongTableAdapter.ClearBeforeFill = true;
            // 
            // QLDVChuyenTruong
            // 
            this.QLDVChuyenTruong.DataSetName = "QLDVChuyenTruong";
            this.QLDVChuyenTruong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // V_SVChuyenTruongBindingSource
            // 
            this.V_SVChuyenTruongBindingSource.DataMember = "V_SVChuyenTruong";
            this.V_SVChuyenTruongBindingSource.DataSource = this.QLDVChuyenTruong;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 471);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.cbBaoCao);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDVChuyenTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_SVChuyenTruongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbBaoCao;
        private System.Windows.Forms.Button btnBaoCao;
        private QLDVChuyenTruongTableAdapters.V_SVChuyenTruongTableAdapter V_SVChuyenTruongTableAdapter;
        private QLDVChuyenTruong QLDVChuyenTruong;
        private System.Windows.Forms.BindingSource V_SVChuyenTruongBindingSource;
    }
}