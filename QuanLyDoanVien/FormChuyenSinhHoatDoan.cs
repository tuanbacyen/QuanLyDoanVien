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
            string maLop = cbLop.SelectedValue.ToString();
            sinhviens = db.GetTable<SinhVien>();
            var GetSinhVien = from sv in sinhviens
                              where sv.MaLop == maLop
                              select new { sv.MaSinhVien, TenSinhVien = sv.HoVaTenKhaiSinh };

            dtgSinhVien.DataSource = GetSinhVien;
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
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dtgSinhVien.Rows[i].Cells[2].Value + "";
                    item.Value = dtgSinhVien.Rows[i].Cells[1].Value;
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

        private void cbLopLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiaChi.Text = cbLopLC.Text + " - " + cbLopLC.SelectedValue.ToString();
        }

        private void HienThiDanhSachDaChuyen()
        {
            canbovpdoans = db.GetTable<CanBoVPDoan>();
            sinhviens = db.GetTable<SinhVien>();
            thongtinchuyensinhhoats = db.GetTable<ThongTinChuyenSinhHoatDoan>();

            var GetTTCSH = from csh in thongtinchuyensinhhoats
                           join cb in canbovpdoans on csh.MaCanBoDoan equals cb.MaCanBoDoan
                           join sv in sinhviens on csh.MaSinhVien equals sv.MaSinhVien
                           select new { TenDoanVien = sv.HoVaTenKhaiSinh, sv.MaSinhVien, CanBoRaQuyetDinh = cb.HoVaTenKhaiSinh, csh.NoiChuyen, csh.NgayChuyen };

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
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != null || cbDSSV.Items.Count == 0)
            {
                for(int i = 0; i < cbDSSV.Items.Count; i++)
                {
                    ThongTinChuyenSinhHoatDoan ttcshd = new ThongTinChuyenSinhHoatDoan();
                    ttcshd.MaSinhVien = cbDSSV.SelectedValue.ToString();
                    ttcshd.MaCanBoDoan = cbCanBo.SelectedValue.ToString();
                    ttcshd.NgayChuyen = dtNgayChuyen.Value;
                    ttcshd.NoiChuyen = txtDiaChi.Text;
                    // đang làm giở
                    //sodoanviens = db.GetTable<SoDoanVien>();
                    //sodoanviens.InsertOnSubmit(sodoanvien);
                    //db.SubmitChanges();
                    //MessageBox.Show("Thêm thành công", "Thông Báo");
                    //Load_DataSoDoan();
                }
                
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
            }
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
