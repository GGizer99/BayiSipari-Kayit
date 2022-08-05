using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityUrun
    {
        private int urun_id;
        private string urun_adi;
        private int urun_stok;

        public int Urun_id { get => urun_id; set => urun_id = value; }
        public string Urun_adi { get => urun_adi; set => urun_adi = value; }
        public int Urun_stok { get => urun_stok; set => urun_stok = value; }
    }
}
