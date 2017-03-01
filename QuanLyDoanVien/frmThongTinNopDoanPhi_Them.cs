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
    public partial class frmThongTinNopDoanPhi_Them : Form
    {
        frmThongTinNopDoanPhi _f;
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<CanBoVPDoan> CANBOVPDOAN;
        Table<ThongTinNopDoanPhi> THONGTINNOPDOANPHI;
        Table<SinhVien> SINHVIEN;
        Table<Khoa> KHOA;
        Table<NganhHoc> NGANHHOC;
        Table<LopQuanLy> LOPQUANLY;

        public frmThongTinNopDoanPhi_Them()
        {
            InitializeComponent();
            SetDefaultProperties();
            LoadCombobox();
            ClearTextbox();
            DoBindding();
        }
        public frmThongTinNopDoanPhi_Them(frmThongTinNopDoanPhi f)
        {
            InitializeComponent();
            _f = f;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongTinNopDoanPhi_Them_Closing);
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
                            TenSinhVien = sv.HoDem + " " + sv.Ten,
                            sv.MaSinhVien,
                            thongtin.NgayNop,
                            thongtin.SoTien,
                            CanBo = canbo.HoVaTenKhaiSinh,
                            GhiNo = thongtin.GhiNo == true ? "Có" : "Không",
                            GhiNoChk = thongtin.GhiNo,
                            thongtin.NoiDung
                        };

            dgvDanhSachSinhVien.DataSource = query;
            DoBindding();
        }
        private void DisplayOnDataGridView(string maLop)
        {
            CANBOVPDOAN = database.GetTable<CanBoVPDoan>();
            THONGTINNOPDOANPHI = database.GetTable<ThongTinNopDoanPhi>();
            SINHVIEN = database.GetTable<SinhVien>();

            var query = //from thongtin in THONGTINNOPDOANPHI
                        //join canbo in CANBOVPDOAN on thongtin.MaCanBoDoan equals canbo.MaCanBoDoan
                        from sv in SINHVIEN //on thongtin.MaSinhVien equals sv.MaSinhVien
                        where sv.MaLop == maLop //this difrence
                        orderby sv.Ten
                        select new
                        {
                            sv.MaSinhVien,
                            TenSinhVien = sv.HoDem + " " + sv.Ten,
                            sv.NgaySinh
                        };

            dgvDanhSachSinhVien.DataSource = query;
            DoBindding();
        }
        private void LoadCombobox()
        {
            LoadData_cbxKhoa();
            LoadData_cbxCanBo();

            LoadData_cbxNganh(cbxKhoa.SelectedValue.ToString());
            LoadData_cbxLop(cbxNganh.SelectedValue.ToString());
        }
        private void LoadData_cbxLop(string MaNganh)
        {
            LOPQUANLY = database.GetTable<LopQuanLy>();

            var QueryLopQL = from lop in LOPQUANLY
                             where lop.MaNganh == MaNganh
                             select new
                             {
                                 lop.MaLop,
                                 lop.TenLop
                             };

            cbxLop.DataSource = QueryLopQL;
            cbxLop.ValueMember = "MaLop";
            cbxLop.DisplayMember = "TenLop";
        }
        private void LoadData_cbxCanBo()
        {
            CANBOVPDOAN = database.GetTable<CanBoVPDoan>();

            var qwerty = from canbo in CANBOVPDOAN
                         select new
                         {
                             TenCanBo = canbo.HoVaTenKhaiSinh,
                             MaCanBo = canbo.MaCanBoDoan
                         };

            cbxCanBo.DataSource = qwerty;
            cbxCanBo.DisplayMember = "TenCanBo";
            cbxCanBo.ValueMember = "MaCanBo";
        }
        private void LoadData_cbxKhoa()
        {
            KHOA = database.GetTable<Khoa>();
            var QueryKhoa = from khoa in KHOA
                            select new
                            {
                                khoa.MaKhoa,
                                khoa.TenKhoa
                            };
            cbxKhoa.DataSource = QueryKhoa;
            cbxKhoa.DisplayMember = "TenKhoa";
            cbxKhoa.ValueMember = "MaKhoa";
        }
        private void LoadData_cbxNganh(string MaKhoa)
        {
            NGANHHOC = database.GetTable<NganhHoc>();

            var QueryNganhHoc = from nganh in NGANHHOC
                                where nganh.MaKhoa == MaKhoa
                                select new
                                {
                                    nganh.MaNganh,
                                    nganh.TenNganh
                                };

            cbxNganh.DataSource = QueryNganhHoc;
            cbxNganh.DisplayMember = "TenNganh";
            cbxNganh.ValueMember = "MaNganh";
        }
        private void ClearTextbox()
        {
            txtNoiDung.Clear();
            txtSoTien.Clear();
            cbxCanBo.Text = "";
        }
        private bool TextboxEmpty()
        {
            if (txtNoiDung.Text.Trim() == "" ||
                txtSoTien.Text.Trim() == "" || cbxCanBo.Text.Trim() == ""
                )
                return true;
            else
                return false;
        }
        private void DoBindding()
        {
            //cbxCanBo.DataBindings.Clear();
            //txtNoiDung.DataBindings.Clear();
            //dateNgayNop.DataBindings.Clear();
            //txtSoTien.DataBindings.Clear();

            //cbxCanBo.DataBindings.Add("text", dgvDanhSachSinhVien.DataSource, "CanBo");
            //txtNoiDung.DataBindings.Add("text", dgvDanhSachSinhVien.DataSource, "NoiDung");
            //dateNgayNop.DataBindings.Add("value", dgvDanhSachSinhVien.DataSource, "NgayNop");
            //txtSoTien.DataBindings.Add("text", dgvDanhSachSinhVien.DataSource, "SoTien");
        }
        private void SetDefaultProperties()
        {
            dgvDanhSachSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //throw new NotImplementedException();
        }

        private void frmThongTinNopDoanPhi_Them_Closing(object sender, FormClosingEventArgs e)
        {
            _f.dgvThongTinNopDoanPhi.Refresh();
        }

        private void chkXacNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXacNhan.Checked == true)
                btnXacNhan.Enabled = true;
            else
                btnXacNhan.Enabled = false;
        }

        private void cbxLoc_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = cbxLop.SelectedValue.ToString();
                DisplayOnDataGridView(maLop);
            }
            catch
            {
                MessageBox.Show("Xin vui lòng chọn lớp sinh viên để xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData_cbxNganh(cbxKhoa.SelectedValue.ToString());
        }

        private void cbxNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData_cbxLop(cbxNganh.SelectedValue.ToString());
        }

        private void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string timkiem = txtTimKiem.Text;
                CANBOVPDOAN = database.GetTable<CanBoVPDoan>();
                THONGTINNOPDOANPHI = database.GetTable<ThongTinNopDoanPhi>();
                SINHVIEN = database.GetTable<SinhVien>();

                var query = //from thongtin in THONGTINNOPDOANPHI
                            //join canbo in CANBOVPDOAN on thongtin.MaCanBoDoan equals canbo.MaCanBoDoan
                            from sv in SINHVIEN //on thongtin.MaSinhVien equals sv.MaSinhVien
                            where
                                (sv.HoVaTenKhaiSinh.Contains(timkiem) ||
                                sv.MaSinhVien.Contains(timkiem) ||
                                sv.NgaySinh.ToString().Contains(timkiem))
                                && sv.MaLop == cbxLop.SelectedValue.ToString()
                            orderby sv.Ten
                            select new
                            {
                                sv.MaSinhVien,
                                TenSinhVien = sv.HoDem + " " + sv.Ten,
                                sv.NgaySinh
                            };

                dgvDanhSachSinhVien.DataSource = query;
                DoBindding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xin vui lòng chọn lớp sinh viên để tìm kiếm!"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Hide();
            frmThongTinNopDoanPhi f = new frmThongTinNopDoanPhi();
            f.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //string MSVx = dgvDanhSachSinhVien.Rows[0].Cells[1].Value.ToString();
            //MessageBox.Show("Xin vui lòng chọn điền hết tất cả các trường! \n"+MSVx, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            try
            {
                if (TextboxEmpty())
                {
                    MessageBox.Show("Xin vui lòng điền hết tất cả các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    for (int i = 0; i < dgvDanhSachSinhVien.Rows.Count; i++)
                    {
                        string MSV = dgvDanhSachSinhVien.Rows[i].Cells[1].Value.ToString();
                        bool DaDongTien = Convert.ToBoolean(dgvDanhSachSinhVien.Rows[i].Cells[0].Value);

                        ThongTinNopDoanPhi obj = new ThongTinNopDoanPhi();
                        obj.MaSinhVien = MSV;
                        obj.SoPhieu = dateNgayNop.Value.Day.ToString() +
                                      dateNgayNop.Value.Month.ToString() +
                                      dateNgayNop.Value.Year.ToString() +
                                      MSV;
                        obj.SoTien = Convert.ToDecimal(txtSoTien.Text);
                        obj.NoiDung = txtNoiDung.Text;
                        obj.GhiNo = DaDongTien ? false : true;
                        obj.MaCanBoDoan = cbxCanBo.SelectedValue.ToString();
                        obj.NgayNop = dateNgayNop.Value;

                        THONGTINNOPDOANPHI = database.GetTable<ThongTinNopDoanPhi>();
                        THONGTINNOPDOANPHI.InsertOnSubmit(obj);
                        database.SubmitChanges();
                    }

                    this.Hide();
                    frmThongTinNopDoanPhi f = new frmThongTinNopDoanPhi();
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra:\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddToTHONGTINNOPDOANPHI(ThongTinNopDoanPhi obj)
        {
            throw new NotImplementedException();
        }
    }
}
