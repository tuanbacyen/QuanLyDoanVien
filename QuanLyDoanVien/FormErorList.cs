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
    public partial class FormErorList : Form
    {
        List<string> errorList;

        public FormErorList()
        {
            InitializeComponent();
        }

        public FormErorList(List<string> errorlist)
        {
            errorList = errorlist;
            InitializeComponent();
        }

        private void FormErorList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < errorList.Count; i++) errlistBox.Items.Add(errorList[i]);
        }
    }
}
