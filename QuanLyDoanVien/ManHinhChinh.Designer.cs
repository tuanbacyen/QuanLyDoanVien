namespace QuanLyDoanVien
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.reportHDD = new System.Windows.Forms.ToolStripMenuItem();
            this.reportDP = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBC = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateCSHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateHDD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateDP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateSD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateNganh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateCB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnManagePeople = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQLHT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportHDD
            // 
            this.reportHDD.Name = "reportHDD";
            this.reportHDD.Size = new System.Drawing.Size(248, 22);
            this.reportHDD.Text = "Báo Cáo Hoạt Động Đoàn";
            // 
            // reportDP
            // 
            this.reportDP.Name = "reportDP";
            this.reportDP.Size = new System.Drawing.Size(248, 22);
            this.reportDP.Text = "Báo Cáo Đoàn Phí";
            // 
            // reportBC
            // 
            this.reportBC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportDP,
            this.reportHDD,
            this.reportSHD});
            this.reportBC.Image = ((System.Drawing.Image)(resources.GetObject("reportBC.Image")));
            this.reportBC.Name = "reportBC";
            this.reportBC.Size = new System.Drawing.Size(82, 20);
            this.reportBC.Text = "Báo Cáo ";
            // 
            // reportSHD
            // 
            this.reportSHD.Name = "reportSHD";
            this.reportSHD.Size = new System.Drawing.Size(248, 22);
            this.reportSHD.Text = "Báo Cáo Chuyển Sinh Hoạt Đoàn";
            // 
            // mnUpdateCSHD
            // 
            this.mnUpdateCSHD.Name = "mnUpdateCSHD";
            this.mnUpdateCSHD.Size = new System.Drawing.Size(312, 22);
            this.mnUpdateCSHD.Text = "Cập Nhật Thông Tin Chuyển Sinh Hoạt Đoàn";
            // 
            // mnUpdateHDD
            // 
            this.mnUpdateHDD.Name = "mnUpdateHDD";
            this.mnUpdateHDD.Size = new System.Drawing.Size(312, 22);
            this.mnUpdateHDD.Text = "Cập Nhật Thông Tin Hoạt Động Đoàn";
            // 
            // mnUpdateDP
            // 
            this.mnUpdateDP.Name = "mnUpdateDP";
            this.mnUpdateDP.Size = new System.Drawing.Size(312, 22);
            this.mnUpdateDP.Text = "Cập Nhật Thông Tin Đóng Đoàn Phí";
            // 
            // mnUpdateSD
            // 
            this.mnUpdateSD.Name = "mnUpdateSD";
            this.mnUpdateSD.Size = new System.Drawing.Size(312, 22);
            this.mnUpdateSD.Text = "Cập Nhật Thông Tin Sổ Đoàn";
            // 
            // mnUpdateSV
            // 
            this.mnUpdateSV.Name = "mnUpdateSV";
            this.mnUpdateSV.Size = new System.Drawing.Size(312, 22);
            this.mnUpdateSV.Text = "Cập Nhật Thông Tin Sinh Viên";
            // 
            // mnUpdateLop
            // 
            this.mnUpdateLop.Name = "mnUpdateLop";
            this.mnUpdateLop.Size = new System.Drawing.Size(312, 22);
            this.mnUpdateLop.Text = "Cập Nhật Thông Tin Lớp";
            // 
            // mnUpdateNganh
            // 
            this.mnUpdateNganh.Name = "mnUpdateNganh";
            this.mnUpdateNganh.Size = new System.Drawing.Size(312, 22);
            this.mnUpdateNganh.Text = "Cập Nhật Thông Tin Ngành ";
            // 
            // mnUpdateCB
            // 
            this.mnUpdateCB.Name = "mnUpdateCB";
            this.mnUpdateCB.Size = new System.Drawing.Size(312, 22);
            this.mnUpdateCB.Text = "Cập Nhật Thông Tin Cán Bộ ";
            // 
            // mnData
            // 
            this.mnData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUpdateCB,
            this.mnUpdateNganh,
            this.mnUpdateLop,
            this.mnUpdateSV,
            this.mnUpdateSD,
            this.mnUpdateDP,
            this.mnUpdateHDD,
            this.mnUpdateCSHD});
            this.mnData.Image = ((System.Drawing.Image)(resources.GetObject("mnData.Image")));
            this.mnData.Name = "mnData";
            this.mnData.Size = new System.Drawing.Size(128, 20);
            this.mnData.Text = "Cập Nhật Dữ Liệu";
            // 
            // mnOut
            // 
            this.mnOut.Name = "mnOut";
            this.mnOut.Size = new System.Drawing.Size(187, 22);
            this.mnOut.Text = "Thoát";
            // 
            // mnManagePeople
            // 
            this.mnManagePeople.Name = "mnManagePeople";
            this.mnManagePeople.Size = new System.Drawing.Size(187, 22);
            this.mnManagePeople.Text = "Quản Trị Người Dùng";
            // 
            // mnLogin
            // 
            this.mnLogin.Name = "mnLogin";
            this.mnLogin.Size = new System.Drawing.Size(187, 22);
            this.mnLogin.Text = "Đăng Nhập";
            // 
            // mnConnect
            // 
            this.mnConnect.Name = "mnConnect";
            this.mnConnect.Size = new System.Drawing.Size(187, 22);
            this.mnConnect.Text = "Kết Nối";
            this.mnConnect.Click += new System.EventHandler(this.mnConnect_Click);
            // 
            // mnQLHT
            // 
            this.mnQLHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnConnect,
            this.mnLogin,
            this.mnManagePeople,
            this.mnOut});
            this.mnQLHT.Image = ((System.Drawing.Image)(resources.GetObject("mnQLHT.Image")));
            this.mnQLHT.Name = "mnQLHT";
            this.mnQLHT.Size = new System.Drawing.Size(136, 20);
            this.mnQLHT.Text = "Quản Trị Hệ Thống";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQLHT,
            this.mnData,
            this.reportBC});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Màn Hình Chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem reportHDD;
        private System.Windows.Forms.ToolStripMenuItem reportDP;
        private System.Windows.Forms.ToolStripMenuItem reportBC;
        private System.Windows.Forms.ToolStripMenuItem reportSHD;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateCSHD;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateHDD;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateDP;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateSD;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateSV;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateLop;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateNganh;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateCB;
        private System.Windows.Forms.ToolStripMenuItem mnData;
        private System.Windows.Forms.ToolStripMenuItem mnOut;
        private System.Windows.Forms.ToolStripMenuItem mnManagePeople;
        private System.Windows.Forms.ToolStripMenuItem mnLogin;
        private System.Windows.Forms.ToolStripMenuItem mnConnect;
        private System.Windows.Forms.ToolStripMenuItem mnQLHT;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}