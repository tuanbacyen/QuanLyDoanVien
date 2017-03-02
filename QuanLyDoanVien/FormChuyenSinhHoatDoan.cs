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
    public partial class FormChuyenSinhHoatDoan : Form
    {
        public FormChuyenSinhHoatDoan()
        {
            InitializeComponent();
            HienThiCanBo();
            load_Data();
            load_DataLC();
            HienThiDanhSachDaChuyen();
            KhongNhap();
        }

        QuanLyDoanVienDataContext db = new QuanLyDoanVienDataContext();
        Table<CanBoVPDoan> canbovpdoans;
        Table<SinhVien> sinhviens;
        Table<Khoa> khoas;
        Table<NganhHoc> nganhhocs;
        Table<LopQuanLy> lopquanlys;
        Table<ThongTinChuyenSinhHoatDoan> thongtinchuyensinhhoats;

        private void load_Data()
        {
            HienThiCBKhoa();
            HienThiCBNganh(cbKhoa.SelectedValue.ToString());
            HienThiCBLop(cbNganh.SelectedValue.ToString());
        }

        private void HienThiCBKhoa()
        {
            khoas = db.GetTable<Khoa>();

            var GetKhoa = from kh in khoas
                          select new { kh.MaKhoa, kh.TenKhoa };
            cbKhoa.DataSource = GetKhoa;
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.DisplayMember = "TenKhoa";
        }

        private void load_DataLC()
        {
            HienThiCBKhoaLC();
            HienThiCBNganhLC(cbKhoaLC.SelectedValue.ToString());
            HienThiCBLopLC(cbNganhLC.SelectedValue.ToString());
        }

        private void HienThiCBKhoaLC()
        {
            khoas = db.GetTable<Khoa>();

            var GetKhoa = from kh in khoas
                          select new { kh.MaKhoa, kh.TenKhoa };
            cbKhoaLC.DataSource = GetKhoa;
            cbKhoaLC.ValueMember = "MaKhoa";
            cbKhoaLC.DisplayMember = "TenKhoa";
        }

        private void HienThiCBNganhLC(string maKhoa)
        {
            nganhhocs = db.GetTable<NganhHoc>();

            var GetNganh = from ngh in nganhhocs
                           where ngh.MaKhoa == maKhoa
                           select new { ngh.MaNganh, ngh.TenNganh };

            cbNganhLC.DataSource = GetNganh;
            cbNganhLC.ValueMember = "MaNganh";
            cbNganhLC.DisplayMember = "TenNganh";
        }

        private void HienThiCBLopLC(string maNganh)
        {
            lopquanlys = db.GetTable<LopQuanLy>();

            var Getlopquanly = from lql in lopquanlys
                               where lql.MaNganh == maNganh
                               select new { lql.MaLop, lql.TenLop };
            if (Getlopquanly.Count() == 0)
            {
                cbLopLC.DataSource = null;
            }
            else
            {
                cbLopLC.DataSource = Getlopquanly;
                cbLopLC.ValueMember = "MaLop";
                cbLopLC.DisplayMember = "TenLop";
            }
        }

        private void HienThiCBNganh(string maKhoa)
        {
            nganhhocs = db.GetTable<NganhHoc>();

            var GetNganh = from ngh in nganhhocs
                           where ngh.MaKhoa == maKhoa
                           select new { ngh.MaNganh, ngh.TenNganh };

            cbNganh.DataSource = GetNganh;
            cbNganh.ValueMember = "MaNganh";
            cbNganh.DisplayMember = "TenNganh";
        }

        private void HienThiCBLop(string maNganh)
        {
            lopquanlys = db.GetTable<LopQuanLy>();

            var Getlopquanly = from lql in lopquanlys
                               where lql.MaNganh == maNganh
                               select new { lql.MaLop, lql.TenLop };
            if (Getlopquanly.Count() == 0)
            {
                cbLop.DataSource = null;
            }
            else
            {
                cbLop.DataSource = Getlopquanly;
                cbLop.ValueMember = "MaLop";
                cbLop.DisplayMember = "TenLop";
            }
        }

        private void HienThiCanBo()
        {
            canbovpdoans = db.GetTable<CanBoVPDoan>();

            var GetCanBo = from cb in canbovpdoans
                           select new { cb.MaCanBoDoan, cb.HoVaTenKhaiSinh };
            cbCanBo.DataSource = GetCanBo;
            cbCanBo.DisplayMember = "HoVaTenKhaiSinh";
            cbCanBo.ValueMember = "MaCanBoDoan";
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCBNganh(cbKhoa.SelectedValue.ToString());
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCBLop(cbNganh.SelectedValue.ToString());
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Load_DataSinhVienLoc();
        }

        private void Load_DataSinhVienLoc()
        {
            try { 
            string maLop = cbLop.SelectedValue.ToString();
            sinhviens = db.GetTable<SinhVien>();
            var GetSinhVien = from sv in sinhviens
                              where sv.MaLop == maLop && sv.Xoa == false
                              select new { sv.MaSinhVien, TenSinhVien = sv.HoVaTenKhaiSinh };

            dtgSinhVien.DataSource = GetSinhVien;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Thông Báo"); }
        }

        private void btnGetDS_Click(object sender, EventArgs e)
        {
            cbDSSV.Text = "";
            cbDSSV.Items.Clear();
            DataGridView row = new DataGridView();
            for (int i = 0; i < dtgSinhVien.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgSinhVien.Rows[i].Cells[0].Value) == true)
                {
                    string item = dtgSinhVien.Rows[i].Cells[1].Value + "-" + dtgSinhVien.Rows[i].Cells[2].Value;
                    //ComboboxItem item = new ComboboxItem();
                    //item.Text = dtgSinhVien.Rows[i].Cells[2].Value + "";
                    //item.Value = dtgSinhVien.Rows[i].Cells[1].Value;
                    cbDSSV.Items.Add(item);
                }
            }
            if (cbDSSV.Items.Count > 0)
            {
                cbDSSV.SelectedIndex = 0;
            }
        }

        private void cbKhoaLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCBNganhLC(cbKhoaLC.SelectedValue.ToString());
        }

        private void cbNganhLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCBLopLC(cbNganhLC.SelectedValue.ToString());
        }

        private void HienThiDanhSachDaChuyen()
        {
            canbovpdoans = db.GetTable<CanBoVPDoan>();
            sinhviens = db.GetTable<SinhVien>();
            thongtinchuyensinhhoats = db.GetTable<ThongTinChuyenSinhHoatDoan>();

            var GetTTCSH = from csh in thongtinchuyensinhhoats
                           join cb in canbovpdoans on csh.MaCanBoDoan equals cb.MaCanBoDoan
                           join sv in sinhviens on csh.MaSinhVien equals sv.MaSinhVien
                           select new {ID=csh.id, TenDoanVien = sv.HoVaTenKhaiSinh, sv.MaSinhVien, CanBoRaQuyetDinh = cb.HoVaTenKhaiSinh, csh.NoiChuyen, csh.NgayChuyen };

            dtgSVDaChuyen.DataSource = GetTTCSH;
            Clear();
            Bindding();
        }

        private void Clear()
        {
            txtDiaChi.Clear();
            txtMaSinhVien.Clear();
            txtTimKiem.Clear();
            cbKhoaLC.SelectedItem = 0;
        }

        private void Bindding()
        {
            txtMaSinhVien.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("text", dtgSVDaChuyen.DataSource, "MaSinhVien");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", dtgSVDaChuyen.DataSource, "NoiChuyen");
            cbCanBo.DataBindings.Clear();
            cbCanBo.DataBindings.Add("text", dtgSVDaChuyen.DataSource, "CanBoRaQuyetDinh");
            dtNgayChuyen.DataBindings.Clear();
            dtNgayChuyen.DataBindings.Add("text", dtgSVDaChuyen.DataSource, "NgayChuyen");
            lblid.DataBindings.Clear();
            lblid.DataBindings.Add("text", dtgSVDaChuyen.DataSource, "ID");
            rdCT.Checked = true;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            ThemCHuyenSV();
        }

        private void rdCT_CheckedChanged(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = true;
            cbLopLC.Enabled = false;
            cbKhoaLC.Enabled = false;
            cbNganhLC.Enabled = false;
        }

        private void rdCL_CheckedChanged(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = false;
            cbLopLC.Enabled = true;
            cbKhoaLC.Enabled = true;
            cbNganhLC.Enabled = true;
        }

        private void ThemCHuyenSV()
        {
            if (rdCL.Checked)
            {
                if (cbLopLC.Text != null || cbDSSV.Items.Count == 0)
                {
                    for (int i = 0; i < cbDSSV.Items.Count; i++)
                    {
                        string masinhvien = CarChuoi(cbDSSV.Items[i].ToString()).Trim();
                        ThongTinChuyenSinhHoatDoan ttcshd = new ThongTinChuyenSinhHoatDoan();
                        ttcshd.MaSinhVien = masinhvien;
                        ttcshd.MaCanBoDoan = cbCanBo.SelectedValue.ToString();
                        ttcshd.NgayChuyen = dtNgayChuyen.Value;
                        ttcshd.NoiChuyen = cbLopLC.Text;

                        thongtinchuyensinhhoats = db.GetTable<ThongTinChuyenSinhHoatDoan>();
                        thongtinchuyensinhhoats.InsertOnSubmit(ttcshd);
                        //db.SubmitChanges();

                        SinhVien sinhvien = sinhviens.Single(sv => sv.MaSinhVien == masinhvien);
                        sinhvien.MaLop = cbLopLC.SelectedValue.ToString();
                        db.SubmitChanges();
                    }
                    MessageBox.Show("Chuyển lớp thành công " + cbDSSV.Items.Count +" sinh viên", "Thông Báo");
                    HienThiDanhSachDaChuyen();
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                }
            }else if(rdCT.Checked)
            {
                if (txtDiaChi.Text != null || cbDSSV.Items.Count == 0)
                {
                    for (int i = 0; i < cbDSSV.Items.Count; i++)
                    {
                        string masinhvien = CarChuoi(cbDSSV.Items[i].ToString()).Trim();
                        ThongTinChuyenSinhHoatDoan ttcshd = new ThongTinChuyenSinhHoatDoan();
                        ttcshd.MaSinhVien = masinhvien;
                        ttcshd.MaCanBoDoan = cbCanBo.SelectedValue.ToString();
                        ttcshd.NgayChuyen = dtNgayChuyen.Value;
                        ttcshd.NoiChuyen = txtDiaChi.Text;
                        ttcshd.ChuyenTruong = true;
                        thongtinchuyensinhhoats = db.GetTable<ThongTinChuyenSinhHoatDoan>();
                        thongtinchuyensinhhoats.InsertOnSubmit(ttcshd);
                        //db.SubmitChanges();

                        SinhVien sinhvien = sinhviens.Single(sv => sv.MaSinhVien == masinhvien);
                        sinhvien.Xoa = true;
                        db.SubmitChanges();
                    }
                    MessageBox.Show("Chuyển trường thành công " + cbDSSV.Items.Count + " sinh viên", "Thông Báo");
                    HienThiDanhSachDaChuyen();
                    Load_DataSinhVienLoc();
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                }
            }
        }

        private string CarChuoi(string a)
        {
            string temp = a.Substring(0, a.IndexOf("-"));
            return temp;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try { 
            if (txtDiaChi.Text != null || cbDSSV.Items.Count == 0)
            {
                ThongTinChuyenSinhHoatDoan ttcshd = thongtinchuyensinhhoats.Single(chs=>chs.id == Convert.ToInt32(lblid.Text.Trim()));
                ttcshd.MaCanBoDoan = cbCanBo.SelectedValue.ToString();
                ttcshd.NgayChuyen = dtNgayChuyen.Value;
                ttcshd.NoiChuyen = txtDiaChi.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công", "Thông Báo");
                HienThiDanhSachDaChuyen();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Thông Báo"); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ThongTinChuyenSinhHoatDoan ttcshd = thongtinchuyensinhhoats.Single(chs => chs.id == Convert.ToInt32(lblid.Text.Trim()));
                thongtinchuyensinhhoats.DeleteOnSubmit(ttcshd);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công", "Thông Báo");
                HienThiDanhSachDaChuyen();
            
            }catch (Exception ex) { MessageBox.Show("Error: "+ex.Message, "Thông Báo"); }
}

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            canbovpdoans = db.GetTable<CanBoVPDoan>();
            sinhviens = db.GetTable<SinhVien>();
            thongtinchuyensinhhoats = db.GetTable<ThongTinChuyenSinhHoatDoan>();
            string search = txtTimKiem.Text;
            var GetTTCSH = from csh in thongtinchuyensinhhoats
                           join cb in canbovpdoans on csh.MaCanBoDoan equals cb.MaCanBoDoan
                           join sv in sinhviens on csh.MaSinhVien equals sv.MaSinhVien
                           where sv.HoVaTenKhaiSinh.Contains(search) || sv.MaSinhVien.Contains(search) && sv.Xoa == false
                           select new { ID = csh.id, TenDoanVien = sv.HoVaTenKhaiSinh, sv.MaSinhVien, CanBoRaQuyetDinh = cb.HoVaTenKhaiSinh, csh.NoiChuyen, csh.NgayChuyen };

            dtgSVDaChuyen.DataSource = GetTTCSH;
        }

        private void KhongNhap()
        {
            cbKhoa.KeyPress += DontInput;
            cbLop.KeyPress += DontInput;
            cbLopLC.KeyPress += DontInput;
            cbNganh.KeyPress += DontInput;
            cbNganhLC.KeyPress += DontInput;
            cbKhoaLC.KeyPress += DontInput;
            cbCanBo.KeyPress += DontInput;
            cbDSSV.KeyPress += DontInput;
        }

        private void DontInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
