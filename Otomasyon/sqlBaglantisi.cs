
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Otomasyon
{
    class sqlBaglantisi
    {
        //Veri tabanından metot oluşturulması ve yapılan işlemlerde her seferinde adres yerine metot ile ile bağlantı sağlanması
        public SqlConnection baglan()
        {
            SqlConnection baglan=new SqlConnection(@"Data Source=LAPTOP-4CPKK9I1\SQLEXPRESS;Initial Catalog=dbo.LibraryOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
//Data Source=LAPTOP-4CPKK9I1\SQLEXPRESS;Initial Catalog=dbo.LibraryOtomasyon;Integrated Security=True