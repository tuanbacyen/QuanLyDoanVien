namespace QuanLyDoanVien
{
    partial class FormImportFileSinhVien
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
            this.dataG = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTool = new System.Windows.Forms.Panel();
            this.danhSachSheet = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.btnXemLoi = new System.Windows.Forms.Button();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataG
            // 
            this.dataG.AllowUserToAddRows = false;
            this.dataG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataG.Location = new System.Drawing.Point(3, 121);
            this.dataG.Name = "dataG";
            this.dataG.Size = new System.Drawing.Size(673, 283);
            this.dataG.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelTool, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelStatus, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataG, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.98551F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.0145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 447);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.danhSachSheet);
            this.panelTool.Controls.Add(this.txtFileName);
            this.panelTool.Controls.Add(this.btnOpen);
            this.panelTool.Controls.Add(this.label1);
            this.panelTool.Controls.Add(this.btnLuu);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTool.Location = new System.Drawing.Point(3, 3);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(673, 112);
            this.panelTool.TabIndex = 0;
            // 
            // danhSachSheet
            // 
            this.danhSachSheet.FormattingEnabled = true;
            this.danhSachSheet.Location = new System.Drawing.Point(389, 46);
            this.danhSachSheet.Name = "danhSachSheet";
            this.danhSachSheet.Size = new System.Drawing.Size(111, 21);
            this.danhSachSheet.TabIndex = 33;
            this.danhSachSheet.SelectedIndexChanged += new System.EventHandler(this.danhSachSheet_SelectedIndexChanged_1);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(102, 46);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(281, 20);
            this.txtFileName.TabIndex = 32;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 32);
            this.btnOpen.TabIndex = 31;
            this.btnOpen.Text = "Mở File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Đường dẫn";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(506, 39);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 32);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.btnXemLoi);
            this.panelStatus.Controls.Add(this.txtSTT);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatus.Location = new System.Drawing.Point(3, 410);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(673, 34);
            this.panelStatus.TabIndex = 1;
            // 
            // btnXemLoi
            // 
            this.btnXemLoi.Location = new System.Drawing.Point(509, 0);
            this.btnXemLoi.Name = "btnXemLoi";
            this.btnXemLoi.Size = new System.Drawing.Size(90, 32);
            this.btnXemLoi.TabIndex = 0;
            this.btnXemLoi.Text = "Xem Lỗi";
            this.btnXemLoi.UseVisualStyleBackColor = true;
            this.btnXemLoi.Click += new System.EventHandler(this.btnXemLoi_Click);
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(9, 3);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.ReadOnly = true;
            this.txtSTT.Size = new System.Drawing.Size(281, 26);
            this.txtSTT.TabIndex = 1;
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            this.oFD.FileOk += new System.ComponentModel.CancelEventHandler(this.oFD_FileOk);
            // 
            // FormImportFileSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormImportFileSinhVien";
            this.Text = "FormImportFileSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataG;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Button btnXemLoi;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox danhSachSheet;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog oFD;
    }
}