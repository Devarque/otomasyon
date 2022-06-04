using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Veriler {

    public class Yonetici : SqlVeri {
        private string yoneticiAd, yoneticiSoyad, yoneticiTCKN, yoneticiCepTel, yoneticiEposta, yoneticiKullaniciAdi, yoneticiSifre;

        public Yonetici(string tabloAdi, string yoneticiAd, string yoneticiSoyad, string yoneticiTCKN, string yoneticiCepTel,
            string yoneticiEposta, string yoneticiKullaniciAdi, string yoneticiSifre) {
            this.yoneticiAd = yoneticiAd;
            this.yoneticiSoyad = yoneticiSoyad;
            this.yoneticiTCKN = yoneticiTCKN;
            this.yoneticiCepTel = yoneticiCepTel;
            this.yoneticiEposta = yoneticiEposta;
            this.yoneticiKullaniciAdi = yoneticiKullaniciAdi;
            this.yoneticiSifre = yoneticiSifre;
            this.tabloAdi = tabloAdi;
        }

        public Yonetici(string tabloAdi) {
            this.tabloAdi = tabloAdi;
        }


        public override void VeriGir() {
            query = "insert into " + tabloAdi + "(yoneticiAd, yoneticiSoyad, yoneticiTCKN, yoneticiCepTel, yoneticiEposta, yoneticiKullaniciAdi, yoneticiSifre)" +
                    " Values (@y1,@y2,@y3,@y4,@y5,@y6,@y7)";
            SqlSunucu baglanti = new SqlSunucu(0);
            baglanti.Cmd.Parameters.AddWithValue("@y1", yoneticiAd);
            baglanti.Cmd.Parameters.AddWithValue("@y2", yoneticiSoyad);
            baglanti.Cmd.Parameters.AddWithValue("@y3", yoneticiTCKN);
            baglanti.Cmd.Parameters.AddWithValue("@y4", yoneticiCepTel);
            baglanti.Cmd.Parameters.AddWithValue("@y5", yoneticiEposta);
            baglanti.Cmd.Parameters.AddWithValue("@y6", yoneticiKullaniciAdi);
            baglanti.Cmd.Parameters.AddWithValue("@y7", yoneticiSifre);
            baglanti.SetData(query);
        }
    }
}
