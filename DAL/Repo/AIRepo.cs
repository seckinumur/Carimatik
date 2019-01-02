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
    public class AIRepo
    {
        private static void AIStart()
        {
            string ay = DateTime.Now.Month.ToString(), yil = DateTime.Now.Year.ToString();
            try
            {
                using (CMDB db = new CMDB())
                {
                    double toplamsatis, toplamodeme, toplamalacak, toplamsatistumu, toplamodemetumu, toplamalacaktumu;
                    bool Kontrol = db.AnalizAylik.Any(p => p.Ay == ay && p.Yil == yil);
                    bool Kontrol2 = db.AnalizYillik.Any(p => p.Yil == yil);
                    bool Kontrol3 = db.Siparis.Any(p=> p.Ay==ay&&p.Yil==yil);
                    if (Kontrol3 == false)
                    {
                        toplamsatis = 0;
                        toplamodeme = 0;
                        toplamalacak = 0;
                        toplamsatistumu = 0;
                        toplamodemetumu = 0;
                        toplamalacaktumu = 0;
                    }
                    else
                    {
                        toplamsatis = db.Siparis.Where(p => p.Yil == yil && p.Ay == ay).Sum(o => o.Toplam);
                        toplamodeme = db.Siparis.Where(p => p.Yil == yil && p.Ay == ay).Sum(o => o.ToplamOdenen);
                        toplamalacak = toplamsatis - toplamodeme;
                        toplamsatistumu = db.Siparis.Where(p => p.Yil == yil).Sum(o => o.Toplam);
                        toplamodemetumu = db.Siparis.Where(p => p.Yil == yil).Sum(o => o.ToplamOdenen);
                        toplamalacaktumu = toplamsatistumu - toplamodemetumu;
                    }
                    if (Kontrol == false)
                    {
                        db.AnalizAylik.Add(new AnalizAylik
                        {
                            Ay = ay,
                            Yil = yil,
                            AylikAlacak = toplamalacak,
                            AylikOdeme = toplamodeme,
                            AylikSatis = toplamsatis
                        });
                        db.SaveChanges();
                    }
                    else
                    {
                        var bul = db.AnalizAylik.FirstOrDefault(p => p.Ay == ay && p.Yil == yil);
                        bul.AylikAlacak = toplamalacak;
                        bul.AylikOdeme = toplamodeme;
                        bul.AylikSatis = toplamsatis;
                        db.SaveChanges();
                    }
                    if (Kontrol2 == false)
                    {
                        db.AnalizYillik.Add(new AnalizYillik
                        {
                            Yil = yil,
                            Alacak = toplamalacaktumu,
                            Odeme = toplamodemetumu,
                            Satis = toplamsatistumu
                        });
                        db.SaveChanges();
                    }
                    else
                    {
                        var bul = db.AnalizYillik.FirstOrDefault(p => p.Yil == yil);
                        bul.Alacak = toplamalacaktumu;
                        bul.Odeme = toplamodemetumu;
                        bul.Satis = toplamsatistumu;
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
            }
        }
        public static AIVM Analiz()
        {
            string ay = DateTime.Now.Month.ToString(), yil = DateTime.Now.Year.ToString();
            AIVM liste = new AIVM();
            try
            {
                AIStart();
                using (CMDB db = new CMDB())
                {
                    var yillik = db.AnalizYillik.FirstOrDefault(p => p.Yil == yil);
                    var aylik = db.AnalizAylik.FirstOrDefault(p => p.Ay == ay && p.Yil == yil);
                    liste.Alacak = yillik.Alacak;
                    liste.AylikAlacak = aylik.AylikAlacak;
                    liste.AylikOdeme = aylik.AylikOdeme;
                    liste.AylikSatis = aylik.AylikSatis;
                    liste.Odeme = yillik.Odeme;
                    liste.Satis = yillik.Satis;
                    return liste;
                }
            }
            catch
            {
                return liste;
            }
        }
    }
}
