using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeotomasyonsistemi
{
    public interface Ikullanıcı
    {
        void addkullanıcı(string name);
        void updatekullanıcı(string name,int id);
        void deletekullanıcı(int id);
    }
}
