using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLUrun
    {
        public static List<EntityUrun> BllUrunListele()
        {
            return DALUrun.UrunListesi();
        }
        public static int TalepEkleBLL(EntitySiparis p)
        {
            
            
                return DALUrun.SiparisTalep(p);
            
            
        }
    }
}
