using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOrijinal
{
    public class Siparis
    {
        public List<SiparisDetay> SiparisDetaylar = new List<SiparisDetay>();
        public DateTime Tarih { get; set; }
        public string SiparisDurum { get; set; }
        public void SiparisDetayEkle(SiparisDetay sip)
        {
            SiparisDetaylar.Add(sip);
        }
        public List<SiparisDetay> SiparisDetayListele()
        {
            return SiparisDetaylar;
        }

        public float Vergi()
        {
            return 0;
        }

        public float Alis_Ucret()
        {
            return 0;
        }

        public float Toplam_Odeme()
        {
            return 0;
        }
    }
}
