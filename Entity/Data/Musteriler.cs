using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Data
{
   public class Musteriler
    {
        public int MusterilerID { get; set; }
        public string Isim { get; set; }
        public double ToplamCari { get; set; }
        public double OdenenCari { get; set; }
        public double KalanCari { get; set; }
        public bool HesapKapandimi { get; set; }
    }
}
