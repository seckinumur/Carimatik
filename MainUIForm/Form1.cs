using DAL.Repo;
using DAL.VMRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            FIYAT.Text = "0";
            ODEME.Text = "0";
            ACIKLAMA.Text = "";
            MIKTAR.SelectedIndex = 0;
            MIKTARTEXT.Text = "0";
        }
        public void SiparisGorev()
        {
            List<SiparislerVM> Data = new List<SiparislerVM>();
            Task task = new Task(() => Data = SiparisRepo.GecmisSiparisler());
            task.Start();
            this.Enabled = false;
            bool sonuc = false;
            progressPanel1.Visible = true;
            while (sonuc == false)
            {
                sonuc = task.IsCompleted;
            }
            gridControl3.DataSource = Data;
            gridView3.BestFitColumns();
            gridView3.GroupPanelText = "Carimatik V.0.6 Beta | Toplam Kayıt Sayısı: " + gridView3.RowCount.ToString();
            progressPanel1.Visible = false;
            this.Enabled = true;
        }

        public void Form1_Load(object sender, EventArgs e) //Form Yükleme
        {
            MUSTERI.Properties.Items.Clear();
            URUN.Properties.Items.Clear();
            URUN.Text = "";
            MUSTERI.Text = "";
            MIKTAR.SelectedIndex = 0;
            foreach (var item in MusteriRepo.MusteriAdiDondur())
            {
                MUSTERI.Properties.Items.Add(item);
            }
            foreach (var item in UrunlerRepo.UrunAdiDondur())
            {
                URUN.Properties.Items.Add(item);
            }
            gridControl1.DataSource = SiparisRepo.SiparisSepeti();
            gridView1.BestFitColumns(); //Tüm Kolonlar En iyi Şekilde Ayarlanır
            gridControl2.DataSource = MusteriRepo.CariListesi();
            gridView2.BestFitColumns();
            gridControl4.DataSource = UrunlerRepo.UrunListele();
            gridView4.BestFitColumns();
            gridView1.GroupPanelText = "Carimatik V.0.6 Beta | Toplam Kayıt Sayısı: " + gridView1.RowCount.ToString();
            gridView2.GroupPanelText = "Carimatik V.0.6 Beta | Toplam Kayıt Sayısı: " + gridView2.RowCount.ToString();
            gridView4.GroupPanelText = "Carimatik V.0.6 Beta | Toplam Kayıt Sayısı: " + gridView4.RowCount.ToString();
        }
        public void comboBoxEdit1_KeyPress(object sender, KeyPressEventArgs e) //sadece harf
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        public void textBox1_KeyPress(object sender, KeyPressEventArgs e) //sadece sayı
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e) //sipariş ekleme butonu
        {
            if (MUSTERI.Text == "")
            {
                MessageBox.Show("Müşteri Bilgisini Girin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (FIYAT.Text == "" || FIYAT.Text == "0")
                {
                    MessageBox.Show("Tutar Girmelisiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (MIKTARTEXT.Text == "" || MIKTARTEXT.Text == "0")
                    {
                        MessageBox.Show("Miktar Girmelisiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (URUN.Text == "")
                        {
                            MessageBox.Show("Ürün Girin!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            if (ODEME.Text == "" || ODEME.Text == "0")
                            {
                                MessageBox.Show("Ödeme Girilmedi! Cari Eklenecek", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                bool durum = SiparisRepo.SiparisEkle(new SiparisVM
                                {
                                    MüşteriAdı = MUSTERI.Text.ToUpper().Trim(),
                                    Acıklama = ACIKLAMA.Text.ToUpper().Trim(),
                                    Tutar = 0,
                                    Miktar = MIKTARTEXT.Text,
                                    UrunAdi = URUN.Text.ToUpper().Trim(),
                                    Birim = MIKTAR.SelectedItem.ToString(),
                                    Fiyat = double.Parse(FIYAT.Text),
                                    Odeme = 0,
                                    Tarih = DateTime.Now.ToShortDateString()
                                });
                                if (durum == true)
                                {
                                    MessageBox.Show("Sipariş Eklendi", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Temizle();
                                    Form1_Load(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Sipariş Eklenemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Form1_Load(sender, e);
                                }
                            }
                            else
                            {
                                bool durum = SiparisRepo.SiparisEkle(new SiparisVM
                                {
                                    MüşteriAdı = MUSTERI.Text.ToUpper().Trim(),
                                    Acıklama = ACIKLAMA.Text.ToUpper().Trim(),
                                    Tutar = 0,
                                    Miktar = MIKTARTEXT.Text,
                                    UrunAdi = URUN.Text.ToUpper().Trim(),
                                    Birim = MIKTAR.SelectedItem.ToString(),
                                    Fiyat = double.Parse(FIYAT.Text),
                                    Odeme = double.Parse(ODEME.Text),
                                    Tarih = DateTime.Now.ToShortDateString()
                                });
                                if (durum == true)
                                {
                                    MessageBox.Show("Sipariş Eklendi", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Temizle();
                                    Form1_Load(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Sipariş Eklenemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Form1_Load(sender, e);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //Sil Butonu
        {
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Sipariş Silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                bool durum = SiparisRepo.SiparisSil();
                if (durum == true)
                {
                    MessageBox.Show("Sipariş Silindi", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Form1_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sipariş Silinemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form1_Load(sender, e);
                }
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e) //Girid1 Çift Tıklama İşlemi
        {
            try
            {
                string ID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                string isim = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MüşteriAdı").ToString();
                this.Enabled = false;
                DialogResult sorgu = new DialogResult();
                sorgu = MessageBox.Show(isim + " Adlı Müşterinin Bu Sipariş Silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sorgu == DialogResult.Yes)
                {
                    bool sonuc = SiparisRepo.SiparisSepettenSil(int.Parse(ID));
                    if (sonuc == true)
                    {
                        MessageBox.Show("Sipariş Başarıyla Silindi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Enabled = true;
                        Form1_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Sipariş Silinemedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Enabled = true;
                        Form1_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Siparişi Silme İptal Edildi?", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Enabled = true;
                    Form1_Load(sender, e);
                }
            }
            catch
            {
                this.Enabled = true;
                Form1_Load(sender, e);
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e) //grid 2 çift tıklama
        {
            try
            {
                string ID = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                this.Enabled = false;
                var bul = MusteriRepo.CariBul(int.Parse(ID));
                CariDuzenle ac = new CariDuzenle();
                ac.MAdi.Text = bul.MüşteriAdı;
                ac.TCari.Text = bul.Toplam.ToString();
                ac.TOdenen.Text = bul.Odenen.ToString();
                ac.Talacak.Text = bul.KalanCari.ToString();
                ac.MutabikKal.Checked = (bul.Mutabık == "Mutabık Kalındı") ? true : false;
                ac.Mid.Text = bul.ID.ToString();
                ac.Show();
            }
            catch
            {
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //Task Kontrol Ve Tüm Siparişleri Doldurma
        {
            if (tabControl1.SelectedIndex == 2)
            {
                SiparisGorev();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                progressPanel2.Visible = true;
                AIVM liste = new AIVM();
                Task analiz = new Task(() =>liste= AIRepo.Analiz());
                analiz.Start();
                bool sonuc = false;
                while (sonuc == false)
                {
                    sonuc = analiz.IsCompleted;
                }
                progressPanel2.Visible = false;
                AYLIKALACAK.Text = liste.AylikAlacak.ToString()+"₺";
                AYLIKODEME.Text = liste.AylikOdeme.ToString() + "₺";
                AYLIKSATIS.Text = liste.AylikSatis.ToString() + "₺";
                YILLIKALACAK.Text = liste.Alacak.ToString() + "₺";
                YILLIKODEME.Text = liste.Odeme.ToString() + "₺";
                YILLIKSATIS.Text = liste.Satis.ToString() + "₺";
            }
        }

        private void gridControl3_DoubleClick(object sender, EventArgs e) //grid 3 Çif tıklama işlemi
        {
            try
            {
                string ID = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "ID").ToString();
                this.Enabled = false;
                SiparisDetay siparisDetay = new SiparisDetay();
                siparisDetay.gridControl1.DataSource = SiparisRepo.SiparisDetay(int.Parse(ID));
                siparisDetay.SiparisIDsi = ID;
                siparisDetay.Show();
            }
            catch
            {
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e) //grid 2 print
        {
            gridView2.OptionsPrint.RtfPageHeader = DateTime.Now.ToShortDateString() + " Müşteri Cari Listesi";
            gridView2.OptionsPrint.RtfReportFooter = "2019© Altınkoza Sakatat Mali Değeri Yoktur.";
            gridControl2.ShowPrintPreview();
        }

        private void simpleButton7_Click(object sender, EventArgs e) //grid 2 excel
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Microsoft Excel Engine|*.xlsx";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridControl2.ExportToXlsx(save.FileName);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e) //grid 3 print
        {
            gridControl3.ShowPrintPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e) //grid 3 excel
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Microsoft Excel Engine|*.xlsx";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridControl3.ExportToXlsx(save.FileName);
            }
        }

        private void gridControl4_DoubleClick(object sender, EventArgs e) //grid 4 çift tıklama
        {
            try
            {
                string ID = gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "ID").ToString();
                string isim = gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "UrunAdi").ToString();
                this.Enabled = false;
                UrunEkleForm ac = new UrunEkleForm();
                ac.Urunaditxt.Text = isim;
                ac.Urunid.Text = ID;
                ac.KYADET.Text = "GÜNCELLE";
                ac.Show();
            }
            catch
            {
            }
            Form1_Load(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e) //Ürün Ekleme Butonu
        {
            UrunEkleForm ac = new UrunEkleForm();
            ac.SIL.Enabled = false;
            ac.SIL.BackColor = Color.Gray;
            ac.Show();
        }

        private void BTNBUL_Click(object sender, EventArgs e) //Siparişi Tamamla
        {
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Sipariş Tamamlansın mı?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                bool durum = SiparisRepo.SiparisTamamla();
                if (durum == true)
                {
                    MessageBox.Show("Sipariş Tamamlandı", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Form1_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Tamamlanacak Sipariş Yok!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form1_Load(sender, e);
                }
            }
        }
    }
}
