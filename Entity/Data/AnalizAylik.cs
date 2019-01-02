using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Data
{
   public class AnalizAylik
    {
        public int AnalizAylikID { get; set; }
        public double AylikSatis { get; set; }
        public double AylikOdeme { get; set; }
        public double AylikAlacak { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
    }
}
