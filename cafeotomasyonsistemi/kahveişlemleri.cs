using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeotomasyonsistemi
{
    public class kahveişlemleri : Ikahveişlem
    {
        public void addkavhe(string kahveName, string KahveOzellik, string KahvePrice, string KahveTur)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KahveTable (KahveName,KahveOzellik,KahvePrice,KahveTur,aktif) VALUES (@pname,@pozellik,@pfıyat,@ptur,@aktif)", baglantı.baglantıı);
            command.Parameters.AddWithValue("@pname", kahveName);
            command.Parameters.AddWithValue("@pozellik", KahveOzellik);
            command.Parameters.AddWithValue("@pfıyat", KahvePrice);
            command.Parameters.AddWithValue("@ptur", KahveTur);
            command.Parameters.AddWithValue("@aktif", 1);
            command.ExecuteNonQuery();
        }

        public void deletekahve(int KahveID)
        {
            SqlCommand command = new SqlCommand("UPDATE KahveTable set aktif=0  WHERE KahveID=@pID", baglantı.baglantıı);
            command.Parameters.AddWithValue("@pID", KahveID);
            command.ExecuteNonQuery();
        }

        public void updatekahve(int KahveID, string kahveName, string KahveOzellik, string KahvePrice, string KahveTur)
        {
            SqlCommand command = new SqlCommand("UPDATE KahveTable SET KahveName=@pname,KahveOzellik=@pozellik,KahvePrice=@price,KahveTur=@ptur WHERE KahveID=@pID", baglantı.baglantıı);
            command.Parameters.AddWithValue("@pID", KahveID);
            command.Parameters.AddWithValue("@pname", kahveName);
            command.Parameters.AddWithValue("@pozellik", KahveOzellik);
            command.Parameters.AddWithValue("@price", KahvePrice);
            command.Parameters.AddWithValue("@ptur", KahveTur);
            command.ExecuteNonQuery();
        }
    }
}
