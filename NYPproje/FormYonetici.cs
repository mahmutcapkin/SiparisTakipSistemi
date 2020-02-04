using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjeOrijinal
{
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }
        //LOCAL ALAN
        public string satir;

        private void FormYonetici_Load(object sender, EventArgs e)
        {
            //Ürünleri Silme Listelemesi
            //Ürünler Listbox
            StreamReader SW1 = new StreamReader(Application.StartupPath + "\\Urunler.txt");
            while ((satir = SW1.ReadLine()) != null)
            {
                lbUrunler.Items.Add(satir);
            }
            SW1.Close();
            //Ürün Ağırlık Listbox
            StreamReader SW2 = new StreamReader(Application.StartupPath + "\\UrunAgirligi.txt");
            while ((satir = SW2.ReadLine()) != null)
            {
                lbUrunAgirlik.Items.Add(satir);
            }
            SW2.Close();
            //Ürün Kargo Ağırlığı Listbox
            StreamReader SW3 = new StreamReader(Application.StartupPath + "\\KargoAgirligi.txt");
            while ((satir = SW3.ReadLine()) != null)
            {
                lbKargoAgirlik.Items.Add(satir);
            }
            SW3.Close();
            //Ürün Vergi Oranı Listbox
            StreamReader SW4 = new StreamReader(Application.StartupPath + "\\VergiOrani.txt");
            while ((satir = SW4.ReadLine()) != null)
            {
                lbVergiOrani.Items.Add(satir);
            }
            SW4.Close();
            //Ürün Fiyat Listbox
            StreamReader SW5 = new StreamReader(Application.StartupPath + "\\Fiyat.txt");
            while ((satir = SW5.ReadLine()) != null)
            {
                lbFiyat.Items.Add(satir);
            }
            SW5.Close();

            /////////////////////////////////////////////////
            ////////////////////////////////////////////////
            ///////////////////////////////////////////////

            //Ürün Güncelleme Load Olayları
            StreamReader SWad = new StreamReader(Application.StartupPath + "\\Urunler.txt");
            while ((satir = SWad.ReadLine()) != null)
            {
                listboxUrun.Items.Add(satir);
            }
            SWad.Close();
            //URUN AGİRLİGİNİ OKUDUK LİSTBOXA ATTIK
            StreamReader SWUrunAgirlik = new StreamReader(Application.StartupPath + "\\UrunAgirligi.txt");
            while ((satir = SWUrunAgirlik.ReadLine()) != null)
            {
                listboxUrunAgirlik.Items.Add(satir);
            }
            SWUrunAgirlik.Close();
            //URUN FİYATINI OKUDUK LİSTBOXA ATTIK
            StreamReader SWFiyat = new StreamReader(Application.StartupPath + "\\Fiyat.txt");
            while ((satir = SWFiyat.ReadLine()) != null)
            {
                listboxFiyat.Items.Add(satir);
            }
            SWFiyat.Close();
            //KARGO AGİRLİGİNİ OKUDUK LİSTBOXA ATTIK
            StreamReader SWKargoAgirlik = new StreamReader(Application.StartupPath + "\\KargoAgirligi.txt");
            while ((satir = SWKargoAgirlik.ReadLine()) != null)
            {
                listboxKargoAgirligi.Items.Add(satir);
            }
            SWKargoAgirlik.Close();
            //URUNUN VERGİ ORANINI OKUDUK LİSTBOXA ATTIK
            StreamReader SWVergiOrani = new StreamReader(Application.StartupPath + "\\VergiOrani.txt");
            while ((satir = SWVergiOrani.ReadLine()) != null)
            {
                listboxVergiOrani.Items.Add(satir);
            }
            SWVergiOrani.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Ürün adını yazdırma
            StreamWriter SWad = File.AppendText("Urunler.txt");
            SWad.WriteLine(txtUrunAd.Text);
            SWad.Close();


            //Ürün fiyatını yazdırma
            StreamWriter SWfiyat = File.AppendText("Fiyat.txt");
            SWfiyat.WriteLine(txtUrunFiyat.Text);
            SWfiyat.Close();

            //Ürün  Agirligi yazdırma

            StreamWriter SWurunagirligi = File.AppendText("UrunAgirligi.txt");
            SWurunagirligi.WriteLine(txtUrunAgirlik.Text);
            SWurunagirligi.Close();

            //Ürün Vergi orani yazdırma

            StreamWriter SWvergiorani = File.AppendText("VergiOrani.txt");
            SWvergiorani.WriteLine(txtUrunKDV.Text);
            SWvergiorani.Close();
        }

        //Listbox İndex Eşitlemeleri
        private void listboxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

            listboxUrunAgirlik.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void listboxUrunAgirlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listboxUrunAgirlik.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void listboxKargoAgirligi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listboxUrunAgirlik.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void listboxVergiOrani_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listboxUrunAgirlik.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void listboxFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listboxUrunAgirlik.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }
        //Güncelleme Butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //Ürünleri Silme İşlemi
                File.WriteAllLines("Fiyat.txt", File.ReadAllLines("Fiyat.txt").Where(s => !s.StartsWith(listboxFiyat.Items[listboxFiyat.SelectedIndex].ToString())));
                File.WriteAllLines("UrunAgirligi.txt", File.ReadAllLines("UrunAgirligi.txt").Where(s => !s.StartsWith(listboxUrunAgirlik.Items[listboxUrunAgirlik.SelectedIndex].ToString())));
                File.WriteAllLines("KargoAgirligi.txt", File.ReadAllLines("KargoAgirligi.txt").Where(s => !s.StartsWith(listboxKargoAgirligi.Items[listboxKargoAgirligi.SelectedIndex].ToString())));
                File.WriteAllLines("VergiOrani.txt", File.ReadAllLines("VergiOrani.txt").Where(s => !s.StartsWith(listboxVergiOrani.Items[listboxVergiOrani.SelectedIndex].ToString())));
                File.WriteAllLines("Urunler.txt", File.ReadAllLines("Urunler.txt").Where(s => !s.StartsWith(listboxUrun.Items[listboxUrun.SelectedIndex].ToString())));
                
                //Ürünleri Güncelleyip Ekleme İşlemi

                //Ürün adını yazdırma
                StreamWriter SWUrun = File.AppendText("Urunler.txt");
                SWUrun.WriteLine(txtYeniAd.Text);
                SWUrun.Close();
                //Ürün fiyatını yazdırma
                StreamWriter SWfiyat = File.AppendText("Fiyat.txt");
                SWfiyat.WriteLine(txtYeniFiyat.Text);
                SWfiyat.Close();
                //Ürün  Agirligi yazdırma
                StreamWriter SWurunagirligi = File.AppendText("UrunAgirligi.txt");
                SWurunagirligi.WriteLine(txtYeniAgirlik.Text);
                SWurunagirligi.Close();
                //Ürün Vergi orani yazdırma
                StreamWriter SWvergiorani = File.AppendText("VergiOrani.txt");
                SWvergiorani.WriteLine(txtYeniVergiOrani.Text);
                SWvergiorani.Close();
                //Kargo Ağırlığı Yazdırma
                StreamWriter SWkargoagirligi = File.AppendText("KargoAgirligi.txt");
                SWkargoagirligi.WriteLine(txtYeniKargoAgirlik.Text);
                SWkargoagirligi.Close();

                //Textboxların İçini Temizleme
                txtYeniAd.Clear();
                txtYeniAgirlik.Clear();
                txtYeniVergiOrani.Clear();
                txtYeniKargoAgirlik.Clear();
                txtYeniFiyat.Clear();
           

                MessageBox.Show("BAŞARILI");
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            txtYeniFiyat.Text = listboxFiyat.Items[listboxFiyat.SelectedIndex].ToString();
            txtYeniVergiOrani.Text = listboxVergiOrani.Items[listboxVergiOrani.SelectedIndex].ToString();
            txtYeniKargoAgirlik.Text = listboxKargoAgirligi.Items[listboxKargoAgirligi.SelectedIndex].ToString();
            txtYeniAgirlik.Text = listboxUrunAgirlik.Items[listboxUrunAgirlik.SelectedIndex].ToString();
            txtYeniAd.Text = listboxUrun.Items[listboxUrun.SelectedIndex].ToString();
        }

        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbUrunAgirlik.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbVergiOrani.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbFiyat.SelectedIndex = lbUrunler.SelectedIndex;
        }

        private void lbUrunAgirlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbUrunAgirlik.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbVergiOrani.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbFiyat.SelectedIndex = lbUrunler.SelectedIndex;
        }

        private void lbKargoAgirlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbUrunAgirlik.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbVergiOrani.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbFiyat.SelectedIndex = lbUrunler.SelectedIndex;
        }

        private void lbVergiOrani_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbUrunAgirlik.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbVergiOrani.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbFiyat.SelectedIndex = lbUrunler.SelectedIndex;
        }

        private void lbFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
           lbUrunAgirlik.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbVergiOrani.SelectedIndex = lbKargoAgirlik.SelectedIndex = lbFiyat.SelectedIndex = lbUrunler.SelectedIndex;
        }
        
        private void btnSilGitsin_Click(object sender, EventArgs e)
        {
           try
            {
                File.WriteAllLines("Fiyat.txt", File.ReadAllLines("Fiyat.txt").Where(s => !s.StartsWith(lbFiyat.Items[lbFiyat.SelectedIndex].ToString())));
                File.WriteAllLines("UrunAgirligi.txt", File.ReadAllLines("UrunAgirligi.txt").Where(s => !s.StartsWith(lbUrunAgirlik.Items[lbUrunAgirlik.SelectedIndex].ToString())));
                File.WriteAllLines("KargoAgirligi.txt", File.ReadAllLines("KargoAgirligi.txt").Where(s => !s.StartsWith(lbKargoAgirlik.Items[lbKargoAgirlik.SelectedIndex].ToString())));
                File.WriteAllLines("VergiOrani.txt", File.ReadAllLines("VergiOrani.txt").Where(s => !s.StartsWith(lbVergiOrani.Items[lbVergiOrani.SelectedIndex].ToString())));
                File.WriteAllLines("Urunler.txt", File.ReadAllLines("Urunler.txt").Where(s => !s.StartsWith(lbUrunler.Items[lbUrunler.SelectedIndex].ToString())));
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }
    }
}
