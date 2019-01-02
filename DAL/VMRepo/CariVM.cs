using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VMRepo
{
   public class CariVM
    {
        public int ID { get; set; }
        public string MüşteriAdı { get; set; }
        public double Toplam { get; set; }
        public double Odenen { get; set; }
        public double KalanCari { get; set; }
        public string Mutabık { get; set; }
    }
}
