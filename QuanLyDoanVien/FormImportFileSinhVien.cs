using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanVien
{
    public partial class FormImportFileSinhVien : Form
    {
        string addressFile;
        List<string> eRror = new List<string>();
        QuanLyDoanVienDataContext db = new QuanLyDoanVienDataContext();
        Table<LopQuanLy> lopquanlys;
        Table<SinhVien> sinhviens;
        private void load()
        {
            lopquanlys = db.GetTable<LopQuanLy>();
            sinhviens = db.GetTable<SinhVien>();
        }
        public FormImportFileSinhVien()
        {
            InitializeComponent();
            load();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtSTT.Text = "";
            SinhVien sv = new SinhVien();
            int i = 0, slLoi = 0;
            string MaSinhVien = "";
            string HoDem = "";
            string Ten = "";
            string HoTenKhaiSinh = "";
            string HoTenKhac = "";
            int GioiTinh = 1;
            DateTime NgaySinh = DateTime.Now;
            string DanToc = "";
            string TonGiao = "";
            string TinhTrangHocTap = "";
            string MaLop = "";
            string DiaChi = "";
            string SoDienThoai = "";
            DateTime NgayVaoDoan = DateTime.Now;
            int sttLop = -1;
            foreach (DataGridViewRow row in dataG.Rows)
            {
                i++;

                try
                {
                    MaSinhVien = row.Cells["MaSinhVien"].Value.ToString();
                    HoDem = row.Cells["HoDem"].Value.ToString();
                    Ten = row.Cells["Ten"].Value.ToString();
                    HoTenKhac = row.Cells["HoTenKhac"].Value.ToString();
                    GioiTinh = Convert.ToInt32(row.Cells["GioiTinh"].Value.ToString());
                    NgaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                    DanToc = row.Cells["DanToc"].Value.ToString();
                    TonGiao = row.Cells["TonGiao"].Value.ToString();
                    TinhTrangHocTap = row.Cells["MaTinhTrangHocTap"].Value.ToString();
                    MaLop = row.Cells["MaLop"].Value.ToString();
                    DiaChi = row.Cells["DiaChi"].Value.ToString();
                    SoDienThoai = row.Cells["SoDienThoai"].Value.ToString();
                    NgayVaoDoan = Convert.ToDateTime(row.Cells["NgayVaoDoan"].Value.ToString());
                    HoTenKhaiSinh = HoDem + " " + Ten;

                    // kiểm tra mã lớp đã tồn tại
                    bool MaLopTonTai = lopquanlys.Any(rowOne => rowOne.MaLop == MaLop);
                    if (!MaLopTonTai)
                    {
                        sttLop = 0;
                    }
                    insert(MaSinhVien, HoDem, Ten, HoTenKhaiSinh, HoTenKhac, GioiTinh, NgaySinh, MaLop, DanToc, TonGiao,
                        TinhTrangHocTap, DiaChi, SoDienThoai, NgayVaoDoan);
                }
                catch (Exception ex)
                {
                    if (MaSinhVien == "")
                    {
                        eRror.Add("Dòng " + i + ": Mã Số Sinh Viên Rỗng, Thời gian: " + DateTime.Now.Date); slLoi++;
                    }
                    if (sttLop == 0)
                    {
                        eRror.Add("Dòng " + i + ": Lớp Học Chưa có trong cơ sở dữ liệu, Thời gian: " + DateTime.Now.Date); slLoi++;
                    }
                    Boolean has = sinhviens.Any(sinv => sinv.MaSinhVien == MaSinhVien);
                    if (has)
                    {
                        eRror.Add("Dòng " + i + ": MSSV Đã Tồn Tại, Thời gian: "+DateTime.Now.Date); slLoi++;
                    }
                }
                txtSTT.Text = "Lỗi: " + slLoi + " Lỗi";
            }
            if (eRror.Count > 0)
            {
                MessageBox.Show("Nhập Dữ Liệu Xong có " + slLoi + " lỗi");
            }else
            {
                MessageBox.Show("Nhập Dữ Liệu Xong không có lỗi");
            }
            
        }

        private void btnXemLoi_Click(object sender, EventArgs e)
        {
            FormErorList el = new FormErorList(eRror);
            el.ShowDialog();
        }


        private void insert(string masv, string ten, string hodem, string hotenkhaisinh, string hotenkhac, int Gt, DateTime ns, string malop, string dantoc, string tongiao, string tinhtrang, string diachi, string sdt, DateTime ngayvd)
        {
            sinhviens = db.GetTable<SinhVien>();
            SinhVien sinhvien = new SinhVien();
            sinhvien.MaSinhVien = masv;
            sinhvien.Ten = ten;
            sinhvien.HoDem = hodem;
            sinhvien.HoVaTenKhaiSinh = hotenkhaisinh;
            if (hotenkhac != null)
            {
                sinhvien.HoTenKhac = hotenkhac;
            }
            sinhvien.GioiTinh = true;
            if (Gt == 0)
            {
                sinhvien.GioiTinh = false;
            }
            sinhvien.NgaySinh = ns;
            sinhvien.MaLop = malop;
            sinhvien.DanToc = dantoc;
            sinhvien.TonGiao = tongiao;
            sinhvien.MaTinhTrangHocTap = tinhtrang;
            sinhvien.DiaChi = diachi;
            sinhvien.SoDienThoai = sdt;
            sinhvien.NgayVaoDoan = ngayvd;

            sinhviens = db.GetTable<SinhVien>();
            sinhviens.InsertOnSubmit(sinhvien);
            db.SubmitChanges();
        }


        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            oFD.Filter = "Tất Cả Các File |*.*|Excel 2003 Files |*.xls|Excel 2007 File|*.xlsx";
            oFD.FileName = "";
            oFD.ShowDialog();
        }

        private void danhSachSheet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", addressFile);
                string query = string.Format("Select * from [{0}]", danhSachSheet.Text);
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connec);
                DataTable tbSinhVien = new DataTable();
                adapter.Fill(tbSinhVien);
                if (tbSinhVien.Rows.Count > 0)
                {
                    dataG.DataSource = tbSinhVien;
                }
                else
                {
                    dataG.DataSource = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void oFD_FileOk(object sender, CancelEventArgs e)
        {
            addressFile = oFD.FileName;
            txtFileName.Text = addressFile.Substring(addressFile.LastIndexOf(@"\") + 1);
            List<string> sheets = getListSheet(addressFile);
            danhSachSheet.DataSource = sheets;
        }

        private List<string> getListSheet(string urlFile)
        {
            try
            {
                List<string> sheets = new List<string>();
                string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", urlFile);
                DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = connec;
                connection.Open();
                DataTable dt = connection.GetSchema("Tables");
                connection.Close();
                foreach (DataRow row in dt.Rows)
                {
                    string sheetnames = (string)row["TABLE_NAME"];
                    sheets.Add(sheetnames);
                }
                return sheets;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
    }
}
