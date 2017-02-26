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
    public partial class FormCanBoVanPhongDoan : Form
    {
        public FormCanBoVanPhongDoan()
        {
            InitializeComponent();
            HienThiCBCV();
            HienThiDuLieuCB();
        }
        QuanLyDoanVienDataContext db = new QuanLyDoanVienDataContext();
        Table<CanBoVPDoan> canbovpdoans;
        Table<ChucVu> chucvus;

        private void HienThiCBCV()
        {
            chucvus = db.GetTable<ChucVu>();

            var GetChucVu = from cv in chucvus
                            select new { cv.MaChucVu, cv.TenChucVu };
            cbChucVu.DataSource = GetChucVu;
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "MaChucVu";
        }

        private void HienThiDuLieuCB()
        {
            canbovpdoans = db.GetTable<CanBoVPDoan>();
            chucvus = db.GetTable<ChucVu>();

            var GetCBVPD = from cb in canbovpdoans
                           join cv in chucvus on cb.MaChucVu equals cv.MaChucVu
                           select new { cb.MaCanBoDoan, cb.HoVaTenKhaiSinh, cv.TenChucVu, GioiTinh = GioiTinh(cb.GioiTinh), cb.DiaChi, cb.SoDienThoai };

            dtgCanBo.DataSource = GetCBVPD;
            Clear();
            Bindding();
        }

        private void Bindding()
        {
            if (dtgCanBo.RowCount != 0)
            {
                txtMaCanBo.DataBindings.Clear();
                txtMaCanBo.DataBindings.Add("text", dtgCanBo.DataSource, "MaCanBoDoan");
                txtHoVaTen.DataBindings.Clear();
                txtHoVaTen.DataBindings.Add("text", dtgCanBo.DataSource, "HoVaTenKhaiSinh");
                cbGioiTinh.DataBindings.Clear();
                cbGioiTinh.DataBindings.Add("text", dtgCanBo.DataSource, "GioiTinh");
                cbChucVu.DataBindings.Clear();
                cbChucVu.DataBindings.Add("text", dtgCanBo.DataSource, "TenChucVu");
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("text", dtgCanBo.DataSource, "DiaChi");
                txtSDT.DataBindings.Clear();
                txtSDT.DataBindings.Add("text", dtgCanBo.DataSource, "SoDienThoai");
            }
        }

        private string GioiTinh(Boolean sex)
        {
            if (sex)
            {
                return "Nam";
            }
            return "Nữ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCanBo.Text != null && txtHoVaTen.Text != null && txtDiaChi.Text != null && txtSDT.Text != null)
            {
                CanBoVPDoan canbovpdoan = new CanBoVPDoan();
                canbovpdoan.MaCanBoDoan = txtMaCanBo.Text;
                canbovpdoan.HoVaTenKhaiSinh = txtHoVaTen.Text;
                canbovpdoan.MaChucVu = cbChucVu.SelectedValue.ToString();
                canbovpdoan.DiaChi = txtDiaChi.Text;
                canbovpdoan.SoDienThoai = txtSDT.Text;
                canbovpdoan.GioiTinh = true;
                if (cbGioiTinh.SelectedIndex == 0)
                {
                    canbovpdoan.GioiTinh = false;
                }
                canbovpdoans = db.GetTable<CanBoVPDoan>();
                Boolean has = canbovpdoans.Any(cb => cb.MaCanBoDoan == txtMaCanBo.Text);
                if (has)
                {
                    MessageBox.Show("Đã Tồn tại cán bộ");
                }
                else
                {
                    canbovpdoans.InsertOnSubmit(canbovpdoan);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    HienThiDuLieuCB();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCanBo.Text != null && txtHoVaTen.Text != null && txtDiaChi.Text != null && txtSDT.Text != null)
            {
                Boolean has = canbovpdoans.Any(cb => cb.MaCanBoDoan == txtMaCanBo.Text);
                if (has)
                {
                    string macanbo = txtMaCanBo.Text;
                    CanBoVPDoan canbo = canbovpdoans.Single(sv => sv.MaCanBoDoan == macanbo);
                    canbo.HoVaTenKhaiSinh = txtHoVaTen.Text;
                    canbo.DiaChi = txtDiaChi.Text;
                    canbo.GioiTinh = true;
                    if (cbGioiTinh.SelectedIndex == 0)
                    {
                        canbo.GioiTinh = false;
                    }
                    canbo.MaChucVu = cbChucVu.SelectedValue.ToString();
                    canbo.SoDienThoai = txtSDT.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    HienThiDuLieuCB();
                }
                else
                {
                    MessageBox.Show("Không Tồn tại cán bộ");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCanBo.Text != null && txtHoVaTen.Text != null && txtDiaChi.Text != null && txtSDT.Text != null)
            {
                Boolean has = canbovpdoans.Any(cb => cb.MaCanBoDoan == txtMaCanBo.Text);
                if (has)
                {
                    string macanbo = txtMaCanBo.Text;
                    CanBoVPDoan canbo = canbovpdoans.Single(sv => sv.MaCanBoDoan == macanbo);
                    canbovpdoans.DeleteOnSubmit(canbo);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    HienThiDuLieuCB();
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                }
            }
            else
            //aaaa
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            canbovpdoans = db.GetTable<CanBoVPDoan>();
            chucvus = db.GetTable<ChucVu>();
            string timkiem = txtTimKiem.Text;
            var GetCBVPD = from cb in canbovpdoans
                           join cv in chucvus on cb.MaChucVu equals cv.MaChucVu
                           where cb.MaCanBoDoan.Contains(timkiem) || cb.HoVaTenKhaiSinh.Contains(timkiem)
                           select new { cb.MaCanBoDoan, cb.HoVaTenKhaiSinh, cv.TenChucVu, GioiTinh = GioiTinh(cb.GioiTinh), cb.DiaChi, cb.SoDienThoai };

            dtgCanBo.DataSource = GetCBVPD;
            Bindding();
        }

        private void Clear()
        {
            txtTimKiem.Clear();
            txtHoVaTen.Clear();
            txtMaCanBo.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            cbChucVu.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
        }
    }
}
