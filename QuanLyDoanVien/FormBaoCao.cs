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
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDVChuyenTruong.V_SVChuyenTruong' table. You can move, or remove it, as needed.
            //this.V_SVChuyenTruongTableAdapter.Fill(this.QLDVChuyenTruong.V_SVChuyenTruong);
            //this.reportViewer1.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if(cbBaoCao.SelectedIndex == 0)
            {
                try
                {
                    // TODO: This line of code loads data into the 'QLDVChuyenTruong.V_SVChuyenTruong' table. You can move, or remove it, as needed.
                    this.V_SVChuyenTruongTableAdapter.Fill(this.QLDVChuyenTruong.V_SVChuyenTruong);
                }
                catch (Exception ex)
                {

                }
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
