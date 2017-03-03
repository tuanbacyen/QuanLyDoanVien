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
    public partial class FormKhoa : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<Khoa> Table;
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            DisplayOnDataGridView();
            ClearTextbox();
            DoBindding();
        }

        #region Nonamed
        private void DoBindding()
        {
            txtMaKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("text", dtgKhoa.DataSource, "MaKhoa");
            txtTenKhoa.DataBindings.Add("text", dtgKhoa.DataSource, "TenKhoa");
        }
        private void ClearTextbox()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTimKiem.Clear();
        }
        private void DisplayOnDataGridView()
        {
            Table = database.GetTable<Khoa>();

            //SELECT * FROM KHOA;
            var query = from kh in Table
                        orderby kh.KhoaID
                        select new {
                            STT = kh.KhoaID,
                            kh.MaKhoa,
                            kh.TenKhoa
                        };

            //Load to Datagridview
            dtgKhoa.DataSource = query;
            DoBindding();
        }
        private bool TextboxEmpty()
        {
            if (txtMaKhoa.Text.Trim() == "" || txtTenKhoa.Text.Trim() == "")
                return true;
            else
                return false;
        }
        #endregion

        #region Button
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool MaKhoaTonTai = Table.Any(row => row.MaKhoa == txtMaKhoa.Text.Trim());

            if (TextboxEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            else
            {
                if (MaKhoaTonTai)
                {
                    MessageBox.Show("Đã tồn tại mã khoa này", "Thông Báo");
                }
                else
                {
                    try
                    {
                        //Create an object
                        Khoa obj = new Khoa();
                        obj.MaKhoa = txtMaKhoa.Text.Trim();
                        obj.TenKhoa = txtTenKhoa.Text.Trim();

                        //Add this object to database
                        Table = database.GetTable<Khoa>();
                        Table.InsertOnSubmit(obj);
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
                bool MaKhoaTonTai = Table.Any(row => row.MaKhoa == txtMaKhoa.Text.Trim());
                if (MaKhoaTonTai)
                {
                    try
                    {
                        string MaKhoa = txtMaKhoa.Text.Trim();
                                                     //khai bao
                        Khoa editedKhoa = Table.Single(kh => kh.MaKhoa == MaKhoa); //lấy ra khoa có mã như cái textbox Mã khoa kia
                        editedKhoa.TenKhoa = txtTenKhoa.Text.Trim();
                        database.SubmitChanges();

                        MessageBox.Show("Sửa thành công", "Thông Báo");
                        DisplayOnDataGridView();
                    }
                    catch (Exception ex)
                    {
                        string MaKhoa = txtMaKhoa.Text.Trim();
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
            string MaKhoa = txtMaKhoa.Text.Trim();
            DialogResult confirm = MessageBox.Show("Đồng ý xóa " + MaKhoa + "?", "Thông Báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                else
                {
                    bool MaKhoaTonTai = Table.Any(row => row.MaKhoa == txtMaKhoa.Text.Trim());
                    if (MaKhoaTonTai)
                        try
                        {
                            Khoa deletedKhoa = Table.Single(kh => kh.MaKhoa == MaKhoa);
                            Table.DeleteOnSubmit(deletedKhoa);
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
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Table = database.GetTable<Khoa>();
            
            string timkiem = txtTimKiem.Text;
            var query = from kh in Table
                        where kh.MaKhoa.Contains(timkiem) || kh.TenKhoa.Contains(timkiem)
                        select new
                        {
                            STT = kh.KhoaID,
                            kh.MaKhoa,
                            kh.TenKhoa
                        };
            dtgKhoa.DataSource = query;
            DoBindding();
        }
        #endregion

        private void dtgKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            try { e.Graphics.DrawImage(GetBmp(dtgKhoa), 0, 0); }
            catch { }
        }
    }
}
