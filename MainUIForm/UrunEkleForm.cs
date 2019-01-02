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
    public partial class UrunEkleForm : Form
    {
        public Form1 eris = (Form1)Application.OpenForms["Form1"];
        public UrunEkleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Urunid.Text != "id")
            {
                bool sonuc = UrunlerRepo.UrunKaydet(new UrunVM { ID = int.Parse(Urunid.Text), UrunAdi = Urunaditxt.Text.ToUpper().Trim() });
                if (sonuc == true)
                {
                    MessageBox.Show("Ürün Başarıyla Güncellendi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün Güncellenmedi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool sonuc = UrunlerRepo.UrunKaydet(new UrunVM {  UrunAdi = Urunaditxt.Text.ToUpper().Trim() });
                if (sonuc == true)
                {
                    MessageBox.Show("Ürün Başarıyla Eklendi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün Eklenemdi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            eris.Enabled = true;
            this.Close();
        }

        private void UrunEkleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            eris.Enabled = true;
            eris.Form1_Load(sender, e);
        }

        private void SIL_Click(object sender, EventArgs e)
        {
            bool sonuc = UrunlerRepo.UrunSil(int.Parse(Urunid.Text));
            if (sonuc == true)
            {
                MessageBox.Show("Ürün Silindi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ürün Silinemedi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            eris.Enabled = true;
            this.Close();
        }

        private void Urunaditxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
