using DAL.VMRepo;
using Entity.Context;
using Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class SiparisRepo
    {
        public static bool SiparisEkle(SiparisVM Ekle)
        {
            using (CMDB db = new CMDB())
            {
                int birimkg = (Ekle.Birim == "KG") ? int.Parse(Ekle.Miktar) : 0;
                Urun urun = new Urun();
                try
                {
                    var bul = db.Urun.FirstOrDefault(p => p.UrunAdi == Ekle.UrunAdi);
                    if (bul == null)
                    {
                        db.Urun.Add(new Urun { UrunAdi = Ekle.UrunAdi });
                        db.SaveChanges();
                        urun = new Urun { UrunAdi = Ekle.UrunAdi };
                    }
                    else
                    {
                        urun = bul;
                    }

                    bool Kontrol = db.Musteriler.Any(p => p.Isim == Ekle.MüşteriAdı);
                    if (Kontrol == false)
                    {
                        db.Musteriler.Add(new Musteriler { Isim = Ekle.MüşteriAdı, HesapKapandimi = false, OdenenCari = 0, ToplamCari = 0,KalanCari=0 });
                        db.SaveChanges();
                    }
                    var Kontrol2 = db.Musteriler.FirstOrDefault(p => p.Isim == Ekle.MüşteriAdı);
                    bool sipakontrol = db.Siparis.Any(p => p.Tamamlandi == false);
                    if (sipakontrol == false)
                    {
                        db.Siparis.Add(new Siparis
                        {
                            MusterilerID = Kontrol2.MusterilerID,
                            Toplam = 0,
                            ToplamOdenen = 0,
                            Tarih = DateTime.Now.ToShortDateString(),
                            Tamamlandi = false,
                            Ay=DateTime.Now.Month.ToString(),
                            Yil=DateTime.Now.Year.ToString()
                        });
                        db.SaveChanges();
                    }
                    var sipakontrol2 = db.Siparis.FirstOrDefault(p => p.Tamamlandi == false);
                    db.UrunFiyat.Add(new UrunFiyat
                    {
                        Aciklama = Ekle.Acıklama,
                        MusterilerID = Kontrol2.MusterilerID,
                        Adet = (birimkg == 0) ? int.Parse(Ekle.Miktar) : 0,
                        KG = birimkg,
                        Fiyat = Ekle.Fiyat,
                        UrunAdi = Ekle.UrunAdi,
                        Sepette = false,
                        ToplamFiyat = int.Parse(Ekle.Miktar) * Ekle.Fiyat,
                        Odenen = Ekle.Odeme,
                        Tamamlandi = false,
                        SiparisID=sipakontrol2.SiparisID,
                    });
                    db.SaveChanges();
                    var al = db.UrunFiyat.FirstOrDefault(p => p.Sepette == false);
                    sipakontrol2.Toplam += al.ToplamFiyat;
                    sipakontrol2.ToplamOdenen += al.Odenen;
                    al.Sepette = true;
                    Kontrol2.OdenenCari += Ekle.Odeme;
                    Kontrol2.ToplamCari += al.ToplamFiyat;
                    Kontrol2.KalanCari += al.ToplamFiyat - al.Odenen;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static bool SiparisEkleSonradan(SiparisVM Ekle)
        {
            using (CMDB db = new CMDB())
            {
                int birimkg = (Ekle.Birim == "KG") ? int.Parse(Ekle.Miktar) : 0;
                Urun urun = new Urun();
                try
                {
                    var bul = db.Urun.FirstOrDefault(p => p.UrunAdi == Ekle.UrunAdi);
                    if (bul == null)
                    {
                        db.Urun.Add(new Urun { UrunAdi = Ekle.UrunAdi });
                        db.SaveChanges();
                        urun = new Urun { UrunAdi = Ekle.UrunAdi };
                    }
                    else
                    {
                        urun = bul;
                    }

                    bool Kontrol = db.Musteriler.Any(p => p.Isim == Ekle.MüşteriAdı);
                    if (Kontrol == false)
                    {
                        db.Musteriler.Add(new Musteriler { Isim = Ekle.MüşteriAdı, HesapKapandimi = false, OdenenCari = 0, ToplamCari = 0,KalanCari=0 });
                        db.SaveChanges();
                    }
                    var Kontrol2 = db.Musteriler.FirstOrDefault(p => p.Isim == Ekle.MüşteriAdı);
                    
                    var sipakontrol2 = db.Siparis.FirstOrDefault(p => p.SiparisID==Ekle.ID);
                    db.UrunFiyat.Add(new UrunFiyat
                    {
                        Aciklama = Ekle.Acıklama,
                        MusterilerID = Kontrol2.MusterilerID,
                        Adet = (birimkg == 0) ? int.Parse(Ekle.Miktar) : 0,
                        KG = birimkg,
                        Fiyat = Ekle.Fiyat,
                        UrunAdi = Ekle.UrunAdi,
                        Sepette = false,
                        ToplamFiyat = int.Parse(Ekle.Miktar) * Ekle.Fiyat,
                        Odenen = Ekle.Odeme,
                        Tamamlandi = true,
                        SiparisID = sipakontrol2.SiparisID,
                    });
                    db.SaveChanges();
                    var al = db.UrunFiyat.FirstOrDefault(p => p.Sepette == false);
                    al.Sepette = true;
                    sipakontrol2.Toplam += al.ToplamFiyat;
                    sipakontrol2.ToplamOdenen += al.Odenen;
                    Kontrol2.OdenenCari += Ekle.Odeme;
                    Kontrol2.ToplamCari += al.ToplamFiyat;
                    Kontrol2.KalanCari += al.ToplamFiyat - al.Odenen;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static List<SiparisVM> SiparisSepeti()
        {
            using (CMDB db = new CMDB())
            {
                List<SiparisVM> liste = new List<SiparisVM>();
                try
                {
                    var Data = db.UrunFiyat.Where(p => p.Tamamlandi == false).ToList();
                    foreach (var item in Data)
                    {
                        liste.Add(new SiparisVM
                        {
                            MüşteriAdı=item.Musteriler.Isim,
                            UrunAdi= item.UrunAdi,
                            Acıklama = item.Aciklama,
                            Fiyat = item.Fiyat,
                            ID = item.UrunFiyatID,
                            Odeme = item.Odenen,
                            Tutar = item.ToplamFiyat,
                            Tarih = item.Siparis.Tarih,
                            Birim = (item.KG == 0) ? "ADET" : "KG",
                            Miktar = (item.KG + item.Adet).ToString()
                        });
                    }
                    return liste;
                }
                catch
                {
                    return liste;
                }
            }
        }
        public static List<SiparisVM> SiparisDetay(int id)
        {
            using (CMDB db = new CMDB())
            {
                List<SiparisVM> liste = new List<SiparisVM>();
                try
                {
                    var Data = db.UrunFiyat.Where(p => p.SiparisID==id).ToList();
                    foreach (var item in Data)
                    {
                        liste.Add(new SiparisVM
                        {
                            MüşteriAdı = item.Musteriler.Isim,
                            UrunAdi = item.UrunAdi,
                            Acıklama = item.Aciklama,
                            Fiyat = item.Fiyat,
                            ID = item.UrunFiyatID,
                            Odeme = item.Odenen,
                            Tutar = item.ToplamFiyat,
                            Tarih = item.Siparis.Tarih,
                            Birim = (item.KG == 0) ? "ADET" : "KG",
                            Miktar = (item.KG + item.Adet).ToString()
                        });
                    }
                    return liste;
                }
                catch
                {
                    return liste;
                }
            }
        }
        public static SiparisPrintVM SiparisDetayPrint(int id)
        {
            using (CMDB db = new CMDB())
            {
                SiparisPrintVM liste = new SiparisPrintVM();
                try
                {
                    var Data = db.Siparis.FirstOrDefault(p => p.SiparisID == id);
                    var musteri = db.Musteriler.FirstOrDefault(p => p.MusterilerID == Data.MusterilerID);
                    liste.MüşteriAdı = Data.Musteriler.Isim;
                    liste.KalanCari = Data.Musteriler.KalanCari;
                    liste.Odeme = Data.ToplamOdenen;
                    liste.Tutar = Data.Toplam;
                    liste.SiparisKalanCari = Data.Toplam - Data.ToplamOdenen;
                    liste.MusteriToplamBorc = musteri.KalanCari;
                    return liste;
                }
                catch
                {
                    return liste;
                }
            }
        }
        public static List<SiparislerVM> GecmisSiparisler()
        {
            using (CMDB db = new CMDB())
            {
                List<SiparislerVM> liste = new List<SiparislerVM>();
                try
                {
                    var Data = db.Siparis.Where(s=> s.Tamamlandi==true).OrderBy(p => p.Tarih).Select(o => new SiparislerVM
                    {
                        MüşteriAdı = o.Musteriler.Isim,
                        ID = o.SiparisID,
                        Odeme = o.ToplamOdenen,
                        Tarih = o.Tarih,
                        Tutar = o.Toplam
                    }).ToList();
                    return Data;
                }
                catch
                {
                    return liste;
                }
            }
        }
        public static bool SiparisTamamla()
        {
            try
            {
                using (CMDB db = new CMDB())
                {
                    var bul = db.Siparis.FirstOrDefault(p => p.Tamamlandi == false);
                    var bul2 = db.UrunFiyat.Where(p => p.Tamamlandi == false).ToList();
                    foreach (var item in bul2)
                    {
                        item.Tamamlandi = true;
                        db.SaveChanges();
                    }
                    bul.Tamamlandi = true;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool SiparisSil()
        {
            try
            {
                using (CMDB db = new CMDB())
                {
                    var bul = db.Siparis.FirstOrDefault(p => p.Tamamlandi == false);
                    var bul2 = db.UrunFiyat.Where(p => p.Tamamlandi == false).ToList();
                    var bul3 = db.Musteriler.FirstOrDefault(p => p.MusterilerID == bul.MusterilerID);
                    bul3.ToplamCari -= bul.Toplam;
                    bul3.OdenenCari -= bul.ToplamOdenen;
                    bul3.KalanCari -= (bul.Toplam - bul.ToplamOdenen);
                    db.UrunFiyat.RemoveRange(bul2);
                    db.Siparis.Remove(bul);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool SiparisSilKomple(int id)
        {
            try
            {
                using (CMDB db = new CMDB())
                {
                    var bul = db.Siparis.FirstOrDefault(p => p.SiparisID==id);
                    var bul2 = db.UrunFiyat.Where(p => p.SiparisID==bul.SiparisID).ToList();
                    var bul3 = db.Musteriler.FirstOrDefault(p => p.MusterilerID == bul.MusterilerID);
                    bul3.ToplamCari -= bul.Toplam;
                    bul3.OdenenCari -= bul.ToplamOdenen;
                    bul3.KalanCari -= (bul.Toplam - bul.ToplamOdenen);
                    db.UrunFiyat.RemoveRange(bul2);
                    db.Siparis.Remove(bul);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool SiparisSepettenSil(int id)
        {
            try
            {
                using (CMDB db = new CMDB())
                {
                    var bul = db.UrunFiyat.FirstOrDefault(p => p.UrunFiyatID==id);
                    bul.Siparis.Toplam -= bul.ToplamFiyat;
                    bul.Siparis.ToplamOdenen -= bul.Odenen;
                    bul.Musteriler.OdenenCari -= bul.Odenen;
                    bul.Musteriler.ToplamCari -= bul.ToplamFiyat;
                    bul.Musteriler.KalanCari -= bul.ToplamFiyat - bul.Odenen;
                    db.UrunFiyat.Remove(bul);
                    db.SaveChanges();
                    var kontrol = db.UrunFiyat.Any(p => p.SiparisID == id);
                    if(kontrol == false)
                    {
                        SiparisSil();
                    }
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
