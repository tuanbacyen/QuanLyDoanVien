namespace QuanLyDoanVien
{
    partial class FormChuyenSinhHoatDoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuyenSinhHoatDoan));
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgSinhVien = new System.Windows.Forms.DataGridView();
            this.V = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetDS = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDSSV = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtgSVDaChuyen = new System.Windows.Forms.DataGridView();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCanBo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdCL = new System.Windows.Forms.RadioButton();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.rdCT = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLopLC = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cbNganhLC = new System.Windows.Forms.ComboBox();
            this.lblNganh = new System.Windows.Forms.Label();
            this.cbKhoaLC = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSVDaChuyen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(406, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 32);
            this.label3.TabIndex = 209;
            this.label3.Text = "CHUYỂN SINH HOẠT ĐOÀN";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(627, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(77, 29);
            this.btnTimKiem.TabIndex = 86;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtgSinhVien
            // 
            this.dtgSinhVien.AllowUserToAddRows = false;
            this.dtgSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.V});
            this.dtgSinhVien.Location = new System.Drawing.Point(6, 137);
            this.dtgSinhVien.Name = "dtgSinhVien";
            this.dtgSinhVien.Size = new System.Drawing.Size(318, 247);
            this.dtgSinhVien.TabIndex = 89;
            // 
            // V
            // 
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.Width = 50;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(357, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(264, 29);
            this.txtTimKiem.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnGetDS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbDSSV);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.dtgSVDaChuyen);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbNganh);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.dtgSinhVien);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 390);
            this.groupBox1.TabIndex = 210;
            this.groupBox1.TabStop = false;
            // 
            // btnGetDS
            // 
            this.btnGetDS.Image = ((System.Drawing.Image)(resources.GetObject("btnGetDS.Image")));
            this.btnGetDS.Location = new System.Drawing.Point(249, 78);
            this.btnGetDS.Name = "btnGetDS";
            this.btnGetDS.Size = new System.Drawing.Size(74, 32);
            this.btnGetDS.TabIndex = 221;
            this.btnGetDS.Text = "Lấy DS";
            this.btnGetDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetDS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetDS.UseVisualStyleBackColor = true;
            this.btnGetDS.Click += new System.EventHandler(this.btnGetDS_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 13);
            this.label6.TabIndex = 220;
            this.label6.Text = "DANH SÁCH SINH VIÊN CHUYỂN";
            // 
            // cbDSSV
            // 
            this.cbDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDSSV.FormattingEnabled = true;
            this.cbDSSV.Location = new System.Drawing.Point(535, 73);
            this.cbDSSV.Name = "cbDSSV";
            this.cbDSSV.Size = new System.Drawing.Size(169, 21);
            this.cbDSSV.TabIndex = 219;
            // 
            // btnLoc
            // 
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.Location = new System.Drawing.Point(249, 31);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(74, 41);
            this.btnLoc.TabIndex = 218;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dtgSVDaChuyen
            // 
            this.dtgSVDaChuyen.AllowUserToAddRows = false;
            this.dtgSVDaChuyen.AllowUserToDeleteRows = false;
            this.dtgSVDaChuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSVDaChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSVDaChuyen.Location = new System.Drawing.Point(330, 137);
            this.dtgSVDaChuyen.Name = "dtgSVDaChuyen";
            this.dtgSVDaChuyen.ReadOnly = true;
            this.dtgSVDaChuyen.Size = new System.Drawing.Size(405, 247);
            this.dtgSVDaChuyen.TabIndex = 217;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(68, 89);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(175, 21);
            this.cbLop.TabIndex = 165;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 164;
            this.label17.Text = "Lớp";
            // 
            // cbNganh
            // 
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(68, 60);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(175, 21);
            this.cbNganh.TabIndex = 163;
            this.cbNganh.SelectedIndexChanged += new System.EventHandler(this.cbNganh_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 162;
            this.label16.Text = "Ngành";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(68, 31);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(175, 21);
            this.cbKhoa.TabIndex = 161;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 160;
            this.label15.Text = "Khoa";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Enabled = false;
            this.txtMaSinhVien.Location = new System.Drawing.Point(110, 26);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(158, 20);
            this.txtMaSinhVien.TabIndex = 218;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 217;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbCanBo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtNgayChuyen);
            this.groupBox2.Controls.Add(this.txtMaSinhVien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(760, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 112);
            this.groupBox2.TabIndex = 219;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chuyển sinh viên";
            // 
            // cbCanBo
            // 
            this.cbCanBo.FormattingEnabled = true;
            this.cbCanBo.Location = new System.Drawing.Point(110, 78);
            this.cbCanBo.Name = "cbCanBo";
            this.cbCanBo.Size = new System.Drawing.Size(158, 21);
            this.cbCanBo.TabIndex = 223;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 222;
            this.label4.Text = "Cán Bộ Ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 220;
            this.label1.Text = "Ngày chuyển";
            // 
            // dtNgayChuyen
            // 
            this.dtNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayChuyen.Location = new System.Drawing.Point(110, 52);
            this.dtNgayChuyen.Name = "dtNgayChuyen";
            this.dtNgayChuyen.Size = new System.Drawing.Size(158, 20);
            this.dtNgayChuyen.TabIndex = 219;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rdCL);
            this.groupBox3.Controls.Add(this.btnXoaTrang);
            this.groupBox3.Controls.Add(this.rdCT);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbLopLC);
            this.groupBox3.Controls.Add(this.lblLop);
            this.groupBox3.Controls.Add(this.cbNganhLC);
            this.groupBox3.Controls.Add(this.lblNganh);
            this.groupBox3.Controls.Add(this.cbKhoaLC);
            this.groupBox3.Controls.Add(this.lblKhoa);
            this.groupBox3.Location = new System.Drawing.Point(760, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 238);
            this.groupBox3.TabIndex = 221;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ĐỊA CHỈ";
            // 
            // rdCL
            // 
            this.rdCL.AutoSize = true;
            this.rdCL.Checked = true;
            this.rdCL.Location = new System.Drawing.Point(188, 19);
            this.rdCL.Name = "rdCL";
            this.rdCL.Size = new System.Drawing.Size(82, 17);
            this.rdCL.TabIndex = 222;
            this.rdCL.TabStop = true;
            this.rdCL.Text = "Chuyển Lớp";
            this.rdCL.UseVisualStyleBackColor = true;
            this.rdCL.CheckedChanged += new System.EventHandler(this.rdCL_CheckedChanged);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTrang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTrang.Image")));
            this.btnXoaTrang.Location = new System.Drawing.Point(205, 194);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(60, 28);
            this.btnXoaTrang.TabIndex = 224;
            this.btnXoaTrang.Text = "Clear";
            this.btnXoaTrang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTrang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // rdCT
            // 
            this.rdCT.AutoSize = true;
            this.rdCT.Location = new System.Drawing.Point(76, 19);
            this.rdCT.Name = "rdCT";
            this.rdCT.Size = new System.Drawing.Size(98, 17);
            this.rdCT.TabIndex = 222;
            this.rdCT.Text = "Chuyển Trường";
            this.rdCT.UseVisualStyleBackColor = true;
            this.rdCT.CheckedChanged += new System.EventHandler(this.rdCT_CheckedChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(76, 123);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(189, 65);
            this.txtDiaChi.TabIndex = 220;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 221;
            this.label5.Text = "Địa chỉ";
            // 
            // cbLopLC
            // 
            this.cbLopLC.FormattingEnabled = true;
            this.cbLopLC.Location = new System.Drawing.Point(76, 96);
            this.cbLopLC.Name = "cbLopLC";
            this.cbLopLC.Size = new System.Drawing.Size(189, 21);
            this.cbLopLC.TabIndex = 165;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(27, 99);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(25, 13);
            this.lblLop.TabIndex = 164;
            this.lblLop.Text = "Lớp";
            // 
            // cbNganhLC
            // 
            this.cbNganhLC.FormattingEnabled = true;
            this.cbNganhLC.Location = new System.Drawing.Point(76, 69);
            this.cbNganhLC.Name = "cbNganhLC";
            this.cbNganhLC.Size = new System.Drawing.Size(189, 21);
            this.cbNganhLC.TabIndex = 163;
            this.cbNganhLC.SelectedIndexChanged += new System.EventHandler(this.cbNganhLC_SelectedIndexChanged);
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Location = new System.Drawing.Point(27, 72);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(39, 13);
            this.lblNganh.TabIndex = 162;
            this.lblNganh.Text = "Ngành";
            // 
            // cbKhoaLC
            // 
            this.cbKhoaLC.FormattingEnabled = true;
            this.cbKhoaLC.Location = new System.Drawing.Point(76, 42);
            this.cbKhoaLC.Name = "cbKhoaLC";
            this.cbKhoaLC.Size = new System.Drawing.Size(189, 21);
            this.cbKhoaLC.TabIndex = 161;
            this.cbKhoaLC.SelectedIndexChanged += new System.EventHandler(this.cbKhoaLC_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(27, 45);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 160;
            this.lblKhoa.Text = "Khoa";
            // 
            // btnChuyen
            // 
            this.btnChuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyen.Image")));
            this.btnChuyen.Location = new System.Drawing.Point(760, 465);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(123, 28);
            this.btnChuyen.TabIndex = 221;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(889, 465);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 28);
            this.btnSua.TabIndex = 222;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(983, 465);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 28);
            this.btnXoa.TabIndex = 223;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.SystemColors.Control;
            this.lblid.Location = new System.Drawing.Point(1001, 32);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 225;
            // 
            // FormChuyenSinhHoatDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1075, 505);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChuyenSinhHoatDoan";
            this.Text = "Chuyển sinh hoạt đoàn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSVDaChuyen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgSinhVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayChuyen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbCanBo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLopLC;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cbNganhLC;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.ComboBox cbKhoaLC;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDSSV;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView dtgSVDaChuyen;
        private System.Windows.Forms.Button btnGetDS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn V;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.RadioButton rdCL;
        private System.Windows.Forms.RadioButton rdCT;
        private System.Windows.Forms.Label lblid;
    }
}