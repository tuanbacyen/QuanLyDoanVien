using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien
{
    public class SqlHelper
    {
        SqlConnection cn;
        public SqlHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }

        public Boolean Iconnection
        {
            get
            {
                if(cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
                return true;
            }
        }
    }
}
