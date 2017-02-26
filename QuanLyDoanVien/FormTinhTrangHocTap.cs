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
    public partial class FormTinhTrangHocTap : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<TinhTrangHocTap> Table;

        public FormTinhTrangHocTap()
        {
            InitializeComponent();
            DisplayOnDataGridView();
            ClearTextbox();
            DoBindding();
        }

        #region Nonamed
        private void DoBindding()
        {
            txtMaTinhTrang.DataBindings.Clear();
            txtTenTinhTrang.DataBindings.Clear();
            txtMaTinhTrang.DataBindings.Add("text", dtgTinhTrang.DataSource, "MaTinhTrangHocTap");
            txtTenTinhTrang.DataBindings.Add("text", dtgTinhTrang.DataSource, "TenTinhTrangHocTap");
        }
        private void ClearTextbox()
        {
            txtMaTinhTrang.Clear();
            txtTenTinhTrang.Clear();
            txtTimKiem.Clear();
        }
        private void DisplayOnDataGridView()
        {
            Table = database.GetTable<TinhTrangHocTap>();

            var query = from row in Table
                        orderby row.TinhTrangHocTapID
                        select new
                        {
                            STT = row.TinhTrangHocTapID,
                            row.MaTinhTrangHocTap,
                            row.TenTinhTrangHocTap
                        };

            //Load to Datagridview
            dtgTinhTrang.DataSource = query;
            DoBindding();
        }
        private bool TextboxEmpty()
        {
            if (txtMaTinhTrang.Text.Trim() == "" || txtTenTinhTrang.Text.Trim() == "")
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
                    TinhTrangHocTap obj = new TinhTrangHocTap();
                    obj.MaTinhTrangHocTap = txtMaTinhTrang.Text.Trim();
                    obj.TenTinhTrangHocTap = txtTenTinhTrang.Text.Trim();

                    //Add this object to database
                    Table = database.GetTable<TinhTrangHocTap>();
                    Table.InsertOnSubmit(obj);
                    database.SubmitChanges();

                    //Done
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    DisplayOnDataGridView();
                } catch (Exception ex)
                {
                    MessageBox.Show("Không thể thêm\nLý do: " + ex.Message, "Thông Báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string str = txtMaTinhTrang.Text.Trim();
            if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            else
            {
                try
                {
                    TinhTrangHocTap obj = Table.Single(row => row.MaTinhTrangHocTap == str);
                    obj.TenTinhTrangHocTap = txtTenTinhTrang.Text.Trim();
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
            string str = txtMaTinhTrang.Text.Trim();
            DialogResult confirm = MessageBox.Show("Đồng ý xóa " + str + "?", "Thông Báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                else
                {
                    try
                    {
                        TinhTrangHocTap deletedHe = Table.Single(row => row.MaTinhTrangHocTap == str);
                        Table.DeleteOnSubmit(deletedHe);
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
            Table = database.GetTable<TinhTrangHocTap>();

            string timkiem = txtTimKiem.Text;
            var query = from row in Table
                        where row.MaTinhTrangHocTap.Contains(timkiem) || row.TenTinhTrangHocTap.Contains(timkiem)
                        select new
                        {
                            STT = row.TinhTrangHocTapID,
                            row.MaTinhTrangHocTap,
                            row.TenTinhTrangHocTap
                        };
            dtgTinhTrang.DataSource = query;
            DoBindding();
        }
    }
}
