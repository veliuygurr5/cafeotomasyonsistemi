using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace cafeotomasyonsistemi
{
	public class baglantı
	{
		public static SqlConnection baglantıı = new SqlConnection("Data Source=.;Initial Catalog=kahveotomasyonsistemi;Integrated Security=True;TrustServerCertificate=True");
		public static void baglantıkontrol()
		{
			if (baglantıı.State == System.Data.ConnectionState.Closed)
			{
				baglantıı.Open();
			}
			else
			{

			}
		}
	}
}
