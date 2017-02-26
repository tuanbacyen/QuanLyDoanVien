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
    public partial class FormHoatDongDoan : Form
    {
        QuanLyDoanVienDataContext data = new QuanLyDoanVienDataContext();
        Table<ThongTinHoatDongDoan> thongtin;
        Table<CanBoVPDoan> canbo;
        
        public FormHoatDongDoan()
        {
            InitializeComponent();
        }
        /*Hien thi len cbb*/

        private void HienThiCBDoan()
        {
            canbo = data.GetTable<CanBoVPDoan>();

            var GetKhoa = from kh in canbo
                          select new { kh.MaCanBoDoan };
            cbCanBo.DataSource = GetKhoa;
            cbCanBo.ValueMember = "MaCanBoDoan";
           
        }
        /*Hien thi du lieu len datagridview*/
        public void DisplayOnDataGridView()
        {
            thongtin = data.GetTable<ThongTinHoatDongDoan>();
            /*select den bang LopDuBiCamTinhDang*/
            var query = from ld in thongtin
                        orderby ld.id
                        select new
                        {
                            STT = ld.id,
                            ld.MaSinhVien,
                            ld.MaCanBoDoan,
                            ld.TenHoatDong,
                            ld.DiaDiem,
                            ld.ThoiGianBatDau,
                            ld.ThoiGianKetThuc
                        };
            dtgHoatDongDoan.DataSource = query;
            DoBindding();
        }
        public void ClearTextbox()
        {
            txtDiaDiem.Clear();
            txtMaSinhVien.Clear();
            txtTieuDe.Clear();
            txtTimKiem.Clear();
        }
        public void DoBindding()
        {
            txtDiaDiem.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Clear();
            txtTieuDe.DataBindings.Clear();
            dtNgayBatDau.DataBindings.Clear();
            dtNgayKetThuc.DataBindings.Clear();
            cbCanBo.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("text", dtgHoatDongDoan.DataSource, "MaSinhVien");
            cbCanBo.DataBindings.Add("text", dtgHoatDongDoan.DataSource, "MaCanBoDoan");
            txtTieuDe.DataBindings.Add("text", dtgHoatDongDoan.DataSource, "TenHoatDong");
            txtDiaDiem.DataBindings.Add("text", dtgHoatDongDoan.DataSource, "DiaDiem");
            dtNgayBatDau.DataBindings.Add("text", dtgHoatDongDoan.DataSource, "ThoiGianBatDau");
            dtNgayKetThuc.DataBindings.Add("text", dtgHoatDongDoan.DataSource, "ThoiGianKetThuc");
        }
        private void FormHoatDongDoan_Load(object sender, EventArgs e)
        {
            DisplayOnDataGridView();
            HienThiCBDoan();
            ClearTextbox();
            DoBindding();

        }
        private bool TextboxEmpty()
        {
            if (txtMaSinhVien.Text.Trim() == "" || txtDiaDiem.Text.Trim() == "" || txtTieuDe.Text.Trim() == "" || cbCanBo.Text.Trim() == "" || dtNgayBatDau.Text.Trim() == "" || dtNgayKetThuc.Text.Trim() == "")
                return true;
            else
                return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool MaTonTai = thongtin.Any(row => row.MaSinhVien == txtMaSinhVien.Text.Trim());
            if (TextboxEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            else
            {
                if (MaTonTai)
                { MessageBox.Show("Đã tồn tại mã sinh viên này", "Thông Báo"); }
                else
                {

                    try
                    {        //Khoi tao mot doi tuong moi
                        ThongTinHoatDongDoan obj = new ThongTinHoatDongDoan();
                        obj.MaSinhVien = txtMaSinhVien.Text.Trim();
                        obj.MaCanBoDoan = cbCanBo.SelectedValue.ToString();
                        obj.TenHoatDong = txtTieuDe.Text.Trim();
                        obj.DiaDiem = txtDiaDiem.Text.Trim();
                        obj.ThoiGianBatDau = dtNgayBatDau.Value;
                        obj.ThoiGianKetThuc = dtNgayKetThuc.Value;

                        //Add this object to database
                        thongtin = data.GetTable<ThongTinHoatDongDoan>();
                        thongtin.InsertOnSubmit(obj);
                        data.SubmitChanges();

                        thongtin = data.GetTable<ThongTinHoatDongDoan>();

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TextboxEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            else
            {
                bool MaSVTonTai = thongtin.Any(row => row.MaSinhVien == txtMaSinhVien.Text.Trim());
                if (MaSVTonTai)
                {
                    try
                    {
                        string MaSinhVien = txtMaSinhVien.Text.Trim();

                        ThongTinHoatDongDoan editedSinhVien = thongtin.Single(kh => kh.MaSinhVien == MaSinhVien); //lấy ra khoa có mã như cái textbox Mã khoa kia
                        editedSinhVien.ThoiGianBatDau = dtNgayBatDau.Value;
                        editedSinhVien.ThoiGianKetThuc = dtNgayKetThuc.Value;

                        editedSinhVien.DiaDiem = txtDiaDiem.Text.Trim();
                        editedSinhVien.TenHoatDong = txtTieuDe.Text.Trim();
                        editedSinhVien.MaCanBoDoan = cbCanBo.Text;


                        data.SubmitChanges();

                        MessageBox.Show("Sửa thành công", "Thông Báo");
                        DisplayOnDataGridView();
                    }
                    catch (Exception ex)
                    {
                        string MaSinhVien = txtMaSinhVien.Text.Trim();
                        MessageBox.Show("Lỗi không xác định: " + ex.Message, "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể sửa mã", "Thông Báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSinhVien = txtMaSinhVien.Text.Trim();
            DialogResult confirm = MessageBox.Show("Đồng ý xóa " + MaSinhVien + "?", "Thông Báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                else
                {
                    bool MaSinhVienTonTai = thongtin.Any(row => row.MaSinhVien == txtMaSinhVien.Text.Trim());
                    if (MaSinhVienTonTai)
                        try
                        {
                            ThongTinHoatDongDoan deletedSinhVien = thongtin.Single(kh => kh.MaSinhVien == MaSinhVien);
                            thongtin.DeleteOnSubmit(deletedSinhVien);
                            data.SubmitChanges();

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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            thongtin = data.GetTable<ThongTinHoatDongDoan>();

            string timkiem = txtTimKiem.Text;
            var query = from kh in thongtin
                        where kh.MaSinhVien.Contains(timkiem) || kh.DiaDiem.Contains(timkiem)||kh.MaCanBoDoan.Contains(timkiem)
                        select new
                        {
                            STT = kh.id,
                            kh.MaSinhVien,
                            kh.DiaDiem,
                            kh.ThoiGianBatDau,
                            kh.ThoiGianKetThuc,
                            kh.MaCanBoDoan,
                            kh.TenHoatDong
                        };
            dtgHoatDongDoan.DataSource = query;
            DoBindding();
        }
    }
}
