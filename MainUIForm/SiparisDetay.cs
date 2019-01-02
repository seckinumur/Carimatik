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
    public partial class SiparisDetay : Form
    {
        public string SiparisIDsi { get; set; }
        private void Temizle()
        {
            FIYAT.Text = "0";
            ODEME.Text = "0";
            ACIKLAMA.Text = "";
            MIKTAR.SelectedIndex = 0;
            MIKTARTEXT.Text = "0";
            gridControl1.DataSource = SiparisRepo.SiparisDetay(int.Parse(SiparisIDsi));
            gridView1.BestFitColumns();
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
            gridView1.GroupPanelText = "Carimatik V.0.6 Beta | Toplam Kayıt Sayısı: " + gridView1.RowCount.ToString();
        }
        public Form1 eris = (Form1)Application.OpenForms["Form1"];
        public SiparisDetay()
        {
            InitializeComponent();
        }

        private void BTNBUL_Click(object sender, EventArgs e) //Kaydet Kapat Butonu
        {
            this.Close();
            eris.Enabled = true;
            eris.Form1_Load(sender, e);
        }

        private void SiparisDetay_FormClosing(object sender, FormClosingEventArgs e) //form kapatılırsa
        {
            eris.Enabled = true;
            eris.Form1_Load(sender, e);
            eris.SiparisGorev();
        }

        private void BTNEKLE_Click(object sender, EventArgs e) // Ürün Ekle
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
                                bool durum = SiparisRepo.SiparisEkleSonradan(new SiparisVM
                                {
                                    MüşteriAdı = MUSTERI.Text.ToUpper().Trim(),
                                    Acıklama = ACIKLAMA.Text.ToUpper().Trim(),
                                    Tutar = 0,
                                    Miktar = MIKTARTEXT.Text,
                                    UrunAdi = URUN.Text.ToUpper().Trim(),
                                    Birim = MIKTAR.SelectedItem.ToString(),
                                    Fiyat = double.Parse(FIYAT.Text),
                                    Odeme = 0,
                                    Tarih = DateTime.Now.ToShortDateString(),
                                    ID=int.Parse(SiparisIDsi)
                                });
                                if (durum == true)
                                {
                                    MessageBox.Show("Sipariş Eklendi", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Sipariş Eklenemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Temizle();
                                }
                            }
                            else
                            {
                                bool durum = SiparisRepo.SiparisEkleSonradan(new SiparisVM
                                {
                                    MüşteriAdı = MUSTERI.Text.ToUpper().Trim(),
                                    Acıklama = ACIKLAMA.Text.ToUpper().Trim(),
                                    Tutar = 0,
                                    Miktar = MIKTARTEXT.Text,
                                    UrunAdi = URUN.Text.ToUpper().Trim(),
                                    Birim = MIKTAR.SelectedItem.ToString(),
                                    Fiyat = double.Parse(FIYAT.Text),
                                    Odeme = double.Parse(ODEME.Text),
                                    Tarih = DateTime.Now.ToShortDateString(),
                                    ID = int.Parse(SiparisIDsi)
                                });
                                if (durum == true)
                                {
                                    MessageBox.Show("Sipariş Eklendi", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Sipariş Eklenemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Temizle();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BTNSIL_Click(object sender, EventArgs e) //Sil Butonu
        {
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Sipariş Silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                bool durum = SiparisRepo.SiparisSilKomple(int.Parse(SiparisIDsi));
                if (durum == true)
                {
                    MessageBox.Show("Sipariş Silindi", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sipariş Silinemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Temizle();
                }
            }
        }

        private void SiparisDetay_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        private void simpleButton5_Click(object sender, EventArgs e)// excel aktar
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Microsoft Excel Engine|*.xlsx";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridControl1.ExportToXlsx(save.FileName);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)//print
        {
            var data = SiparisRepo.SiparisDetayPrint(int.Parse(SiparisIDsi));
            gridView1.OptionsPrint.RtfPageHeader= data.MüşteriAdı + "\r Müşterinin Sipariş Listesi"+ "\n Raporlama Tarihi:  " + DateTime.Now.ToShortDateString()+"\n";
            gridView1.OptionsPrint.RtfReportFooter = "\r Sipariş Toplam: "+data.Tutar+" TL"+"\n Ödenen: "+data.Odeme+" TL" + "\n Alacak: " + data.KalanCari + " TL"+"\n Toplam Alacak: "+data.MusteriToplamBorc+" TL" + "\n\n 2019© Altınkoza Sakatat Mali Değeri Yoktur.";
            gridControl1.ShowPrintPreview();
        } 

        private void FIYAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MUSTERI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
