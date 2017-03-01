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
    public partial class frmThongTinNopDoanPhi : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<CanBoVPDoan> CANBOVPDOAN;
        Table<ThongTinNopDoanPhi> THONGTINNOPDOANPHI;
        Table<SinhVien> SINHVIEN;
        Table<Khoa> KHOA;
        Table<NganhHoc> NGANHHOC;
        Table<LopQuanLy> LOPQUANLY;

        public frmThongTinNopDoanPhi()
        {
            InitializeComponent();
            SetDefaultProperties();
            DisplayOnDataGridView();
            LoadCombobox();
            ClearTextbox();
            DoBindding();
        }

        private void DisplayOnDataGridView()
        {
            CANBOVPDOAN = database.GetTable<CanBoVPDoan>();
            THONGTINNOPDOANPHI = database.GetTable<ThongTinNopDoanPhi>();
            SINHVIEN = database.GetTable<SinhVien>();

            var query = from thongtin in THONGTINNOPDOANPHI
                        join canbo in CANBOVPDOAN on thongtin.MaCanBoDoan equals canbo.MaCanBoDoan
                        join sv in SINHVIEN on thongtin.MaSinhVien equals sv.MaSinhVien
                        orderby thongtin.id
                        select new
                        {
                            thongtin.SoPhieu,
                            TenSinhVien = sv.HoDem + " " + sv.Ten,
                            sv.MaSinhVien,
                            thongtin.NgayNop,
                            thongtin.SoTien,
                            CanBo = canbo.HoVaTenKhaiSinh,
                            GhiNo = thongtin.GhiNo == true ? "Có" : "Không",
                            GhiNoChk = thongtin.GhiNo,
                            thongtin.NoiDung
                        };

            dgvThongTinNopDoanPhi.DataSource = query;
            DoBindding();
        }
        private void DisplayOnDataGridView(string maLop)
        {
            CANBOVPDOAN = database.GetTable<CanBoVPDoan>();
            THONGTINNOPDOANPHI = database.GetTable<ThongTinNopDoanPhi>();
            SINHVIEN = database.GetTable<SinhVien>();

            var query = from thongtin in THONGTINNOPDOANPHI
                        join canbo in CANBOVPDOAN on thongtin.MaCanBoDoan equals canbo.MaCanBoDoan
                        join sv in SINHVIEN on thongtin.MaSinhVien equals sv.MaSinhVien
                        where sv.MaLop == maLop //this difrence
                        orderby thongtin.id
                        select new
                        {
                            thongtin.SoPhieu,
                            TenSinhVien = sv.HoDem + " " + sv.Ten,
                            sv.MaSinhVien,
                            thongtin.NgayNop,
                            thongtin.SoTien,
                            CanBo = canbo.HoVaTenKhaiSinh,
                            GhiNo = thongtin.GhiNo == true ? "Có" : "Không",
                            GhiNoChk = thongtin.GhiNo,
                            thongtin.NoiDung
                        };

            dgvThongTinNopDoanPhi.DataSource = query;
            DoBindding();
        }
        private void LoadCombobox()
        {
            LoadData_cbxKhoa();
            LoadData_cbxCanBo();

            LoadData_cbxNganh(cbxKhoa.SelectedValue.ToString());
            LoadData_cbxLop(cbxNganh.SelectedValue.ToString());
        }
        private void LoadData_cbxLop(string MaNganh)
        {
            LOPQUANLY = database.GetTable<LopQuanLy>();

            var QueryLopQL = from lop in LOPQUANLY
                             where lop.MaNganh == MaNganh
                             select new
                             {
                                 lop.MaLop,
                                 lop.TenLop
                             };

            cbxLop.DataSource = QueryLopQL;
            cbxLop.ValueMember = "MaLop";
            cbxLop.DisplayMember = "TenLop";
        }
        private void LoadData_cbxCanBo()
        {
            CANBOVPDOAN = database.GetTable<CanBoVPDoan>();

            var qwerty = from canbo in CANBOVPDOAN
                         select new
                         {
                             TenCanBo = canbo.HoVaTenKhaiSinh,
                             MaCanBo = canbo.MaCanBoDoan
                         };

            cbxCanBo.DataSource = qwerty;
            cbxCanBo.DisplayMember = "TenCanBo";
            cbxCanBo.ValueMember = "MaCanBo";
        }
        private void LoadData_cbxKhoa()
        {
            KHOA = database.GetTable<Khoa>();
            var QueryKhoa = from khoa in KHOA
                            select new
                            {
                                khoa.MaKhoa,
                                khoa.TenKhoa
                            };
            cbxKhoa.DataSource = QueryKhoa;
            cbxKhoa.DisplayMember = "TenKhoa";
            cbxKhoa.ValueMember = "MaKhoa";
        }
        private void LoadData_cbxNganh(string MaKhoa)
        {
            NGANHHOC = database.GetTable<NganhHoc>();

            var QueryNganhHoc = from nganh in NGANHHOC
                                where nganh.MaKhoa == MaKhoa
                                select new
                                {
                                    nganh.MaNganh,
                                    nganh.TenNganh
                                };

            cbxNganh.DataSource = QueryNganhHoc;
            cbxNganh.DisplayMember = "TenNganh";
            cbxNganh.ValueMember = "MaNganh";
        }
        private void ClearTextbox()
        {
            txtMaSinhVien.Clear();
            txtNoiDung.Clear();
            txtSoPhieu.Clear();
            txtSoTien.Clear();
            txtTenSinhVien.Clear();
            chkGhiNo.Checked = false;
            cbxCanBo.Text = "";
        }
        private bool TextboxEmpty()
        {
            if (txtNoiDung.Text.Trim() == "" || txtSoPhieu.Text.Trim() == "" ||
                txtSoTien.Text.Trim() == "" || cbxCanBo.Text.Trim() == "" ||
                txtMaSinhVien.Text.Trim() == "")
                return true;
            else
                return false;
        }
        private void DoBindding()
        {
            txtMaSinhVien.DataBindings.Clear();
            cbxCanBo.DataBindings.Clear();
            txtSoPhieu.DataBindings.Clear();
            txtNoiDung.DataBindings.Clear();
            dateNgayNop.DataBindings.Clear();
            txtSoTien.DataBindings.Clear();
            chkGhiNo.DataBindings.Clear();
            txtTenSinhVien.DataBindings.Clear();

            txtMaSinhVien.DataBindings.Add("text", dgvThongTinNopDoanPhi.DataSource, "MaSinhVien");
            cbxCanBo.DataBindings.Add("text", dgvThongTinNopDoanPhi.DataSource, "CanBo");
            txtSoPhieu.DataBindings.Add("text", dgvThongTinNopDoanPhi.DataSource, "SoPhieu");
            txtNoiDung.DataBindings.Add("text", dgvThongTinNopDoanPhi.DataSource, "NoiDung");
            dateNgayNop.DataBindings.Add("value", dgvThongTinNopDoanPhi.DataSource, "NgayNop");
            txtSoTien.DataBindings.Add("text", dgvThongTinNopDoanPhi.DataSource, "SoTien");
            chkGhiNo.DataBindings.Add("checked", dgvThongTinNopDoanPhi.DataSource, "GhiNoChk");
            txtTenSinhVien.DataBindings.Add("text", dgvThongTinNopDoanPhi.DataSource, "TenSinhVien");
        }
        private void SetDefaultProperties()
        {
            dgvThongTinNopDoanPhi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //throw new NotImplementedException();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThongTinNopDoanPhi_Them f = new frmThongTinNopDoanPhi_Them();
            f.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gbxQuanLyThongTin.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (TextboxEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            else
            {
                bool SoPhieuTonTai = THONGTINNOPDOANPHI.Any(row => row.SoPhieu == txtSoPhieu.Text.Trim());
                if (SoPhieuTonTai)
                {
                    try
                    {
                        ThongTinNopDoanPhi obj = THONGTINNOPDOANPHI.Single(row => row.SoPhieu == txtSoPhieu.Text.Trim());
                        obj.NgayNop = dateNgayNop.Value;
                        obj.SoTien = Convert.ToDecimal(txtSoTien.Text.ToString().Trim());
                        obj.NoiDung = txtNoiDung.Text.Trim();
                        obj.MaCanBoDoan = cbxCanBo.SelectedValue.ToString().Trim();
                        obj.MaSinhVien = txtMaSinhVien.Text.Trim();
                        obj.GhiNo = chkGhiNo.Checked ? true : false;

                        database.SubmitChanges();
                        MessageBox.Show("Sửa thành công", "Thông Báo");
                        DisplayOnDataGridView();

                        gbxQuanLyThongTin.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi không xác định: " + ex.Message, "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể thay đổi mã phiếu", "Thông Báo");
                }
            }
            
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData_cbxNganh(cbxKhoa.SelectedValue.ToString());
        }

        private void cbxNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData_cbxLop(cbxNganh.SelectedValue.ToString());
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = cbxLop.SelectedValue.ToString();
                DisplayOnDataGridView(maLop);
            }
            catch
            {
                MessageBox.Show("Xin vui lòng chọn lớp sinh viên để xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearTextbox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text;

            CANBOVPDOAN = database.GetTable<CanBoVPDoan>();
            THONGTINNOPDOANPHI = database.GetTable<ThongTinNopDoanPhi>();
            SINHVIEN = database.GetTable<SinhVien>();

            var query = from thongtin in THONGTINNOPDOANPHI
                        join canbo in CANBOVPDOAN on thongtin.MaCanBoDoan equals canbo.MaCanBoDoan
                        join sv in SINHVIEN on thongtin.MaSinhVien equals sv.MaSinhVien
                        where thongtin.SoPhieu.Contains(timkiem) ||
                            //thongtin.SoTien.ToString().Contains(timkiem) ||
                            //thongtin.NgayNop.ToString().Contains(timkiem) ||
                            sv.HoVaTenKhaiSinh.Contains(timkiem) ||
                            sv.MaSinhVien.Contains(timkiem)
                            //canbo.HoVaTenKhaiSinh.Contains(timkiem) ||
                            //canbo.MaCanBoDoan.Contains(timkiem) ||
                            //thongtin.GhiNo.ToString().Contains(timkiem) ||
                            //thongtin.NoiDung.Contains(timkiem)
                        orderby thongtin.id
                        select new
                        {
                            thongtin.SoPhieu,
                            TenSinhVien = sv.HoDem + " " + sv.Ten,
                            sv.MaSinhVien,
                            thongtin.NgayNop,
                            thongtin.SoTien,
                            CanBo = canbo.HoVaTenKhaiSinh,
                            GhiNo = thongtin.GhiNo == true ? "Có" : "Không",
                            GhiNoChk = thongtin.GhiNo,
                            thongtin.NoiDung
                        };

            dgvThongTinNopDoanPhi.DataSource = query;
            DoBindding();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string SoPhieu = txtSoPhieu.Text.Trim();
            DialogResult confirm = MessageBox.Show("Đồng ý xóa " + SoPhieu + "?", "Thông Báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                else
                {
                    bool SoPhieuTonTai = THONGTINNOPDOANPHI.Any(row => row.SoPhieu == txtSoPhieu.Text.Trim());
                    if (SoPhieuTonTai)
                        try
                        {
                            ThongTinNopDoanPhi obj = THONGTINNOPDOANPHI.Single(row => row.SoPhieu == txtSoPhieu.Text.Trim());
                            THONGTINNOPDOANPHI.DeleteOnSubmit(obj);
                            database.SubmitChanges();

                            MessageBox.Show("Xóa thành công", "Thông Báo");
                            DisplayOnDataGridView();
                            //ClearTextbox();
                            gbxQuanLyThongTin.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi không xác định: " + ex.Message, "Thông Báo");
                        }
                    else
                        MessageBox.Show("Số phiếu không tồn tại", "Thông Báo");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gbxQuanLyThongTin.Enabled = false;
        }
    }
}
