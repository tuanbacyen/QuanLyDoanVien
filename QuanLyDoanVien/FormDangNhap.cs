using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace QuanLyDoanVien
{
    public partial class FormDangNhap : Form
    {
        QuanLyDoanVienDataContext database = new QuanLyDoanVienDataContext();
        Table<TaiKhoan> TAIKHOAN;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
                txtPassWord.UseSystemPasswordChar = false;
            else
                txtPassWord.UseSystemPasswordChar = true;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        int dem = 0;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (dem == 3)
            {
                MessageBox.Show("Bạn đăng nhập sai quá nhiều!\nĐang thoát", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(1);
            }
            else
            {
                if (txtUser.Text.Trim().Equals("") ||
                    txtPassWord.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool TaiKhoanHopLe = AuthenticateUser(txtUser.Text, txtPassWord.Text);
                    if (TaiKhoanHopLe)
                    {
                        if (chkGhiNho.Checked)
                        {
                            string[] line = new string[] { StringHelper.Base64Encode(txtUser.Text), StringHelper.Base64Encode(txtPassWord.Text) };
                            StringHelper.WriteLine(SFileName.loginFile, line);
                        }
                        else
                        {
                            string[] line = new string[] { " ", " " };
                            StringHelper.WriteLine(SFileName.loginFile, line);
                        }
                        Hide();
                        Main f = new Main();
                        f.Show();
                    }
                    else
                    {
                        dem++;
                        MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private bool AuthenticateUser(string id, string pass)
        {
            try
            {
                TAIKHOAN = database.GetTable<TaiKhoan>();

                var taiKhoan = from tk in TAIKHOAN
                               where tk.TenDangNhap == id &&
                                     tk.MatKhau == pass
                               select tk;

                return taiKhoan.Any() ? true : false;
            }catch (Exception ex)
            {
                MessageBox.Show("Unkown error! "+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

            try
            {
                txtUser.Text = StringHelper.Base64Decode(StringHelper.GetLine(SFileName.loginFile, 1));
                txtPassWord.Text = StringHelper.Base64Decode(StringHelper.GetLine(SFileName.loginFile, 2));
                if (txtUser.Text.Trim() == "") chkGhiNho.Checked = false;
                else chkGhiNho.Checked = true;
            }
            catch { }
        }

        private void linkKetNoiCSDL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormConnect fmConnect = new FormConnect();
            //fmConnect.MdiParent = this;
            fmConnect.Show();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Environment.Exit(1);
        }
    }
}
