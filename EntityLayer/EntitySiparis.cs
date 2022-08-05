using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntitySiparis
    {
        private int siparis_id;
        private int s_urun_id;
        private int s_bayi_id;
        private string s_urun_adi;
        private string s_bayi_adi;
        private bool durum;

        public int Siparis_id { get => siparis_id; set => siparis_id = value; }
        public int S_urun_id { get => s_urun_id; set => s_urun_id = value; }
        public int S_bayi_id { get => s_bayi_id; set => s_bayi_id = value; }
        public bool Durum { get => durum; set => durum = value; }
        public string S_urun_adi { get => s_urun_adi; set => s_urun_adi = value; }
        public string S_bayi_adi { get => s_bayi_adi; set => s_bayi_adi = value; }
    }
}
