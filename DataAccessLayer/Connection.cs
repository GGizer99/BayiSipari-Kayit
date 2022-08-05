using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4U63MD\SQLEXPRESS;Initial Catalog=DBBayiSiparis;Integrated Security=True");
    }
}
