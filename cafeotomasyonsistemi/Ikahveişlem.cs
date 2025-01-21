using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeotomasyonsistemi
{
    public interface Ikahveişlem
    {
        void addkavhe(string kahveName, string KahveOzellik, string KahvePrice, string KahveTur);
        void deletekahve(int KahveID);
        void updatekahve(int KahveID, string kahveName, string KahveOzellik, string KahvePrice, string KahveTur);
       
    }
}
