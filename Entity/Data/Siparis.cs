using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Data
{
   public class Siparis
    {
        public int SiparisID { get; set; }
        public int MusterilerID { get; set; }
        public double Toplam { get; set; }
        public double ToplamOdenen { get; set; }
        public string Tarih { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
        public bool Tamamlandi { get; set; }

        public virtual Musteriler Musteriler { get; set; }
    }
}
