using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VMRepo
{
    public class SiparisVM
    {
        public int ID { get; set; }
        public string MüşteriAdı { get; set; }
        public string UrunAdi { get; set; }
        public string Acıklama { get; set; }
        public string Miktar { get; set; }
        public string Birim { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double Odeme { get; set; }
        public string Tarih { get; set; }
    }
}
