namespace Entity.Context
{
    using Entity.Data;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CMDB : DbContext
    {
        public CMDB()
            : base("name=CMDB")
        {
            //Database.SetInitializer(new CMDBInitializer());
        }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<UrunFiyat> UrunFiyat { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<AnalizAylik> AnalizAylik { get; set; }
        public virtual DbSet<AnalizYillik> AnalizYillik { get; set; }
    }
    //public class CMDBInitializer : CreateDatabaseIfNotExists<CMDB> //Otomatik database Oluþturma
    //{
    //    protected override void Seed(CMDB db)
    //    {
    //        db.Musteriler.Add(new Musteriler { Isim = "Murat", HesapKapandimi = false, ToplamCari = 0, OdenenCari = 0 });
    //        db.SaveChanges();
    //        db.Siparis.Add(new Siparis { MusterilerID = 1,Toplam=0,ToplamOdenen=0,Tamamlandi=true, Tarih = DateTime.Now.ToShortDateString() });
    //        db.SaveChanges();
    //    }
    //}
}