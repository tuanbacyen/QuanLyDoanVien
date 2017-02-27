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
    public partial class FormSinhVienLopQuanLy : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<Khoa> KHOA;
        Table<NganhHoc> NGANHHOC;
        Table<LopQuanLy> LOPQUANLY;
        Table<ChucVu> CHUCVU;
        Table<SinhVien_LopQuanLy> SV_LOPQUANLY;

        public FormSinhVienLopQuanLy()
        {
            InitializeComponent();
            DisplayOnDataGridView();
            LoadCombobox();
            ClearTextbox();
            DoBindding();
        }

        
        #region Nonamed

        private void LoadCombobox()
        {
            //get data for each table
            KHOA = database.GetTable<Khoa>();
            NGANHHOC = database.GetTable<NganhHoc>();
            LOPQUANLY = database.GetTable<LopQuanLy>();
            CHUCVU = database.GetTable<ChucVu>();

            //query to load to combobox
            var QueryNganhHoc = from nganh in NGANHHOC
                                select new
                                {
                                    nganh.MaNganh,
                                    nganh.TenNganh
                                };
            var QueryKhoa = from khoa in KHOA
                                select new
                                {
                                    khoa.MaKhoa,
                                    khoa.TenKhoa
                                };
            var QueryLopQL = from lop in LOPQUANLY
                             select new
                             {
                                 lop.MaLop,
                                 lop.TenLop
                             };
            var QueryChucVu = from chucvu in CHUCVU
                              select new
                              {
                                  chucvu.MaChucVu,
                                  chucvu.TenChucVu
                              };

            //load to combobox
            cbChucVu.DataSource = QueryChucVu;
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "MaChucVu";

            cbNganh.DataSource = QueryNganhHoc;
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "MaNganh";

            cbKhoa.DataSource = QueryKhoa;
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";

            cbLopHoc.DataSource = QueryLopQL;
            cbLopHoc.ValueMember = "MaLop";
            cbLopHoc.DisplayMember = "TenLop";
        }
        private void DoBindding()
        {
            txtMaSinhVien.DataBindings.Clear();
            txtNhiemKy.DataBindings.Clear();

            cbChucVu.DataBindings.Clear();
            cbKhoa.DataBindings.Clear();

            cbLopHoc.DataBindings.Clear();
            cbNganh.DataBindings.Clear();

            txtMaSinhVien.DataBindings.Add("text", dtgSinhVienLop.DataSource, "MaSinhVien");
            txtNhiemKy.DataBindings.Add("text", dtgSinhVienLop.DataSource, "NhiemKy");

            cbChucVu.DataBindings.Add("text", dtgSinhVienLop.DataSource, "TenChucVu");
            cbKhoa.DataBindings.Add("text", dtgSinhVienLop.DataSource, "TenKhoa");

            cbLopHoc.DataBindings.Add("text", dtgSinhVienLop.DataSource, "TenLop");
            cbNganh.DataBindings.Add("text", dtgSinhVienLop.DataSource, "TenNganh");
        }
        private void ClearTextbox()
        {
            txtMaSinhVien.Clear();
            txtNhiemKy.Clear();
            txtTimKiem.Clear();

            cbChucVu.SelectedIndex = 0;
            cbNganh.SelectedIndex = 0;
            cbKhoa.SelectedIndex = 0;
            cbLopHoc.SelectedIndex = 0;

        }
        private void DisplayOnDataGridView()
        {
            KHOA = database.GetTable<Khoa>();
            NGANHHOC = database.GetTable<NganhHoc>();
            LOPQUANLY = database.GetTable<LopQuanLy>();
            CHUCVU = database.GetTable<ChucVu>();
            SV_LOPQUANLY = database.GetTable<SinhVien_LopQuanLy>();

            var query = from svlop in SV_LOPQUANLY
                        join lop in LOPQUANLY on svlop.MaLop equals lop.MaLop
                        join chucvu in CHUCVU on svlop.MaChucVu equals chucvu.MaChucVu
                        join nganh in NGANHHOC on lop.MaNganh equals nganh.MaNganh
                        join khoa in KHOA on nganh.MaKhoa equals khoa.MaKhoa
                        orderby svlop.SV_LQLID
                        select new
                        {
                            STT = svlop.SV_LQLID,
                            svlop.MaSinhVien,
                            TenLop = lop.TenLop,
                            TenChucVu = chucvu.TenChucVu,
                            NhiemKy= svlop.NhiemKi,
                            TenNganh=nganh.TenNganh,
                            TenKhoa=khoa.TenKhoa,
                        };

            //Load to Datagridview
            dtgSinhVienLop.DataSource = query;

            DoBindding();
        }
        private bool TextboxEmpty()
        {
            if (txtMaSinhVien.Text.Trim() == "" || txtNhiemKy.Text.Trim() == "")
                return true;
            else
                return false;
        }

        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TextboxEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            else
            {
                bool MaSvTonTai = SV_LOPQUANLY.Any(row => row.MaSinhVien == txtMaSinhVien.Text.Trim());
                if (MaSvTonTai)
                {
                    MessageBox.Show("Đã tồn tại mã sinh viên này", "Thông Báo");
                }
                else
                {
                    try
                    {
                        //Create an object
                        SinhVien_LopQuanLy obj = new SinhVien_LopQuanLy();
                        obj.MaSinhVien = txtMaSinhVien.Text.Trim();
                        obj.MaLop = cbLopHoc.SelectedValue.ToString();
                        obj.MaChucVu = cbChucVu.SelectedValue.ToString();
                        obj.NhiemKi = txtNhiemKy.Text.Trim();

                        //Add this object to database
                        SV_LOPQUANLY = database.GetTable<SinhVien_LopQuanLy>();
                        SV_LOPQUANLY.InsertOnSubmit(obj);
                        database.SubmitChanges();

                        MessageBox.Show("Thêm thành công", "Thông Báo");
                        DisplayOnDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể thêm\nLý do: " + ex.Message, "Thông Báo");
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text;

            KHOA = database.GetTable<Khoa>();
            NGANHHOC = database.GetTable<NganhHoc>();
            LOPQUANLY = database.GetTable<LopQuanLy>();
            CHUCVU = database.GetTable<ChucVu>();
            SV_LOPQUANLY = database.GetTable<SinhVien_LopQuanLy>();

            var query = from svlop in SV_LOPQUANLY
                        join lop in LOPQUANLY on svlop.MaLop equals lop.MaLop
                        join chucvu in CHUCVU on svlop.MaChucVu equals chucvu.MaChucVu
                        join nganh in NGANHHOC on lop.MaNganh equals nganh.MaNganh
                        join khoa in KHOA on nganh.MaKhoa equals khoa.MaKhoa
                        where svlop.MaSinhVien.Contains(timkiem) ||
                              lop.TenLop.Contains(timkiem) ||
                              chucvu.TenChucVu.Contains(timkiem) ||
                              khoa.TenKhoa.Contains(timkiem) ||
                              nganh.TenNganh.Contains(timkiem) ||
                              svlop.NhiemKi.Contains(timkiem)
                        orderby svlop.SV_LQLID
                        select new
                        {
                            STT = svlop.SV_LQLID,
                            svlop.MaSinhVien,
                            TenLop = lop.TenLop,
                            TenChucVu = chucvu.TenChucVu,
                            NhiemKy = svlop.NhiemKi,
                            TenNganh = nganh.TenNganh,
                            TenKhoa = khoa.TenKhoa,
                        };

            dtgSinhVienLop.DataSource = query;
            DoBindding();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TextboxEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            else
            {
                bool MaSvTonTai = SV_LOPQUANLY.Any(row => row.MaSinhVien == txtMaSinhVien.Text.Trim());
                bool MaLopTonTai = SV_LOPQUANLY.Any(row => row.MaLop == cbLopHoc.SelectedValue.ToString().Trim());
                if (MaSvTonTai || MaLopTonTai)
                {
                    try
                    {
                        SinhVien_LopQuanLy obj = SV_LOPQUANLY.Single(row => row.MaSinhVien == txtMaSinhVien.Text.Trim());
                        obj.MaLop = cbLopHoc.SelectedValue.ToString();
                        obj.MaChucVu = cbChucVu.SelectedValue.ToString();
                        obj.NhiemKi = txtNhiemKy.Text.Trim();
                        database.SubmitChanges();

                        MessageBox.Show("Sửa thành công", "Thông Báo");
                        DisplayOnDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi không xác định: " + ex.Message, "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể thay đổi mã sinh viên hoặc mã lớp", "Thông Báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSinhVien.Text.Trim();
            DialogResult confirm = MessageBox.Show("Đồng ý xóa " + MaSV + "?", "Thông Báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                else
                {

                    bool MaSVTonTai = SV_LOPQUANLY.Any(row => row.MaSinhVien == MaSV);
                    if (MaSVTonTai)
                        try
                        {
                            SinhVien_LopQuanLy obj = SV_LOPQUANLY.Single(row => row.MaSinhVien == MaSV);
                            SV_LOPQUANLY.DeleteOnSubmit(obj);
                            database.SubmitChanges();

                            MessageBox.Show("Xóa thành công", "Thông Báo");
                            DisplayOnDataGridView();
                            ClearTextbox();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi không xác định: " + ex.Message, "Thông Báo");
                        }
                    else
                        MessageBox.Show("Mã không tồn tại", "Thông Báo");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }
    }
}

