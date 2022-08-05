using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBayi
    {
        private int bayi_id;
        private string bayi_ad;
        private string bayi_adres;
        private string bayi_tel;

        public int Bayi_id { get => bayi_id; set => bayi_id = value; }
        public string Bayi_ad { get => bayi_ad; set => bayi_ad = value; }
        public string Bayi_adres { get => bayi_adres; set => bayi_adres = value; }
        public string Bayi_tel { get => bayi_tel; set => bayi_tel = value; }
        
    }
}
