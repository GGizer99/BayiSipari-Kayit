using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLSiparis
    {

        public static List<EntitySiparis> BllSiparisListele()
        {
            return DALSiparis.SiparisListesi();
        }

        public static bool BllSiparisSilBLL(int bayi_id_prbll, int sip_id_prbll)
        {
            if(bayi_id_prbll > 0  && sip_id_prbll > 0)
            {
                return DALSiparis.SiparisSil(bayi_id_prbll, sip_id_prbll);
            }

            return false;
            
        }

        public static bool BllSiparisGuncelleBLL(EntitySiparis siparisbll)
        {

            if(siparisbll.S_bayi_id > 0 && siparisbll.Siparis_id > 0)
            {
                return DALSiparis.SiparisGuncelle(siparisbll);
            }
            return false;
            
           

        }


    }
}
