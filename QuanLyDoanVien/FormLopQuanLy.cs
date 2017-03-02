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
    public partial class FormLopQuanLy : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<LopQuanLy> LOPQUANLY;
        Table<NganhHoc> NGANHHOC;
        Table<LoaiHeDaoTao> LOAIHEDAOTAO;

        public FormLopQuanLy()
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
            NGANHHOC = database.GetTable<NganhHoc>();
            LOAIHEDAOTAO = database.GetTable<LoaiHeDaoTao>();

            var QueryNganhHoc = from nganh in NGANHHOC
                                select new
                                {
                                    nganh.MaNganh,
                                    nganh.TenNganh
                                };
            var QueryHeDaoTao = from he in LOAIHEDAOTAO
                                select new
                                {
                                    he.TenHeDaoTao,
                                    he.MaHeDaoTao
                                };

            cbHeDaoTao.DataSource = QueryHeDaoTao;
            cbHeDaoTao.DisplayMember = "TenHeDaoTao";
            cbHeDaoTao.ValueMember = "MaHeDaoTao";

            cbNganh.DataSource = QueryNganhHoc;
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "MaNganh";

        }
        private void DoBindding()
        {
            txtMaLop.DataBindings.Clear();
            txtTenLop.DataBindings.Clear();

            cbHeDaoTao.DataBindings.Clear();
            cbNganh.DataBindings.Clear();

            nbrKhoaHoc.DataBindings.Clear();
            nbrSiSo.DataBindings.Clear();

            txtMaLop.DataBindings.Add("text", dtgLopQuanLy.DataSource, "MaLop");
            txtTenLop.DataBindings.Add("text", dtgLopQuanLy.DataSource, "TenLop");

            cbHeDaoTao.DataBindings.Add("text", dtgLopQuanLy.DataSource, "HeDaoTao");
            cbNganh.DataBindings.Add("text", dtgLopQuanLy.DataSource, "Nganh");

            nbrKhoaHoc.DataBindings.Add("text", dtgLopQuanLy.DataSource, "KhoaHoc");
            nbrSiSo.DataBindings.Add("text", dtgLopQuanLy.DataSource, "SiSo");
        }
        private void ClearTextbox()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtTimKiem.Clear();

            cbHeDaoTao.SelectedIndex = 0;
            cbNganh.SelectedIndex = 0;

            nbrKhoaHoc.Value = 0;
            nbrSiSo.Value = 0;
        }
        private void DisplayOnDataGridView()
        {
            LOPQUANLY = database.GetTable<LopQuanLy>();
            NGANHHOC = database.GetTable<NganhHoc>();
            LOAIHEDAOTAO = database.GetTable<LoaiHeDaoTao>();

            var query = from lop in LOPQUANLY
                        join nganh in NGANHHOC on lop.MaNganh equals nganh.MaNganh
                        join he in LOAIHEDAOTAO on lop.MaHeDaoTao equals he.MaHeDaoTao
                        orderby lop.LopQuanLyID
                        select new
                        {
                            STT = lop.LopQuanLyID,
                            lop.MaLop,
                            lop.TenLop,
                            Nganh = nganh.TenNganh,
                            HeDaoTao = he.TenHeDaoTao,
                            lop.KhoaHoc,
                            lop.SiSo
                        };

            //Load to Datagridview
            dtgLopQuanLy.DataSource = query;
            DoBindding();
        }
        private bool TextboxEmpty()
        {
            if (txtMaLop.Text.Trim() == "" || txtTenLop.Text.Trim() == "")
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
                bool MaLopTonTai = LOPQUANLY.Any(row => row.MaLop == txtMaLop.Text.Trim());
                if (MaLopTonTai)
                {
                    MessageBox.Show("Đã tồn tại mã lớp này", "Thông Báo");
                }
                else
                {
                    try
                    {
                        //Create an object
                        LopQuanLy obj = new LopQuanLy();
                        obj.MaLop = txtMaLop.Text.Trim();
                        obj.TenLop = txtTenLop.Text.Trim();
                        obj.MaNganh = cbNganh.SelectedValue.ToString();
                        obj.MaHeDaoTao = cbHeDaoTao.SelectedValue.ToString();
                        obj.SiSo = Convert.ToByte(nbrSiSo.Value);
                        obj.KhoaHoc = Convert.ToByte(nbrKhoaHoc.Value);

                        //Add this object to database
                        LOPQUANLY = database.GetTable<LopQuanLy>();
                        LOPQUANLY.InsertOnSubmit(obj);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TextboxEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            else
            {
                bool MaLopTonTai = LOPQUANLY.Any(row => row.MaLop == txtMaLop.Text.Trim());
                if (MaLopTonTai)
                {
                    try
                    {
                        string MaLop = txtMaLop.Text.Trim();

                        LopQuanLy obj = LOPQUANLY.Single(row => row.MaLop == MaLop);
                        obj.TenLop = txtTenLop.Text.Trim();
                        obj.MaNganh = cbNganh.SelectedValue.ToString();
                        obj.MaHeDaoTao = cbHeDaoTao.SelectedValue.ToString();
                        obj.SiSo = Convert.ToByte(nbrSiSo.Value);
                        obj.KhoaHoc = Convert.ToByte(nbrKhoaHoc.Value);
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
                    MessageBox.Show("Không thể thay đổi mã lớp", "Thông Báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text.Trim();
            DialogResult confirm = MessageBox.Show("Đồng ý xóa " + MaLop + "?", "Thông Báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (TextboxEmpty()) MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                else
                {
                    bool MaLopTonTai = LOPQUANLY.Any(row => row.MaLop == txtMaLop.Text.Trim());
                    if (MaLopTonTai)
                        try
                        {
                            LopQuanLy obj = LOPQUANLY.Single(row => row.MaLop == MaLop);
                            LOPQUANLY.DeleteOnSubmit(obj);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LOPQUANLY = database.GetTable<LopQuanLy>();

            string timkiem = txtTimKiem.Text;

            var query = from lop in LOPQUANLY
                        join nganh in NGANHHOC on lop.MaNganh equals nganh.MaNganh
                        join he in LOAIHEDAOTAO on lop.MaHeDaoTao equals he.MaHeDaoTao
                        where lop.TenLop.Contains(timkiem) ||
                              lop.MaLop.Contains(timkiem) ||
                              lop.MaNganh.Contains(timkiem) ||
                              lop.MaHeDaoTao.Contains(timkiem) ||
                              nganh.TenNganh.Contains(timkiem) ||
                              he.TenHeDaoTao.Contains(timkiem)
                        orderby lop.LopQuanLyID
                        select new
                        {
                            STT = lop.LopQuanLyID,
                            lop.MaLop,
                            lop.TenLop,
                            Nganh = nganh.TenNganh,
                            HeDaoTao = he.TenHeDaoTao,
                            lop.KhoaHoc,
                            lop.SiSo
                        };

            dtgLopQuanLy.DataSource = query;
            DoBindding();
        }
    }
}
