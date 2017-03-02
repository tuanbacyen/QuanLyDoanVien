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
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
            cbDanToc.SelectedIndex = 0;
            cbTonGiao.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
            HienThiCBTinhTrang();
            load_Data();
            KhongNhap();
        }
        QuanLyDoanVienDataContext db = new QuanLyDoanVienDataContext();
        Table<Khoa> khoas;
        Table<NganhHoc> nganhhocs;
        Table<LopQuanLy> lopquanlys;
        Table<SinhVien> sinhviens;
        Table<TinhTrangHocTap> tinhtranghoctaps;

        private void load_Data()
        {
            HienThiCBKhoa();
            HienThiCBNganh(cbKhoa.SelectedValue.ToString());
            HienThiCBLop(cbNganh.SelectedValue.ToString());
            BiddingSinhVien();
        }

        private void load_HienThiSV()
        {
            try
            {
                HienThiSinhVien(cbLop.SelectedValue.ToString());
                Clear();
                BiddingSinhVien();
            }
            catch { }
        }

        private void HienThiCBTinhTrang()
        {
            tinhtranghoctaps = db.GetTable<TinhTrangHocTap>();

            var GetTinhTrang = from tc in tinhtranghoctaps
                               select new { tc.MaTinhTrangHocTap, tc.TenTinhTrangHocTap };
            cbTinhTrang.DataSource = GetTinhTrang;
            cbTinhTrang.ValueMember = "MaTinhTrangHocTap";
            cbTinhTrang.DisplayMember = "TenTinhTrangHocTap";
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
                cbLopHoc.DataSource = Getlopquanly;
                cbLopHoc.ValueMember = "MaLop";
                cbLopHoc.DisplayMember = "TenLop";

                cbLop.DataSource = Getlopquanly;
                cbLop.ValueMember = "MaLop";
                cbLop.DisplayMember = "TenLop";
            }
        }

        private void HienThiSinhVien(string maLop)
        {
            sinhviens = db.GetTable<SinhVien>();
            lopquanlys = db.GetTable<LopQuanLy>();
            tinhtranghoctaps = db.GetTable<TinhTrangHocTap>();

            var GetSinhVien = from sv in sinhviens
                              join lql in lopquanlys on sv.MaLop equals lql.MaLop
                              join tc in tinhtranghoctaps on sv.MaTinhTrangHocTap equals tc.MaTinhTrangHocTap
                              where sv.MaLop == maLop && sv.Xoa == false
                              select new
                              {
                                  sv.MaSinhVien,
                                  sv.HoDem,
                                  sv.Ten,
                                  sv.HoVaTenKhaiSinh,
                                  sv.HoTenKhac,
                                  GioiTinh = GioiTinh(sv.GioiTinh),
                                  sv.NgaySinh,
                                  lql.TenLop,
                                  sv.DanToc,
                                  sv.TonGiao,
                                  tc.TenTinhTrangHocTap,
                                  sv.DiaChi,
                                  sv.SoDienThoai,
                                  sv.NgayVaoDoan
                              };
            if (GetSinhVien.Count() == 0)
            {
                dtgSinhVien.DataSource = null;
            }
            else
            {
                dtgSinhVien.DataSource = GetSinhVien;
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

        private void BiddingSinhVien()
        {
            if (dtgSinhVien.RowCount != 0)
            {
                txtMaSinhVien.DataBindings.Clear();
                txtMaSinhVien.DataBindings.Add("text", dtgSinhVien.DataSource, "MaSinhVien");
                txtHoDem.DataBindings.Clear();
                txtHoDem.DataBindings.Add("text", dtgSinhVien.DataSource, "HoDem");
                txtTen.DataBindings.Clear();
                txtTen.DataBindings.Add("text", dtgSinhVien.DataSource, "Ten");
                txtTenKhac.DataBindings.Clear();
                txtTenKhac.DataBindings.Add("text", dtgSinhVien.DataSource, "HoTenKhac");
                cbGioiTinh.DataBindings.Clear();
                cbGioiTinh.DataBindings.Add("text", dtgSinhVien.DataSource, "GioiTinh");
                dtNgaySinh.DataBindings.Clear();
                dtNgaySinh.DataBindings.Add("text", dtgSinhVien.DataSource, "NgaySinh");
                cbLopHoc.DataBindings.Clear();
                cbLopHoc.DataBindings.Add("text", dtgSinhVien.DataSource, "TenLop");
                cbDanToc.DataBindings.Clear();
                cbDanToc.DataBindings.Add("text", dtgSinhVien.DataSource, "DanToc");
                cbTonGiao.DataBindings.Clear();
                cbTonGiao.DataBindings.Add("text", dtgSinhVien.DataSource, "TonGiao");
                cbTinhTrang.DataBindings.Clear();
                cbTinhTrang.DataBindings.Add("text", dtgSinhVien.DataSource, "TenTinhTrangHocTap");
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("text", dtgSinhVien.DataSource, "DiaChi");
                txtSDT.DataBindings.Clear();
                txtSDT.DataBindings.Add("text", dtgSinhVien.DataSource, "SoDienThoai");
                dtNgayVaoDoan.DataBindings.Clear();
                dtNgayVaoDoan.DataBindings.Add("text", dtgSinhVien.DataSource, "NgayVaoDoan");
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            load_HienThiSV();
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
            if (txtMaSinhVien.Text.Trim().Trim() != "" && txtTen.Text.Trim() != "" && txtHoDem.Text.Trim() != "" && txtDiaChi.Text.Trim() != "" && txtSDT.Text.Trim() != "" && cbLopHoc.Text.Trim() != "")
            {
                SinhVien sinhvien = new SinhVien();
                sinhvien.MaSinhVien = txtMaSinhVien.Text;
                sinhvien.Ten = txtTen.Text;
                sinhvien.HoDem = txtHoDem.Text;
                sinhvien.HoVaTenKhaiSinh = txtHoDem.Text + " " + txtTen.Text;
                if (txtTenKhac.Text.Trim() != "")
                {
                    sinhvien.HoTenKhac = txtTenKhac.Text;
                }
                sinhvien.GioiTinh = true;
                if (cbGioiTinh.SelectedIndex == 0)
                {
                    sinhvien.GioiTinh = false;
                }
                sinhvien.NgaySinh = dtNgaySinh.Value;
                sinhvien.MaLop = cbLopHoc.SelectedValue.ToString();
                sinhvien.DanToc = cbDanToc.Text;
                sinhvien.TonGiao = cbTonGiao.Text;
                sinhvien.MaTinhTrangHocTap = cbTinhTrang.SelectedValue.ToString();
                sinhvien.DiaChi = txtDiaChi.Text;
                sinhvien.SoDienThoai = txtSDT.Text;
                sinhvien.NgayVaoDoan = dtNgayVaoDoan.Value;
                Boolean has = sinhviens.Any(sv => sv.MaSinhVien == txtMaSinhVien.Text);
                if (has)
                {
                    MessageBox.Show("Đã Tồn tại Sinh viên");
                }
                else
                {
                    sinhviens = db.GetTable<SinhVien>();
                    sinhviens.InsertOnSubmit(sinhvien);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    load_HienThiSV();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
        }

        private void Clear()
        {
            txtHoDem.Clear();
            txtTen.Clear();
            txtTenKhac.Clear();
            txtDiaChi.Clear();
            txtMaSinhVien.Clear();
            txtSDT.Clear();
            txtTimKiem.Clear();
            cbDanToc.SelectedIndex = 0;
            cbLopHoc.SelectedIndex = 0;
            cbTinhTrang.SelectedIndex = 0;
            cbTonGiao.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
            dtNgaySinh.Value = DateTime.Now;
            dtNgayVaoDoan.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSinhVien.Text.Trim() != "" && txtTen.Text.Trim() != "" && txtHoDem.Text.Trim() != "" && txtDiaChi.Text.Trim() != "" && txtSDT.Text.Trim() != "")
                {
                    string masinhvien = txtMaSinhVien.Text;
                    SinhVien sinhvien = sinhviens.Single(sv => sv.MaSinhVien == masinhvien);
                    sinhvien.Ten = txtTen.Text;
                    sinhvien.HoDem = txtHoDem.Text;
                    sinhvien.HoVaTenKhaiSinh = txtHoDem.Text + " " + txtTen.Text;
                    if (txtTenKhac.Text.Trim() != "")
                    {
                        sinhvien.HoTenKhac = txtTenKhac.Text;
                    }
                    sinhvien.GioiTinh = true;
                    if (cbGioiTinh.SelectedIndex == 0)
                    {
                        sinhvien.GioiTinh = false;
                    }
                    sinhvien.NgaySinh = dtNgaySinh.Value;
                    sinhvien.MaLop = cbLopHoc.SelectedValue.ToString();
                    sinhvien.DanToc = cbDanToc.Text;
                    sinhvien.TonGiao = cbTonGiao.Text;
                    sinhvien.MaTinhTrangHocTap = cbTinhTrang.SelectedValue.ToString();
                    sinhvien.DiaChi = txtDiaChi.Text;
                    sinhvien.SoDienThoai = txtSDT.Text;
                    sinhvien.NgayVaoDoan = dtNgayVaoDoan.Value;
                    Boolean has = sinhviens.Any(sv => sv.MaSinhVien == txtMaSinhVien.Text);
                    if (has)
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công", "Thông Báo");
                        load_HienThiSV();
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
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Thông Báo"); }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLopHoc.SelectedIndex = cbLop.SelectedIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSinhVien.Text.Trim() != "")
                {
                    Boolean has = sinhviens.Any(sv => sv.MaSinhVien == txtMaSinhVien.Text);
                    if (has)
                    {
                        string masinhvien = txtMaSinhVien.Text;
                        SinhVien sinhvien = sinhviens.Single(sv => sv.MaSinhVien == masinhvien);
                        sinhvien.Xoa = true;
                        //sinhviens.DeleteOnSubmit(sinhvien);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công", "Thông Báo");
                        load_HienThiSV();
                    }
                    else
                    {
                        MessageBox.Show("Không có Sinh viên");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin", "Thông Báo");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Thông Báo"); }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sinhviens = db.GetTable<SinhVien>();
            lopquanlys = db.GetTable<LopQuanLy>();
            tinhtranghoctaps = db.GetTable<TinhTrangHocTap>();
            string search = txtTimKiem.Text;
            var GetSinhVien = from sv in sinhviens
                              join lql in lopquanlys on sv.MaLop equals lql.MaLop
                              join tc in tinhtranghoctaps on sv.MaTinhTrangHocTap equals tc.MaTinhTrangHocTap
                              where sv.HoVaTenKhaiSinh.Contains(search) || sv.MaSinhVien.Contains(search) && sv.Xoa == false
                              select new
                              {
                                  sv.MaSinhVien,
                                  sv.HoDem,
                                  sv.Ten,
                                  sv.HoVaTenKhaiSinh,
                                  sv.HoTenKhac,
                                  GioiTinh = GioiTinh(sv.GioiTinh),
                                  sv.NgaySinh,
                                  lql.TenLop,
                                  sv.DanToc,
                                  sv.TonGiao,
                                  tc.TenTinhTrangHocTap,
                                  sv.DiaChi,
                                  sv.SoDienThoai,
                                  sv.NgayVaoDoan
                              };
            dtgSinhVien.DataSource = GetSinhVien;
            BiddingSinhVien();
        }

        private void KhongNhap()
        {
            cbKhoa.KeyPress += DontInput;
            cbLop.KeyPress += DontInput;
            cbLopHoc.KeyPress += DontInput;
            cbNganh.KeyPress += DontInput;
            cbDanToc.KeyPress += DontInput;
            cbTinhTrang.KeyPress += DontInput;
            cbGioiTinh.KeyPress += DontInput;
        }

        private void DontInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
