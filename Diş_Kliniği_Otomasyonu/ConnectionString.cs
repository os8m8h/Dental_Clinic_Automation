using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Diş_Kliniği_Otomasyonu
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=DESKTOP-0K48F4O;Initial Catalog=DentalDb;Integrated Security=True;Pooling=False;";
            return baglanti;
        }
    }

}
