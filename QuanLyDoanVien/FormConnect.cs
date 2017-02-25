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
    public partial class FormConnect : Form
    {
        public FormConnect()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormConnect_Load(object sender, EventArgs e)
        {
            cbServer.Items.Add(".");
            cbServer.Items.Add("(local)");
            cbServer.Items.Add(@".\SQLEXPRESS");
            cbServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbAuthentication.Items.Add("SQL Server Authentication");
            cbAuthentication.Items.Add("Windows Authentication");
            cbServer.SelectedIndex = 0;
            cbAuthentication.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionStringSA = string.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}", cbServer.Text, txtDatabase.Text, txtUser.Text, txtPass.Text);
            string connectionStringWA = string.Format("Data Source={0}; Initial Catalog={1}; Integrated Security = True", cbServer.Text, txtDatabase.Text);
            string connectionString = "";
            try
            {
                if (cbAuthentication.SelectedIndex == 1)
                {
                    connectionString = connectionStringWA;
                }
                else
                {
                    connectionString = connectionStringSA;
                }
                SqlHelper Helper = new SqlHelper(connectionString);
                if (Helper.Iconnection)
                {
                    ApplicationSetting setting = new ApplicationSetting();
                    setting.saveConnectionString("QuanLyDoanVien.Properties.Settings.QuanLyDoanVienConnectionString", connectionString);
                    MessageBox.Show("Kết Nối thành công và lưu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthentication.SelectedIndex == 1)
            {
                txtPass.Enabled = txtUser.Enabled = false;
            }
            else
            {
                txtPass.Enabled = txtUser.Enabled = true;
            }
        }
    }
}
