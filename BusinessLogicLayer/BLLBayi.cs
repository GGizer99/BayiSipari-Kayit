using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLBayi
    {
        public static List<EntityBayi> BllBayiListele()
        {
            return DALBayi.BayiListesi();
        }
    }
}
