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
    public partial class FormThongTinNopDoanPhi : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<CanBoVPDoan> CANBOVPDOAN;
        Table<ThongTinNopDoanPhi> THONGTINNOPDOANPHI;
        Table<SinhVien> SINHVIEN;

        public FormThongTinNopDoanPhi()
        {
            InitializeComponent();
            SetDefaultProperties();
            DisplayOnDataGridView();
            LoadCombobox();
            ClearTextbox();
            DoBindding();
        }

        private void SetDefaultProperties()
        {
            //throw new NotImplementedException();
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
                            thongtin.GhiNo,
                            thongtin.SoTien,
                            thongtin.NgayNop,
                            TenSinhVien = sv.HoDem + " " + sv.Ten,
                            sv.MaSinhVien,
                            CanBo = canbo.HoVaTenKhaiSinh,
                            canbo.MaCanBoDoan,
                            thongtin.NoiDung
                        };

            dtgNopDoanPhi.DataSource = query;
            DoBindding();

            //throw new NotImplementedException();
        }

        private void LoadCombobox()
        {
            LoadData_cbSinhVien();
            LoadData_cbCanBo();
            //throw new NotImplementedException();
        }

        private void LoadData_cbCanBo()
        {
            CANBOVPDOAN = database.GetTable<CanBoVPDoan>();

            var qwerty = from canbo in CANBOVPDOAN
                         select new
                         {
                             TenCanBo = canbo.HoVaTenKhaiSinh,
                             MaCanBo = canbo.MaCanBoDoan
                         };

            cbCanBo.DataSource = qwerty;
            cbCanBo.DisplayMember = "TenCanBo";
            cbCanBo.ValueMember = "MaCanBo";
            //throw new NotImplementedException();
        }

        private void LoadData_cbSinhVien()
        {
            SINHVIEN = database.GetTable<SinhVien>();

            var qwerty = from sv in SINHVIEN
                         orderby sv.MaSinhVien
                         select new
                         {
                             sv.MaSinhVien
                         };

            cbSinhVien.DataSource = qwerty;
            cbSinhVien.DisplayMember = "MaSinhVien";
            cbSinhVien.ValueMember = "MaSinhVien";
            //throw new NotImplementedException();
        }

        private void DoBindding()
        {
            cbSinhVien.DataBindings.Clear();
            cbCanBo.DataBindings.Clear();
            txtSoPhieu.DataBindings.Clear();
            txtNoiDung.DataBindings.Clear();
            dtNgayNop.DataBindings.Clear();
            txtSoTien.DataBindings.Clear();
            cbNo.DataBindings.Clear();
            

            cbSinhVien.DataBindings.Add("text", dtgNopDoanPhi.DataSource, "MaSinhVien");
            cbCanBo.DataBindings.Add("text", dtgNopDoanPhi.DataSource, "CanBo");
            txtSoPhieu.DataBindings.Add("text", dtgNopDoanPhi.DataSource, "SoPhieu");
            txtNoiDung.DataBindings.Add("text", dtgNopDoanPhi.DataSource, "NoiDung");
            dtNgayNop.DataBindings.Add("value", dtgNopDoanPhi.DataSource, "NgayNop");
            txtSoTien.DataBindings.Add("text", dtgNopDoanPhi.DataSource, "SoTien");
            cbNo.DataBindings.Add("checked", dtgNopDoanPhi.DataSource, "GhiNo");

            //throw new NotImplementedException();

        }

        private void ClearTextbox()
        {
            cbSinhVien.Text = "";
            cbCanBo.Text = "";
            txtSoPhieu.Text = "";
            cbNo.Checked = false;
            txtNoiDung.Clear();
            txtSoTien.Clear();
            txtTimKiem.Clear();
            //throw new NotImplementedException();
        }

        private bool TextboxEmpty()
        {
            if (txtNoiDung.Text.Trim() == "" || txtSoPhieu.Text.Trim() == "" ||
                txtSoTien.Text.Trim() == "" || cbCanBo.Text.Trim() == "" || 
                cbSinhVien.Text.Trim() == "")
                return true;
            else
                return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Đã tồn tại phiếu này", "Thông Báo");
                }
                else
                {
                    try
                    {
                        //Create an object
                        ThongTinNopDoanPhi obj = new ThongTinNopDoanPhi();
                        obj.SoPhieu = txtSoPhieu.Text.Trim();
                        obj.NgayNop = dtNgayNop.Value;
                        obj.SoTien = Convert.ToDecimal(txtSoTien.Text.ToString().Trim());
                        obj.NoiDung = txtNoiDung.Text.Trim();
                        obj.MaCanBoDoan = cbCanBo.SelectedValue.ToString().Trim();
                        obj.MaSinhVien = cbSinhVien.SelectedValue.ToString().Trim();
                        obj.GhiNo = cbNo.Checked ? true : false;

                        //Add this object to database
                        THONGTINNOPDOANPHI = database.GetTable<ThongTinNopDoanPhi>();
                        THONGTINNOPDOANPHI.InsertOnSubmit(obj);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                        obj.NgayNop = dtNgayNop.Value;
                        obj.SoTien = Convert.ToDecimal(txtSoTien.Text.ToString().Trim());
                        obj.NoiDung = txtNoiDung.Text.Trim();
                        obj.MaCanBoDoan = cbCanBo.SelectedValue.ToString().Trim();
                        obj.MaSinhVien = cbSinhVien.SelectedValue.ToString().Trim();
                        obj.GhiNo = cbNo.Checked ? true : false;

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
                    MessageBox.Show("Không thể thay đổi mã phiếu", "Thông Báo");
                }
            }
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
                            ClearTextbox();
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
                            thongtin.GhiNo,
                            thongtin.SoTien,
                            thongtin.NgayNop,
                            TenSinhVien = sv.HoDem + " " + sv.Ten,
                            sv.MaSinhVien,
                            CanBo = canbo.HoVaTenKhaiSinh,
                            canbo.MaCanBoDoan,
                            thongtin.NoiDung
                        };

            dtgNopDoanPhi.DataSource = query;
            DoBindding();
        }
    }
}
