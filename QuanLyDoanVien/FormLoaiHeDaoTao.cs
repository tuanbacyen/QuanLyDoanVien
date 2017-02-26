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
    public partial class FormLoaiHeDaoTao : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<LoaiHeDaoTao> Table;

        public FormLoaiHeDaoTao()
        {
            InitializeComponent();
            DisplayOnDataGridView();
            ClearTextbox();
            DoBindding();
        }

        #region Nonamed
        private void DoBindding()
        {
            txtMaHeDaoTao.DataBindings.Clear();
            txtTenHeDaoTao.DataBindings.Clear();
            txtMaHeDaoTao.DataBindings.Add("text", dtgHeDaoTao.DataSource, "MaHeDaoTao");
            txtTenHeDaoTao.DataBindings.Add("text", dtgHeDaoTao.DataSource, "TenHeDaoTao");
        }
        private void ClearTextbox()
        {
            txtMaHeDaoTao.Clear();
            txtTenHeDaoTao.Clear();
            txtTimKiem.Clear();
        }
        private void DisplayOnDataGridView()
        {
            Table = database.GetTable<LoaiHeDaoTao>();

            var query = from row in Table
                        orderby row.LoaiHeDaoTaoID
                        select new
                        {
                            STT = row.LoaiHeDaoTaoID,
                            row.MaHeDaoTao,
                            row.TenHeDaoTao
                        };

            //Load to Datagridview
            dtgHeDaoTao.DataSource = query;
            DoBindding();
        }
        private bool TextboxEmpty()
        {
            if (txtMaHeDaoTao.Text.Trim() == "" || txtTenHeDaoTao.Text.Trim() == "")
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
                    LoaiHeDaoTao heMoi = new LoaiHeDaoTao();
                    heMoi.MaHeDaoTao = txtMaHeDaoTao.Text.Trim();
                    heMoi.TenHeDaoTao = txtTenHeDaoTao.Text.Trim();

                    //Add this object to database
                    Table = database.GetTable<LoaiHeDaoTao>();
                    Table.InsertOnSubmit(heMoi);
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
            string MaHe = txtMaHeDaoTao.Text.Trim();
            if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            else
            {
                try
                {
                    LoaiHeDaoTao editedHe = Table.Single(row => row.MaHeDaoTao == MaHe); 
                    editedHe.TenHeDaoTao = txtTenHeDaoTao.Text.Trim();
                    database.SubmitChanges();

                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    DisplayOnDataGridView();
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy khoa nào có mã " + MaHe + " để sửa", "Thông Báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaHe = txtMaHeDaoTao.Text.Trim(); 
            DialogResult confirm = MessageBox.Show("Đồng ý xóa " + MaHe + "?", "Thông Báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                else
                {
                    try
                    {
                        LoaiHeDaoTao deletedHe = Table.Single(row => row.MaHeDaoTao == MaHe);
                        Table.DeleteOnSubmit(deletedHe);
                        database.SubmitChanges();

                        MessageBox.Show("Xóa thành công", "Thông Báo");
                        DisplayOnDataGridView();
                        ClearTextbox();
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm thấy khoa nào có mã " + MaHe + " để xoá", "Thông Báo");
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
            Table = database.GetTable<LoaiHeDaoTao>();

            string timkiem = txtTimKiem.Text;
            var query = from row in Table
                        where row.MaHeDaoTao.Contains(timkiem) || row.TenHeDaoTao.Contains(timkiem)
                        select new
                        {
                            STT = row.LoaiHeDaoTaoID,
                            row.MaHeDaoTao,
                            row.TenHeDaoTao
                        };
            dtgHeDaoTao.DataSource = query;
            DoBindding();
        }
    }
}
