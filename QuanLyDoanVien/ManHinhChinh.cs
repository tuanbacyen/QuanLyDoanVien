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
            frmThongTinNopDoanPhi frm = new frmThongTinNopDoanPhi();
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

        private void reportDP_Click(object sender, EventArgs e)
        {
            FormBCChuyenTruong frm = new FormBCChuyenTruong();
            frm.Show();
        }

        private void báoCáoChuyểnLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBCChuyenLop frm = new FormBCChuyenLop();
            frm.Show();
        }

        private void báoCáoNợĐoànPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBCNoDoanPhi frm = new FormBCNoDoanPhi();
            frm.Show();
        }

        private void báoCáoTổngThuĐoànPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBCTongThuChi frm = new FormBCTongThuChi();
            frm.Show();
        }

        private void importSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImportFileSinhVien frm = new FormImportFileSinhVien();
            frm.Show();
        }

        private void mnQLHT_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             FormConnect f = new FormConnect();
            f.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormBCChuyenTruong f = new FormBCChuyenTruong();
            f.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FormBCChuyenLop f = new FormBCChuyenLop();
            f.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FormBCNoDoanPhi f = new FormBCNoDoanPhi();
            f.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormBCTongThuChi f = new FormBCTongThuChi();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FormImportFileSinhVien f = new FormImportFileSinhVien();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormKhoa f = new FormKhoa();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNganhHoc f = new FormNganhHoc();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLopQuanLy f = new FormLopQuanLy();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormLopDuBiDang f = new FormLopDuBiDang();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCanBoVanPhongDoan f = new FormCanBoVanPhongDoan();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormChucVu f = new FormChucVu();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSinhVien f = new FormSinhVien();
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormTinhTrangHocTap f = new FormTinhTrangHocTap();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormLoaiHeDaoTao f = new FormLoaiHeDaoTao();
            f.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormSinhVienLopQuanLy f = new FormSinhVienLopQuanLy();
            f.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormHoatDongDoan f = new FormHoatDongDoan();
            f.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FormSoDoanVien f = new FormSoDoanVien();
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmThongTinNopDoanPhi f = new frmThongTinNopDoanPhi();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormChuyenSinhHoatDoan f = new FormChuyenSinhHoatDoan();
            f.Show();
        }
    }
    
}
