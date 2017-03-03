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
            fmConnect.ShowDialog();
        }

        private void mnUpdateNganh_Click(object sender, EventArgs e)
        {
            FormNganhHoc frm = new FormNganhHoc();
            frm.ShowDialog();
        }

        private void mnLogin_Click(object sender, EventArgs e)
        {
            FormDangNhap frm = new FormDangNhap();
            //fmConnect.MdiParent = this;
            frm.ShowDialog();
        }

        private void cậpNhậtThôngTinKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhoa frm = new FormKhoa();
            frm.ShowDialog();
        }

        private void mnUpdateLop_Click(object sender, EventArgs e)
        {
            FormLopQuanLy frm = new FormLopQuanLy();
            frm.ShowDialog();
        }

        private void mnChucVu_Click(object sender, EventArgs e)
        {
            FormChucVu frm = new FormChucVu();
            frm.ShowDialog();
        }

        private void mnSVLop_Click(object sender, EventArgs e)
        {
            FormSinhVienLopQuanLy frm = new FormSinhVienLopQuanLy();
            frm.ShowDialog();
        }

        private void mnLoaiHeDaoTao_Click(object sender, EventArgs e)
        {
            FormLoaiHeDaoTao frm = new FormLoaiHeDaoTao();
            frm.ShowDialog();
        }

        private void mnTinhTrangHocTap_Click(object sender, EventArgs e)
        {
            FormTinhTrangHocTap frm = new FormTinhTrangHocTap();
            frm.ShowDialog();
        }

        private void mnUpdateCB_Click(object sender, EventArgs e)
        {
            FormCanBoVanPhongDoan frm = new FormCanBoVanPhongDoan();
            frm.ShowDialog();
        }

        private void mnUpdateSV_Click(object sender, EventArgs e)
        {
            FormSinhVien frm = new FormSinhVien();
            frm.ShowDialog();
        }

        private void mnUpdateSD_Click(object sender, EventArgs e)
        {
            FormSoDoanVien frm = new FormSoDoanVien();
            frm.ShowDialog();
        }

        private void mnUpdateDP_Click(object sender, EventArgs e)
        {
            frmThongTinNopDoanPhi frm = new frmThongTinNopDoanPhi();
            frm.ShowDialog();
        }

        private void mnUpdateHDD_Click(object sender, EventArgs e)
        {
            FormHoatDongDoan frm = new FormHoatDongDoan();
            frm.ShowDialog();
        }

        private void mnUpdateCSHD_Click(object sender, EventArgs e)
        {
            FormChuyenSinhHoatDoan frm = new FormChuyenSinhHoatDoan();
            frm.ShowDialog();
        }

        private void mnDuBiDang_Click(object sender, EventArgs e)
        {
            FormLopDuBiDang frm = new FormLopDuBiDang();
            frm.ShowDialog();
        }

        private void reportDP_Click(object sender, EventArgs e)
        {
            FormBCChuyenTruong frm = new FormBCChuyenTruong();
            frm.ShowDialog();
        }

        private void báoCáoChuyểnLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBCChuyenLop frm = new FormBCChuyenLop();
            frm.ShowDialog();
        }

        private void báoCáoNợĐoànPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBCNoDoanPhi frm = new FormBCNoDoanPhi();
            frm.ShowDialog();
        }

        private void báoCáoTổngThuĐoànPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBCTongThuChi frm = new FormBCTongThuChi();
            frm.ShowDialog();
        }

        private void importSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImportFileSinhVien frm = new FormImportFileSinhVien();
            frm.ShowDialog();
        }

        private void mnQLHT_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             FormConnect f = new FormConnect();
            f.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormBCChuyenTruong f = new FormBCChuyenTruong();
            f.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FormBCChuyenLop f = new FormBCChuyenLop();
            f.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FormBCNoDoanPhi f = new FormBCNoDoanPhi();
            f.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormBCTongThuChi f = new FormBCTongThuChi();
            f.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FormImportFileSinhVien f = new FormImportFileSinhVien();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormKhoa f = new FormKhoa();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNganhHoc f = new FormNganhHoc();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLopQuanLy f = new FormLopQuanLy();
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormLopDuBiDang f = new FormLopDuBiDang();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCanBoVanPhongDoan f = new FormCanBoVanPhongDoan();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormChucVu f = new FormChucVu();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSinhVien f = new FormSinhVien();
            f.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormTinhTrangHocTap f = new FormTinhTrangHocTap();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormLoaiHeDaoTao f = new FormLoaiHeDaoTao();
            f.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormSinhVienLopQuanLy f = new FormSinhVienLopQuanLy();
            f.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormHoatDongDoan f = new FormHoatDongDoan();
            f.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FormSoDoanVien f = new FormSoDoanVien();
            f.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmThongTinNopDoanPhi f = new frmThongTinNopDoanPhi();
            f.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormChuyenSinhHoatDoan f = new FormChuyenSinhHoatDoan();
            f.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult muonThoat = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (muonThoat == DialogResult.Yes)
                Environment.Exit(1);
            else e.Cancel = true;
        }
    }
    
}
