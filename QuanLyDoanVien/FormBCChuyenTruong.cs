using Microsoft.Reporting.WinForms;
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
    public partial class FormBCChuyenTruong : Form
    {
        public FormBCChuyenTruong()
        {
            InitializeComponent();
        }

        private void FormChuyenTruong_Load(object sender, EventArgs e)
        {
            try
            {
                this.V_SVChuyenTruongTableAdapter.Fill(this.QLDV.V_SVChuyenTruong);
            }catch(Exception ex)
            {
            }
            ChonNgay(dtFrom.Value, dtToYear.Value);
            this.reportViewer1.RefreshReport();
        }

        private void ChonNgay(DateTime fromYear, DateTime toYear)
        {
            ReportParameter[] rp = new ReportParameter[7];
            rp[0] = new ReportParameter("fromYear");
            rp[1] = new ReportParameter("toYear");
            rp[2] = new ReportParameter("dDay");
            rp[3] = new ReportParameter("dMonth");
            rp[4] = new ReportParameter("dYear");
            rp[5] = new ReportParameter("dNewYear");
            rp[6] = new ReportParameter("dOldYear");
            //----------------------------------------
            rp[0].Values.Add(fromYear.ToString());
            rp[1].Values.Add(toYear.ToString());
            rp[2].Values.Add(DateTime.Now.Day.ToString());
            rp[3].Values.Add(DateTime.Now.Month.ToString());
            rp[4].Values.Add(DateTime.Now.Year.ToString());
            rp[5].Values.Add(toYear.Year.ToString());
            rp[6].Values.Add(fromYear.Year.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            ChonNgay(dtFrom.Value, dtToYear.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
