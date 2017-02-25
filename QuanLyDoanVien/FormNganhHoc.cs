using System;
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
        }

        private void load_data()
        {
            HienThiNganhHoc();
            HienThiKhoaLenCombobox();
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
    }
}
