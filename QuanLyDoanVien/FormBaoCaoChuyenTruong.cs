using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyDoanVien
{
    public partial class FormBaoCaoChuyenTruong : Form
    {
        public FormBaoCaoChuyenTruong()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDV.V_SVChuyenTruong' table. You can move, or remove it, as needed.\
            try
            {
                this.V_SVChuyenTruongTableAdapter.Fill(this.QLDV.V_SVChuyenTruong);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {

            }
            ChonNgay(dtf.Value, dtt.Value);
            this.reportViewer1.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ChonNgay(dtf.Value, dtt.Value);
            this.reportViewer1.RefreshReport();
        }

        private void ChonNgay(DateTime fromYear, DateTime toYear)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("fromYear");
            rp[1] = new ReportParameter("toYear");
            rp[0].Values.Add(fromYear.ToString());
            rp[1].Values.Add(toYear.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }
    }
}
