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
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();
        }
        //Local Alan
        public string satir;
       
        
        private void FormSiparis_Load(object sender, EventArgs e)
        {
            FormYonetici FY = new FormYonetici();
            FY.Show();

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
        
        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {
            //SiparişDetay Sınıfı Ataması
             SiparisDetay siparis = new SiparisDetay();
             siparis.Adet = Convert.ToInt32(nudAdet.Value);
             siparis.Vergi_Durumu = 18;
           

            Siparis s = new Siparis();  
             Musteri mus = new Musteri();
                        
            //Urun Sınıfı Atamaları
            Urun U = new Urun();
            U.Kargo_Agirligi = Convert.ToInt32(listboxKargoAgirligi.SelectedIndex);
         //   U.UrunAd = listboxUrun.Items[listboxUrun.SelectedIndex].ToString();
            U.Urun_Agirlik(Convert.ToDecimal(listboxKargoAgirligi.SelectedIndex));
            
            //Listview Atamaları

            ListViewItem list = new ListViewItem(); 
     
            int temp1 = Convert.ToInt32(nudAdet.Value);
            int temp = Convert.ToInt32(listboxFiyat.Items[listboxFiyat.SelectedIndex].ToString());

            list.Text = FormMusteriBilgileri.customer.Ad + " " + FormMusteriBilgileri.customer.Soyad;//Adı Soyadı
            list.SubItems.Add(listboxUrun.Items[listboxUrun.SelectedIndex].ToString());//Ürün Adı
            list.SubItems.Add(nudAdet.Value.ToString());//Ürün Adeti
            list.SubItems.Add(DateTime.Now.ToString());//Tarih
            list.SubItems.Add(listboxFiyat.Items[listboxFiyat.SelectedIndex].ToString());//Fiyat
            list.SubItems.Add(FormMusteriBilgileri.customer.Email);//Email
            list.SubItems.Add(FormMusteriBilgileri.customer.Adres);//Adres
            list.SubItems.Add(FormMusteriBilgileri.customer.Telefon);//Telefon
            list.SubItems.Add("%"+siparis.Vergi_Durumu);//Vergi
            list.SubItems.Add(siparis.Ara_Toplam(temp, siparis.Adet).ToString());//Ara Toplam Hesaplatma
            list.SubItems.Add(listboxKargoAgirligi.Items[listboxKargoAgirligi.SelectedIndex].ToString());//Ürün Ağırlığı
            list.SubItems.Add(U.Kargo_Agirlik_Hesapla(temp1).ToString());//Ürün Kargo Ağırlığı
            list.SubItems.Add(U.Urun_Fiyati(temp, siparis.Adet).ToString());//Ürün Toplam Fiyatı
            lwSepet.Items.Add(list);

            U.Urun_Fiyati(temp, siparis.Adet);
            U.Kargo_Agirlik_Hesapla(temp1);
            siparis.Ara_Toplam(temp, siparis.Adet);

            s.SiparisDetayEkle(siparis);
            mus.SiparisEkle(s);
            foreach (Siparis musteri in mus.Siparisler)
            {
                listBox1.Items.Add(musteri.SiparisDetayListele());
            }
        }
        //Listbox İndex Eşitlemeleri
        private void listboxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxUrunAgirlik.SelectedIndex = listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void listboxUrunAgirlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxUrunAgirlik.SelectedIndex = listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void listboxKargoAgirligi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxUrunAgirlik.SelectedIndex= listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void listboxVergiOrani_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxUrunAgirlik.SelectedIndex= listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void listboxFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxUrunAgirlik.SelectedIndex = listboxVergiOrani.SelectedIndex = listboxKargoAgirligi.SelectedIndex = listboxFiyat.SelectedIndex = listboxUrun.SelectedIndex;
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {

            FormOdeme odeme = new FormOdeme();
            odeme.Show();
        }

        private void lwSepet_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if(lwSepet.SelectedItems.Count>0)
            {
                adsoyad = lwSepet.SelectedItems[0].SubItems[0].Text;
                urunad= lwSepet.SelectedItems[0].SubItems[1].Text;
                urunadet= lwSepet.SelectedItems[0].SubItems[2].Text;
                urunfiyat= lwSepet.SelectedItems[0].SubItems[12].Text;
                adres= lwSepet.SelectedItems[0].SubItems[6].Text;
            }*/





        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
