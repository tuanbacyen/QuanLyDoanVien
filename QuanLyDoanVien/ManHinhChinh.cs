using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanVien
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnConnect_Click(object sender, EventArgs e)
        {
            FormConnect fmConnect = new FormConnect();
            //fmConnect.MdiParent = this;
            fmConnect.Show();
        }

        private void mnUpdateNganh_Click(object sender, EventArgs e)
        {
            FormNganhHoc frm = new FormNganhHoc();
            frm.Show();
        }

        private void mnLogin_Click(object sender, EventArgs e)
        {
            FormDangNhap frm = new FormDangNhap();
            //fmConnect.MdiParent = this;
            frm.Show();
        }

        private void cậpNhậtThôngTinKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhoa frm = new FormKhoa();
            frm.Show();
        }

        private void mnUpdateLop_Click(object sender, EventArgs e)
        {
            FormLopQuanLy frm = new FormLopQuanLy();
            frm.Show();
        }

        private void mnChucVu_Click(object sender, EventArgs e)
        {
            FormChucVu frm = new FormChucVu();
            frm.Show();
        }

        private void mnSVLop_Click(object sender, EventArgs e)
        {
            FormSinhVienLopQuanLy frm = new FormSinhVienLopQuanLy();
            frm.Show();
        }

        private void mnLoaiHeDaoTao_Click(object sender, EventArgs e)
        {
            FormLoaiHeDaoTao frm = new FormLoaiHeDaoTao();
            frm.Show();
        }

        private void mnTinhTrangHocTap_Click(object sender, EventArgs e)
        {
            FormTinhTrangHocTap frm = new FormTinhTrangHocTap();
            frm.Show();
        }

        private void mnUpdateCB_Click(object sender, EventArgs e)
        {
            FormCanBoVanPhongDoan frm = new FormCanBoVanPhongDoan();
            frm.Show();
        }

        private void mnUpdateSV_Click(object sender, EventArgs e)
        {
            FormSinhVien frm = new FormSinhVien();
            frm.Show();
        }

        private void mnUpdateSD_Click(object sender, EventArgs e)
        {
            FormSoDoanVien frm = new FormSoDoanVien();
            frm.Show();
        }

        private void mnUpdateDP_Click(object sender, EventArgs e)
        {
            FormThongTinNopDoanPhi frm = new FormThongTinNopDoanPhi();
            frm.Show();
        }

        private void mnUpdateHDD_Click(object sender, EventArgs e)
        {
            FormHoatDongDoan frm = new FormHoatDongDoan();
            frm.Show();
        }

        private void mnUpdateCSHD_Click(object sender, EventArgs e)
        {
            FormChuyenSinhHoatDoan frm = new FormChuyenSinhHoatDoan();
            frm.Show();
        }

        private void mnDuBiDang_Click(object sender, EventArgs e)
        {
            FormLopDuBiDang frm = new FormLopDuBiDang();
            frm.Show();
        }
    }
}
