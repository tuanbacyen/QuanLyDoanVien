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
        Table<Khoa> khoas;

        public FormKhoa()
        {
            InitializeComponent();
        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            DisplayOnDataGridView();
            ClearTextbox();
            DoBinding();
        }

        #region Nonamed
        private void DoBinding()
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
            khoas = database.GetTable<Khoa>();

            //SELECT * FROM KHOA;
            var query = from kh in khoas
                        orderby kh.KhoaID
                        select new {
                            STT = kh.KhoaID,
                            kh.MaKhoa,
                            kh.TenKhoa
                        };

            //Load to Datagridview
            dtgKhoa.DataSource = query;
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
            if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            else
            {
                //Create an object
                Khoa khoaMoi = new Khoa();
                khoaMoi.MaKhoa = txtMaKhoa.Text.Trim();
                khoaMoi.TenKhoa = txtTenKhoa.Text.Trim();

                //Add this object to database
                khoas = database.GetTable<Khoa>();
                khoas.InsertOnSubmit(khoaMoi);
                database.SubmitChanges();

                //Done
                MessageBox.Show("Thêm thành công", "Thông Báo");
                DisplayOnDataGridView();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            else
            {
                try
                {
                    string MaKhoa = txtMaKhoa.Text.Trim();

                    Khoa editedKhoa = khoas.Single(kh => kh.MaKhoa == MaKhoa); //lấy ra khoa có mã như cái textbox Mã khoa kia
                    editedKhoa.TenKhoa = txtTenKhoa.Text.Trim();
                    database.SubmitChanges();

                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    DisplayOnDataGridView();
                }
                catch
                {
                    string MaKhoa = txtMaKhoa.Text.Trim();
                    MessageBox.Show("Không tìm thấy khoa nào có mã " + MaKhoa +" để sửa", "Thông Báo");
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
                    try
                    {
                        Khoa deletedKhoa = khoas.Single(kh => kh.MaKhoa == MaKhoa); //lấy ra khoa có mã như cái textbox Mã khoa kia
                        khoas.DeleteOnSubmit(deletedKhoa);
                        database.SubmitChanges();

                        MessageBox.Show("Xóa thành công", "Thông Báo");
                        DisplayOnDataGridView();
                        ClearTextbox();
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm thấy khoa nào có mã " + MaKhoa + " để xoá", "Thông Báo");
                    }
                }
            }
        }
        #endregion
    }
}
