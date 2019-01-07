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
    public partial class CariDuzenle : Form
    {
        public CariDuzenle()
        {
            InitializeComponent();
        }
        public Form1 eris = (Form1)Application.OpenForms["Form1"];

        private void TAlacak_KeyPress(object sender, KeyPressEventArgs e)
        {
            eris.textBox1_KeyPress(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CariVM Veri = new CariVM();
            if (MutabikKal.Checked == true)
            {
                Veri.ID = int.Parse(Mid.Text);
                Veri.MüşteriAdı = MAdi.Text.ToUpper().Trim();
                Veri.Odenen = 0;
                Veri.Toplam = 0;
                //Veri.KalanCari = 0;
                Veri.Mutabık = "Mutabık Kalındı";
                bool sonuc = MusteriRepo.CariDuzenle(Veri);
                if (sonuc == true)
                {
                    this.Close();
                    eris.Enabled = true;
                    MessageBox.Show("Müşteri Carisi Başarıyla Güncellendi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eris.Form1_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Müşteri Carisi Güncelleme Başarılı Olmadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Veri.ID = int.Parse(Mid.Text);
                Veri.MüşteriAdı = MAdi.Text.ToUpper().Trim();
                Veri.Odenen = double.Parse(TOdenen.Text);
                Veri.Toplam = double.Parse(TCari.Text);
                //Veri.KalanCari = double.Parse(Talacak.Text);
                Veri.Mutabık = (MutabikKal.Checked == true) ? "Mutabık Kalındı" : "Mutabık Kalınmadı";
                bool sonuc = MusteriRepo.CariDuzenle(Veri);
                if (sonuc == true)
                {
                    this.Close();
                    eris.Enabled = true;
                    eris.Form1_Load(sender, e);
                    MessageBox.Show("Müşteri Carisi Başarıyla Güncellendi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Müşteri Carisi Güncelleme Başarılı Olmadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            eris.comboBoxEdit1_KeyPress(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show(MAdi.Text + " Adlı Müşterinin Tüm Bilgileri Silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                bool sonuc = MusteriRepo.CariSil(int.Parse(Mid.Text));
                if (sonuc == true)
                {
                    this.Close();
                    eris.Enabled = true;
                    eris.Form1_Load(sender, e);
                    MessageBox.Show("Müşteri Başarıyla Silindi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Müşteri İle Mutabık olmadığınız İçin Müşteri Silinemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CariDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            eris.Enabled = true;
            eris.Form1_Load(sender, e);
        }
    }
}
