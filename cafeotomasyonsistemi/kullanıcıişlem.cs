using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeotomasyonsistemi
{
    public class kullanıcıişlem : Ikullanıcı
    {
        public void addkullanıcı(string name)
        {
            SqlCommand command = new SqlCommand("INSERT INTO İndirimTable (İndirimNameSurname,aktif) VALUES (@pisim,@paktif)", baglantı.baglantıı);
            command.Parameters.AddWithValue("@pisim", name);
            command.Parameters.AddWithValue("@paktif", 1);
            command.ExecuteNonQuery();
        }

        public void deletekullanıcı(int id)
        {
            SqlCommand command = new SqlCommand("Update İndirimTable SET aktif=0 WHERE İndirimID=@pID", baglantı.baglantıı);
            command.Parameters.AddWithValue("@pID", id);
            command.ExecuteNonQuery();
        }

        public void updatekullanıcı(string name, int id)
        {
            SqlCommand command = new SqlCommand("UPDATE İndirimTable SET İndirimNameSurname=@pisim WHERE İndirimID=@pID", baglantı.baglantıı);
            command.Parameters.AddWithValue("@pisim", name);
            command.Parameters.AddWithValue("@pID", id);
            command.ExecuteNonQuery();
        }
    }
}
