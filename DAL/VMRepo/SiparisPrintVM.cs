﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VMRepo
{
   public class SiparisPrintVM
    {
        public int ID { get; set; }
        public string MüşteriAdı { get; set; }
        public double Tutar { get; set; }
        public double Odeme { get; set; }
        public double KalanCari { get; set; }
        public double SiparisKalanCari { get; set; }
        public double MusteriToplamBorc { get; set; }
        public string Tarih { get; set; }
    }
}
