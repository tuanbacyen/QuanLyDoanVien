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
    public partial class FormChucVu : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<ChucVu> Table;

        public FormChucVu()
        {
            InitializeComponent();
            DisplayOnDataGridView();
            ClearTextbox();
            DoBindding();
        }

        #region Nonamed
        private void DoBindding()
        {
            txtMaChucVu.DataBindings.Clear();
            txtTenChucVu.DataBindings.Clear();
            txtMaChucVu.DataBindings.Add("text", dtgChucVu.DataSource, "MaChucVu");
            txtTenChucVu.DataBindings.Add("text", dtgChucVu.DataSource, "TenChucVu");
        }
        private void ClearTextbox()
        {
            txtMaChucVu.Clear();
            txtTenChucVu.Clear();
            txtTimKiem.Clear();
        }
        private void DisplayOnDataGridView()
        {
            Table = database.GetTable<ChucVu>();

            var query = from row in Table
                        orderby row.ChucVuID
                        select new
                        {
                            STT = row.ChucVuID,
                            row.MaChucVu,
                            row.TenChucVu
                        };

            //Load to Datagridview
            dtgChucVu.DataSource = query;
            DoBindding();
        }
        private bool TextboxEmpty()
        {
            if (txtMaChucVu.Text.Trim() == "" || txtTenChucVu.Text.Trim() == "")
                return true;
            else
                return false;
        }

        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            else
            {
                try
                {
                    //Create an object
                    ChucVu obj = new ChucVu();
                    obj.MaChucVu = txtMaChucVu.Text.Trim();
                    obj.TenChucVu = txtTenChucVu.Text.Trim();

                    //Add this object to database
                    Table = database.GetTable<ChucVu>();
                    Table.InsertOnSubmit(obj);
                    database.SubmitChanges();

                    //Done
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    DisplayOnDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể thêm\nLý do: " + ex.Message, "Thông Báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string str = txtMaChucVu.Text.Trim();
            if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            else
            {
                try
                {
                    ChucVu obj = Table.Single(row => row.MaChucVu == str);
                    obj.TenChucVu = txtTenChucVu.Text.Trim();
                    database.SubmitChanges();

                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    DisplayOnDataGridView();
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy khoa nào có mã " + str + " để sửa", "Thông Báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string str = txtMaChucVu.Text.Trim();
            DialogResult confirm = MessageBox.Show("Đồng ý xóa " + str + "?", "Thông Báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                else
                {
                    try
                    {
                        ChucVu obj = Table.Single(row => row.MaChucVu == str);
                        Table.DeleteOnSubmit(obj);
                        database.SubmitChanges();

                        MessageBox.Show("Xóa thành công", "Thông Báo");
                        DisplayOnDataGridView();
                        ClearTextbox();
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm thấy khoa nào có mã " + str + " để xoá", "Thông Báo");
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Table = database.GetTable<ChucVu>();

            string timkiem = txtTimKiem.Text;
            var query = from row in Table
                        where row.MaChucVu.Contains(timkiem) || row.TenChucVu.Contains(timkiem)
                        select new
                        {
                            STT = row.ChucVuID,
                            row.MaChucVu,
                            row.TenChucVu
                        };
            dtgChucVu.DataSource = query;
            DoBindding();
        }
    }
}
