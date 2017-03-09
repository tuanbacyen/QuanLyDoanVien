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
    public partial class FormSoDoanVien : Form
    {
        public FormSoDoanVien()
        {
            InitializeComponent();
            HienThiCanBo();
            load_Data();
            KhongNhap();
        }

        QuanLyDoanVienDataContext db = new QuanLyDoanVienDataContext();
        Table<CanBoVPDoan> canbovpdoans;
        Table<SinhVien> sinhviens;
        Table<SoDoanVien> sodoanviens;
        Table<Khoa> khoas;
        Table<NganhHoc> nganhhocs;
        Table<LopQuanLy> lopquanlys;

        private void load_Data()
        {
            HienThiCBKhoa();
            HienThiCBNganh(cbKhoa.SelectedValue.ToString());
            HienThiCBLop(cbNganh.SelectedValue.ToString());
            Bindding();
        }

        private void HienThiCBKhoa()
        {
            khoas = db.GetTable<Khoa>();

            var GetKhoa = from kh in khoas
                          select new { kh.MaKhoa, kh.TenKhoa };
            cbKhoa.DataSource = GetKhoa;
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.DisplayMember = "TenKhoa";
        }

        private void HienThiCBNganh(string maKhoa)
        {
            nganhhocs = db.GetTable<NganhHoc>();

            var GetNganh = from ngh in nganhhocs
                           where ngh.MaKhoa == maKhoa
                           select new { ngh.MaNganh, ngh.TenNganh };

            cbNganh.DataSource = GetNganh;
            cbNganh.ValueMember = "MaNganh";
            cbNganh.DisplayMember = "TenNganh";
        }

        private void HienThiCBLop(string maNganh)
        {
            lopquanlys = db.GetTable<LopQuanLy>();

            var Getlopquanly = from lql in lopquanlys
                               where lql.MaNganh == maNganh
                               select new { lql.MaLop, lql.TenLop };
            if (Getlopquanly.Count() == 0)
            {
                cbLop.DataSource = null;
            }
            else
            {
                cbLop.DataSource = Getlopquanly;
                cbLop.ValueMember = "MaLop";
                cbLop.DisplayMember = "TenLop";
            }
        }

        private void Load_DataSoDoan()
        {
            string maLop = cbLop.SelectedValue.ToString();
            canbovpdoans = db.GetTable<CanBoVPDoan>();
            sinhviens = db.GetTable<SinhVien>();
            sodoanviens = db.GetTable<SoDoanVien>();

            var GetSoDoanVien = from sd in sodoanviens
                                join cb in canbovpdoans on sd.MaCanBoDoan equals cb.MaCanBoDoan
                                join sv in sinhviens on sd.MaSinhVien equals sv.MaSinhVien
                                where sv.MaLop == maLop && sv.Xoa == false
                                select new { sd.MaSoDoan, sv.MaSinhVien, TenSinhVien = sv.HoVaTenKhaiSinh, CanBoThuSoDoan = cb.HoVaTenKhaiSinh, sd.NgayNop, sd.ThongTinSoDoan, sd.NhanXet, sd.GhiChu };

            dtgSoDoan.DataSource = GetSoDoanVien;
            Clear();
            Bindding();
        }

        private void HienThiCanBo()
        {
            canbovpdoans = db.GetTable<CanBoVPDoan>();

            var GetCanBo = from cb in canbovpdoans
                           select new { cb.MaCanBoDoan, cb.HoVaTenKhaiSinh };
            cbCanBo.DataSource = GetCanBo;
            cbCanBo.DisplayMember = "HoVaTenKhaiSinh";
            cbCanBo.ValueMember = "MaCanBoDoan";
        }

        private void Bindding()
        {
            if (dtgSoDoan.RowCount != 0)
            {
                txtMaSinhVien.DataBindings.Clear();
                txtMaSinhVien.DataBindings.Add("text", dtgSoDoan.DataSource, "MaSinhVien");
                txtMaSoDoan.DataBindings.Clear();
                txtMaSoDoan.DataBindings.Add("text", dtgSoDoan.DataSource, "MaSoDoan");
                cbCanBo.DataBindings.Clear();
                cbCanBo.DataBindings.Add("text", dtgSoDoan.DataSource, "CanBoThuSoDoan");
                txtNhanXet.DataBindings.Clear();
                txtNhanXet.DataBindings.Add("text", dtgSoDoan.DataSource, "NhanXet");
                txtGhiChu.DataBindings.Clear();
                txtGhiChu.DataBindings.Add("text", dtgSoDoan.DataSource, "GhiChu");
                txtThongTin.DataBindings.Clear();
                txtThongTin.DataBindings.Add("text", dtgSoDoan.DataSource, "ThongTinSoDoan");
                dtNgayNop.DataBindings.Clear();
                dtNgayNop.DataBindings.Add("text", dtgSoDoan.DataSource, "NgayNop");
            }
        }

        private void Clear()
        {
            txtMaSinhVien.Clear();
            txtMaSoDoan.Clear();
            txtNhanXet.Clear();
            txtGhiChu.Clear();
            txtThongTin.Clear();
            txtTimKiem.Clear();
            cbCanBo.SelectedIndex = 0;
            dtNgayNop.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            Load_DataSoDoan();
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCBNganh(cbKhoa.SelectedValue.ToString());
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCBLop(cbNganh.SelectedValue.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text != null && txtMaSoDoan.Text != null && txtThongTin.Text != null && txtNhanXet.Text != null)
            {
                SoDoanVien sodoanvien = new SoDoanVien();
                sodoanvien.MaSinhVien = txtMaSinhVien.Text;
                sodoanvien.MaSoDoan = txtMaSoDoan.Text;
                sodoanvien.NhanXet = txtNhanXet.Text;
                sodoanvien.NgayNop = dtNgayNop.Value;
                sodoanvien.MaCanBoDoan = cbCanBo.SelectedValue.ToString();
                sodoanvien.GhiChu = txtGhiChu.Text;
                sodoanvien.ThongTinSoDoan = txtThongTin.Text;
                Boolean has = sodoanviens.Any(sd => sd.MaSinhVien == txtMaSinhVien.Text && sd.MaSoDoan == txtMaSoDoan.Text);
                if (has)
                {
                    MessageBox.Show("Sinh viên đã nộp sổ đoàn");
                }
                else
                {
                    sodoanviens = db.GetTable<SoDoanVien>();
                    sodoanviens.InsertOnSubmit(sodoanvien);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    Load_DataSoDoan();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text != null && txtMaSoDoan.Text != null && txtThongTin.Text != null && txtNhanXet.Text != null)
            {
                string masinhvien = txtMaSinhVien.Text;
                string masodoan = txtMaSoDoan.Text;

                SoDoanVien sodoanvien = sodoanviens.Single(sd => sd.MaSoDoan == masodoan && sd.MaSinhVien == masinhvien);
                sodoanvien.MaSinhVien = txtMaSinhVien.Text;
                sodoanvien.MaSoDoan = txtMaSoDoan.Text;
                sodoanvien.NhanXet = txtNhanXet.Text;
                sodoanvien.NgayNop = dtNgayNop.Value;
                sodoanvien.MaCanBoDoan = cbCanBo.SelectedValue.ToString();
                sodoanvien.GhiChu = txtGhiChu.Text;
                Boolean has = sodoanviens.Any(sd => sd.MaSinhVien == txtMaSinhVien.Text && sd.MaSoDoan == txtMaSoDoan.Text);
                if (has)
                {
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    Load_DataSoDoan();
                }
                else
                {
                    MessageBox.Show("không có ố đoàn này");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text != null && txtMaSoDoan.Text != null)
            {

                Boolean has = sodoanviens.Any(sd => sd.MaSinhVien == txtMaSinhVien.Text && sd.MaSoDoan == txtMaSoDoan.Text);
                if (has)
                {
                    string masinhvien = txtMaSinhVien.Text;
                    string masodoan = txtMaSoDoan.Text;
                    SoDoanVien sodoanvien = sodoanviens.Single(sd => sd.MaSoDoan == masodoan && sd.MaSinhVien == masinhvien);
                    sodoanviens.DeleteOnSubmit(sodoanvien);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    Load_DataSoDoan();
                }
                else
                {
                    MessageBox.Show("Không có Sinh viên");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            canbovpdoans = db.GetTable<CanBoVPDoan>();
            sinhviens = db.GetTable<SinhVien>();
            sodoanviens = db.GetTable<SoDoanVien>();
            string timkiem = txtTimKiem.Text;
            var GetSoDoanVien = from sd in sodoanviens
                                join cb in canbovpdoans on sd.MaCanBoDoan equals cb.MaCanBoDoan
                                join sv in sinhviens on sd.MaSinhVien equals sv.MaSinhVien
                                where sv.HoVaTenKhaiSinh.Contains(timkiem) || sv.MaSinhVien.Contains(timkiem) || sd.MaSoDoan.Contains(timkiem) || cb.HoVaTenKhaiSinh.Contains(timkiem) && sv.Xoa == false
                                select new { sd.MaSoDoan, sv.MaSinhVien, TenSinhVien = sv.HoVaTenKhaiSinh, CanBoThuSoDoan = cb.HoVaTenKhaiSinh, sd.NgayNop, sd.ThongTinSoDoan, sd.NhanXet, sd.GhiChu };

            dtgSoDoan.DataSource = GetSoDoanVien;
            Clear();
            Bindding();
        }


        private void KhongNhap()
        {
            cbKhoa.KeyPress += DontInput;
            cbLop.KeyPress += DontInput;
            cbNganh.KeyPress += DontInput;
            cbCanBo.KeyPress += DontInput;
        }

        private void DontInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
