using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Data
{
   public class AnalizYillik
    {
        public int AnalizYillikID { get; set; }
        public double Satis { get; set; }
        public double Odeme { get; set; }
        public double Alacak { get; set; }
        public string Yil { get; set; }
    }
}
