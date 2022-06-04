using System;
using System.Data;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Veriler {
    public class Blok : SqlVeri {
        public Blok(string tabloAdi, char blokAD, int katSayisi) {
            this.blokAD = blokAD;
            this.katSayisi = katSayisi;
            base.tabloAdi = tabloAdi;
        } 

        public Blok(string tabloAdi) {
            this.tabloAdi = tabloAdi;
        }

        public Blok(DataTable data) {
            blokAD = data.Rows[0]["blokAD"].ToString()[0];
            katSayisi = Convert.ToInt32(data.Rows[0]["katSayisi"]);
        }

        private char blokAD;
        private int katSayisi;

        public int KatSayisi { get => katSayisi;}

        public override void VeriGir() {
            query = "insert into " + tabloAdi + " (blokAD, katSayisi) values (@p1, @p2)";
            SqlSunucu baglanti = new SqlSunucu(0);
            baglanti.Cmd.Parameters.AddWithValue("@p1", blokAD);
            baglanti.Cmd.Parameters.AddWithValue("@p2", katSayisi);
            baglanti.SetData(query);
        }
    }
}
