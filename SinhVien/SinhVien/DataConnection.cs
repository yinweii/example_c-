using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class DataConnection
    {
        string str;
        public DataConnection()
        {
            str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=SINHVIEN2;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return  new SqlConnection(str);
        }
    }
}
