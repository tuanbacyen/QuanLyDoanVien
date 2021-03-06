﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanVien
{
    public partial class FormNganhHoc : Form
    {
        public FormNganhHoc()
        {
            InitializeComponent();
            load_data();
            //hieu comment
            //hieu cm2
        }

        private void load_data()
        {
            HienThiKhoaLenCombobox();
            HienThiNganhHoc();
            Clear();
            bidding();
        }
        private QuanLyDoanVienDataContext db = new QuanLyDoanVienDataContext();
        private Table<Khoa> khoas;
        Table<NganhHoc> nganhHocs;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaNganh.Text != null && txtTenNganh.Text != null)
            {
                NganhHoc nganh = new NganhHoc();
                nganh.MaNganh = txtMaNganh.Text;
                nganh.TenNganh = txtTenNganh.Text;
                nganh.MaKhoa = cbKhoa.SelectedValue.ToString();
                nganhHocs = db.GetTable<NganhHoc>();
                nganhHocs.InsertOnSubmit(nganh);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công", "Thông Báo");
                load_data();

            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin","Thông Báo");
            }
        }

        private void HienThiNganhHoc()
        {

            nganhHocs = db.GetTable<NganhHoc>();
            khoas = db.GetTable<Khoa>();

            // viết linQ
            var GetNganhHoc = from nh in nganhHocs
                              join kh in khoas on nh.MaKhoa equals kh.MaKhoa
                              orderby nh.NganhHocID
                              select new { STT= nh.NganhHocID, nh.MaNganh, nh.TenNganh, kh.TenKhoa };

            //get data
            dtgNganhHoc.DataSource = GetNganhHoc;
        }

        private void HienThiNganhHoc(string maKhoa)
        {

            nganhHocs = db.GetTable<NganhHoc>();
            khoas = db.GetTable<Khoa>();

            // viết linQ
            var GetNganhHoc = from nh in nganhHocs
                              join kh in khoas on nh.MaKhoa equals kh.MaKhoa
                              where nh.MaKhoa == maKhoa
                              orderby nh.NganhHocID
                              select new { STT = nh.NganhHocID, nh.MaNganh, nh.TenNganh, kh.TenKhoa };

            //get data
            dtgNganhHoc.DataSource = GetNganhHoc;
        }

        private void HienThiKhoaLenCombobox()
        {
            khoas = db.GetTable<Khoa>();

            var GetKhoaToCB = from kh in khoas
                              select new
                              {
                                  kh.MaKhoa,
                                  kh.TenKhoa
                              };

            cbKhoa.DataSource = GetKhoaToCB;
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.DisplayMember = "TenKhoa";
        }

        private void Clear()
        {
            txtMaNganh.Clear();
            txtTenNganh.Clear();
            txtTimKiem.Clear();
            cbKhoa.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // không chô nhập vô cbbox
            e.Handled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text != null && txtTenNganh.Text != null)
            {
                string maNganh = txtMaNganh.Text;
                NganhHoc nghoc = nganhHocs.Single(ngh => ngh.MaNganh == maNganh);
                nghoc.TenNganh = txtTenNganh.Text;
                nghoc.MaKhoa = cbKhoa.SelectedValue.ToString();
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công", "Thông Báo");
                load_data();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text != null && txtTenNganh.Text != null)
            {
                string maNganh = txtMaNganh.Text;
                NganhHoc nghoc = nganhHocs.Single(ngh => ngh.MaNganh == maNganh);
                nganhHocs.DeleteOnSubmit(nghoc);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công", "Thông Báo");
                load_data();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }
        private void bidding()
        {
            txtMaNganh.DataBindings.Clear();
            txtMaNganh.DataBindings.Add("text", dtgNganhHoc.DataSource, "MaNganh");
            txtTenNganh.DataBindings.Clear();
            txtTenNganh.DataBindings.Add("text", dtgNganhHoc.DataSource, "TenNganh");
            cbKhoa.DataBindings.Clear();
            cbKhoa.DataBindings.Add("text", dtgNganhHoc.DataSource, "TenKhoa");
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiNganhHoc(cbKhoa.SelectedValue.ToString());
            bidding();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            ppd.Document = pd;
            pd.PrintPage += Pd_PrintPage;

            ppd.ShowDialog();

        }

        public Bitmap GetBmp(DataGridView dgv)
        {
            try
            {
                dgv.BackgroundColor = Color.White;
                dgv.BorderStyle = BorderStyle.None;

                int height = dgv.Height;
                dgv.Height = dgv.RowCount * dgv.RowTemplate.Height * 2;
                Bitmap bmp = new Bitmap(dgv.Width, dgv.Height);
                dgv.DrawToBitmap(bmp, new Rectangle(0, 0, dgv.Width, dgv.Height));
                dgv.Height = height;

                dgv.BorderStyle = BorderStyle.FixedSingle;
                return bmp;
            }
            catch { return null; }

        }

        private void Pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try { e.Graphics.DrawImage(GetBmp(dtgNganhHoc), 0, 0); }
            catch { }
        }
    }
}
