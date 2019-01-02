using DAL.VMRepo;
using Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
   public class MusteriRepo
    {
        public static List<string> MusteriAdiDondur()
        {
           using(CMDB db = new CMDB())
            {
                return  db.Musteriler.OrderBy(p => p.Isim).Select(p => p.Isim).ToList();
            }
        }
        public static List<CariVM> CariListesi()
        {
            using (CMDB db = new CMDB())
            {
                return db.Musteriler.Select(p => new CariVM { Mutabık = (p.HesapKapandimi==true)? "Mutabık Kalındı":"Mutabık Kalınmadı", ID = p.MusterilerID, MüşteriAdı = p.Isim, Odenen = p.OdenenCari, Toplam = p.ToplamCari,KalanCari=p.KalanCari }).ToList();
            }
        }
        public static CariVM CariBul(int id)
        {
            using (CMDB db = new CMDB())
            {
                return db.Musteriler.Where(p => p.MusterilerID == id).Select(n => new CariVM
                {
                    ID = n.MusterilerID,
                    Mutabık = (n.HesapKapandimi == true) ? "Mutabık Kalındı" : "Mutabık Kalınmadı",
                    MüşteriAdı = n.Isim,
                    Odenen = n.OdenenCari,
                    Toplam = n.ToplamCari,
                    KalanCari= n.KalanCari
                }).FirstOrDefault();
            }
        }
        public static bool CariDuzenle(CariVM Veri)
        {
            try
            {
                using (CMDB db = new CMDB())
                {
                    var bul = db.Musteriler.FirstOrDefault(p => p.MusterilerID==Veri.ID);
                    bul.Isim = Veri.MüşteriAdı;
                    bul.OdenenCari = Veri.Odenen;
                    bul.ToplamCari = Veri.Toplam;
                    bul.KalanCari = Veri.KalanCari;
                    bul.HesapKapandimi = (Veri.Mutabık== "Mutabık Kalındı")?true:false;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool CariSil(int id)
        {
            try
            {
                using (CMDB db = new CMDB())
                {
                    var bul = db.Musteriler.FirstOrDefault(p => p.MusterilerID == id && p.HesapKapandimi==true);
                    var bul2 = db.Siparis.Where(p => p.MusterilerID == id).ToList();
                    var bul3 = db.UrunFiyat.Where(p => p.MusterilerID == id).ToList();
                    db.Siparis.RemoveRange(bul2);
                    db.UrunFiyat.RemoveRange(bul3);
                    db.Musteriler.Remove(bul);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
