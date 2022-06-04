using System.Data;
using System.Data.SqlClient;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Veriler {
    public class Oda : SqlVeri {

        public Oda(string tabloAdi, int odaNo, char odaBlokAd, int katNo, int kapasite, int doluYatak) {
            this.odaNo = odaNo;
            this.odaBlokAd = odaBlokAd;
            this.kapasite = kapasite;
            this.katNo = katNo;
            this.tabloAdi = tabloAdi;
            this.doluYatak = doluYatak;
        }

        public Oda(int id, int odaNo, char odaBlokAd, int katNo) {
            this.id = id;
            this.odaNo = odaNo;
            this.katNo = katNo;
            this.odaBlokAd = odaBlokAd;
        }

        public Oda(string tabloAdi) {
            this.tabloAdi = tabloAdi;
        }


        private int odaNo;
        private char odaBlokAd;
        private int katNo;
        private int kapasite;
        private int doluYatak;
        private int id;

        public int OdaNo { get => odaNo;}
        public char OdaBlokAd { get => odaBlokAd;}
        public int KatNo { get => katNo;}
        public int ID { get => id;}

        public override void VeriGir() {
            query = "insert into " + tabloAdi + " (oda_no, oda_blokAdi, kat_no, oda_kapasite, oda_doluYatak) values (@p1, @p2, @p3, @p4, @p5)";
            SqlSunucu baglanti = new SqlSunucu(0);
            baglanti.Cmd.Parameters.AddWithValue("@p1", odaNo);
            baglanti.Cmd.Parameters.AddWithValue("@p2", odaBlokAd);
            baglanti.Cmd.Parameters.AddWithValue("@p3", katNo);
            baglanti.Cmd.Parameters.AddWithValue("@p4", kapasite);
            baglanti.Cmd.Parameters.AddWithValue("@p5", doluYatak);
            baglanti.SetData(query);
        }
    }
}
