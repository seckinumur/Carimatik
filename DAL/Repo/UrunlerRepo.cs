using DAL.VMRepo;
using Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
   public class UrunlerRepo
    {
        public static List<string> UrunAdiDondur()
        {
            using (CMDB db = new CMDB())
            {
                return db.Urun.OrderBy(p => p.UrunAdi).Select(p => p.UrunAdi).ToList();
            }
        }
        public static List<UrunVM> UrunListele()
        {
            using (CMDB db = new CMDB())
            {
                return db.Urun.OrderBy(p => p.UrunAdi).Select(n=> new UrunVM { ID = n.UrunID, UrunAdi = n.UrunAdi }).ToList();
            }
        }
        public static bool UrunKaydet(UrunVM Urun)
        {
            using (CMDB db = new CMDB())
            {
                try
                {
                    var bul = db.Urun.FirstOrDefault(p => p.UrunID == Urun.ID);
                    bul.UrunAdi = Urun.UrunAdi;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    try
                    {
                        db.Urun.Add(new Entity.Data.Urun { UrunAdi = Urun.UrunAdi });
                        db.SaveChanges();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
        public static bool UrunSil(int id)
        {
            using (CMDB db = new CMDB())
            {
                try
                {
                    var bul = db.Urun.FirstOrDefault(p => p.UrunID == id);
                    db.Urun.Remove(bul);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
