using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Data
{
    public class UrunFiyat
    {
        public int UrunFiyatID { get; set; }
        public int MusterilerID { get; set; }
        public int? SiparisID { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public double Odenen { get; set; }
        public double ToplamFiyat { get; set; }
        public int Adet { get; set; }
        public int KG { get; set; }
        public bool Sepette { get; set; }
        public bool Tamamlandi { get; set; }

        public virtual Musteriler Musteriler { get; set; }
        public virtual Siparis Siparis { get; set; }
    }
}
