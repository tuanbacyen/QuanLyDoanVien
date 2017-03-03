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
    public partial class FormLopDuBiDang : Form
    {
        QuanLyDoanVienDataContext data = new QuanLyDoanVienDataContext();
        Table<LopDuBiCamTinhDang> lopdubi;
        //Table<SinhVien> sinhvien;
        public FormLopDuBiDang()
        {
            InitializeComponent();
        }
        /*Hien thi du lieu len datagridview*/
        public void DisplayOnDataGridView()
        {
            lopdubi = data.GetTable<LopDuBiCamTinhDang>();
            /*select den bang LopDuBiCamTinhDang*/
            var query = from ld in lopdubi
                        orderby ld.id
                        select new
                        {
                            STT = ld.id,
                            ld.MaSinhVien,
                            ld.NgayHoc,
                            ld.DiaDiem,
                            ld.KetQua
                        };
            dtgLopDuBiDang.DataSource = query;
            DoBindding();
        }
        public void ClearTextbox()
        {
            cbbKetQua.SelectedIndex=0;
            txtDiaDiem.Clear();
            txtMaSinhVien.Clear();
            txtTimKiem.Clear();
        }
        public void DoBindding()
        {
            txtDiaDiem.DataBindings.Clear();
            cbbKetQua.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Clear();
            dtNgayHoc.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("text", dtgLopDuBiDang.DataSource, "MaSinhVien");
            dtNgayHoc.DataBindings.Add("text", dtgLopDuBiDang.DataSource, "NgayHoc");
            txtDiaDiem.DataBindings.Add("text", dtgLopDuBiDang.DataSource, "DiaDiem");
            cbbKetQua.DataBindings.Add("text", dtgLopDuBiDang.DataSource, "KetQua");
        }
        private void dtgLopDuBiDang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLopDuBiDang_Load(object sender, EventArgs e)
        {
            DisplayOnDataGridView();
            ClearTextbox();
            DoBindding();
        }
        /*Kiem tra xem chuoi ban dau co rong hay khong*/
        private bool TextboxEmpty()
        {
            if (txtMaSinhVien.Text.Trim() == "" || txtDiaDiem.Text.Trim() == ""|| dtNgayHoc.Text.Trim() == "")
                return true;
            else
                return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool MaTonTai=lopdubi.Any(row => row.MaSinhVien== txtMaSinhVien.Text.Trim());
            if(TextboxEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            else
            {
                if(MaTonTai)
                { MessageBox.Show("Đã tồn tại mã khoa này", "Thông Báo"); }
                else
                {

                    try
                    {        //Khoi tao mot doi tuong moi
                        LopDuBiCamTinhDang obj = new LopDuBiCamTinhDang();
                        obj.MaSinhVien = txtMaSinhVien.Text.Trim();
                        obj.NgayHoc = dtNgayHoc.Value;
                        obj.DiaDiem = txtDiaDiem.Text.Trim();
                        obj.KetQua = true;
                        if (cbbKetQua.Text == "Trượt")
                        {
                            obj.KetQua = false;
                        }

                        //Add this object to database
                        lopdubi = data.GetTable<LopDuBiCamTinhDang>();
                        lopdubi.InsertOnSubmit(obj);
                        data.SubmitChanges();

                        lopdubi = data.GetTable<LopDuBiCamTinhDang>();

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
                bool MaKhoaTonTai = lopdubi.Any(row => row.MaSinhVien == txtMaSinhVien.Text.Trim());
                if (MaKhoaTonTai)
                {
                    try
                    {
                        string MaSinhVien = txtMaSinhVien.Text.Trim();

                        LopDuBiCamTinhDang editedSinhVien = lopdubi.Single(kh => kh.MaSinhVien == MaSinhVien); //lấy ra khoa có mã như cái textbox Mã khoa kia
                        editedSinhVien.NgayHoc = dtNgayHoc.Value;
                        editedSinhVien.DiaDiem = txtDiaDiem.Text.Trim();
                        editedSinhVien.KetQua = true;
                        if (cbbKetQua.SelectedIndex == 0)
                        {
                            editedSinhVien.KetQua = false;
                        }

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
                    bool MaSinhVienTonTai = lopdubi.Any(row => row.MaSinhVien == txtMaSinhVien.Text.Trim());
                    if (MaSinhVienTonTai)
                        try
                        {
                            LopDuBiCamTinhDang deletedSinhVien = lopdubi.Single(kh => kh.MaSinhVien == MaSinhVien);
                            lopdubi.DeleteOnSubmit(deletedSinhVien);
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
            lopdubi = data.GetTable<LopDuBiCamTinhDang>();

            string timkiem = txtTimKiem.Text;
            var query = from kh in lopdubi
                        where kh.MaSinhVien.Contains(timkiem) || kh.DiaDiem.Contains(timkiem)
                        select new
                        {
                            STT = kh.id,
                            kh.MaSinhVien,
                            kh.DiaDiem,
                            kh.NgayHoc,
                            kh.KetQua
                        };
            dtgLopDuBiDang.DataSource = query;
            DoBindding();
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
            try { e.Graphics.DrawImage(GetBmp(dtgLopDuBiDang), 0, 0); }
            catch { }
        }
    }
}
