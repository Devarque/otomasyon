using System;
using System.Data;
using System.Data.SqlClient;
using Yurt_Otomasyon.SunucuBaglantisi;


namespace Yurt_Otomasyon.Veriler {

    public class Ogrenci : SqlVeri {
        private int id;
        private byte[] foto;
        private string ogrAd;
        private string ogrSoyad;
        private string ogrTCKN;
        private string ogrKanGrubu;
        private string ogrCepTel;
        private string ogrEposta;
        private string ogrOkul;
        private string ogrBolum;
        private string ogrVeliAd;
        private string ogrVeliSoyad;
        private string ogrVeliCepTel;
        private string ogrVeliCepTel2;
        private string ogrVeliAdres;
        private char ogrYurtBlok;
        private int ogrYurtKat;
        private int ogrYurtOda;
        private int ogrYurtYatak;
        private DateTime ogrDogum;
        private DateTime ogrKayitTarihi;

        public int Id { get => id;}
        public string OgrTCKN { get => ogrTCKN;}
        public char OgrYurtBlok { get => ogrYurtBlok;}
        public int OgrYurtKat { get => ogrYurtKat;}
        public int OgrYurtOda { get => ogrYurtOda;}


        public Ogrenci(string ogrAd,            string ogrSoyad,        string ogrTCKN,
                       string ogrKanGrubu,      string ogrCepTel,       string ogrEposta,
                       string ogrOkul,          string ogrBolum,        string ogrVeliAd,
                       string ogrVeliSoyad,     string ogrVeliCepTel,   string ogrVeliCepTel2,
                       string ogrVeliAdres,     char ogrYurtBlok,       int ogrYurtKat,
                       int ogrYurtOda,          int ogrYurtYatak,        DateTime ogrDogum,     
                       DateTime ogrKayitTarihi, byte[] foto) {
            this.ogrAd = ogrAd;
            this.ogrSoyad = ogrSoyad;
            this.ogrTCKN = ogrTCKN;
            this.ogrKanGrubu = ogrKanGrubu;
            this.ogrCepTel = ogrCepTel;
            this.ogrEposta = ogrEposta;
            this.ogrOkul = ogrOkul;
            this.ogrBolum = ogrBolum;
            this.ogrVeliAd = ogrVeliAd;
            this.ogrVeliSoyad = ogrVeliSoyad;
            this.ogrVeliCepTel = ogrVeliCepTel;
            this.ogrVeliCepTel2 = ogrVeliCepTel2;
            this.ogrVeliAdres = ogrVeliAdres;
            this.ogrYurtBlok = ogrYurtBlok;
            this.ogrYurtKat = ogrYurtKat;
            this.ogrYurtOda = ogrYurtOda;
            this.ogrYurtYatak = ogrYurtYatak;
            this.ogrDogum = ogrDogum;
            this.ogrKayitTarihi = ogrKayitTarihi;
            this.foto = foto;
        }

        public Ogrenci(string tabloAdi) {
            this.tabloAdi = tabloAdi;
        }

        public Ogrenci(DataTable data) {
            id = Convert.ToInt32(data.Rows[0]["ogrID"]);
            ogrAd = data.Rows[0]["ogrAd"].ToString();
            ogrSoyad = data.Rows[0]["ogrSoyad"].ToString();
            ogrTCKN = data.Rows[0]["ogrTCKN"].ToString();
            ogrKanGrubu = data.Rows[0]["ogrKanGrubu"].ToString();
            ogrCepTel = data.Rows[0]["ogrCepTel"].ToString();
            ogrEposta = data.Rows[0]["ogrEposta"].ToString();
            ogrOkul = data.Rows[0]["ogrOkul"].ToString();
            ogrBolum = data.Rows[0]["ogrBolum"].ToString();
            ogrVeliAd = data.Rows[0]["ogrVeliAd"].ToString();
            ogrVeliSoyad = data.Rows[0]["ogrVeliSoyad"].ToString();
            ogrVeliCepTel = data.Rows[0]["ogrVeliCepTel"].ToString();
            ogrVeliCepTel2 = data.Rows[0]["ogrVeliCepTel2"].ToString();
            ogrVeliAdres = data.Rows[0]["ogrVeliAdres"].ToString();
            ogrYurtBlok = data.Rows[0]["ogrYurtBlok"].ToString()[0];
            ogrYurtKat = Convert.ToInt32(data.Rows[0]["ogrYurtKat"]);
            ogrYurtOda = Convert.ToInt32(data.Rows[0]["ogrYurtOda"]);
            ogrYurtYatak = Convert.ToInt32(data.Rows[0]["ogrYurtYatak"]);
            ogrDogum = Convert.ToDateTime(data.Rows[0]["ogrDogum"]);
            ogrKayitTarihi = Convert.ToDateTime(data.Rows[0]["ogrKayitTarihi"]);
            foto = ((byte[])data.Rows[0]["ogrFoto"]);
        }

        public override void VeriGir() {
            query = "Insert Into Ogrenci(ogrAd,ogrSoyad,ogrTCKN,ogrKanGrubu,ogrCepTel,ogrEposta,ogrOkul,ogrBolum,ogrVeliAd,ogrVeliSoyad,ogrVeliCepTel,ogrVeliCepTel2,ogrVeliAdres,ogrYurtBlok,ogrYurtKat,ogrYurtOda,ogrYurtYatak,ogrDogum,ogrKayitTarihi, ogrFoto)Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p23,@p24,@p25)";
            SqlSunucu baglanti = new SqlSunucu(0);
            baglanti.Cmd.Parameters.AddWithValue("@p1", ogrAd);
            baglanti.Cmd.Parameters.AddWithValue("@p2", ogrSoyad);
            baglanti.Cmd.Parameters.AddWithValue("@p3", ogrTCKN);
            baglanti.Cmd.Parameters.AddWithValue("@p4", ogrKanGrubu);
            baglanti.Cmd.Parameters.AddWithValue("@p5", ogrCepTel);
            baglanti.Cmd.Parameters.AddWithValue("@p6", ogrEposta);
            baglanti.Cmd.Parameters.AddWithValue("@p7", ogrOkul);
            baglanti.Cmd.Parameters.AddWithValue("@p8", ogrBolum);
            baglanti.Cmd.Parameters.AddWithValue("@p9", ogrVeliAd);
            baglanti.Cmd.Parameters.AddWithValue("@p10", ogrVeliSoyad);
            baglanti.Cmd.Parameters.AddWithValue("@p11", ogrVeliCepTel);
            baglanti.Cmd.Parameters.AddWithValue("@p12", ogrVeliCepTel2);
            baglanti.Cmd.Parameters.AddWithValue("@p13", ogrVeliAdres);
            baglanti.Cmd.Parameters.AddWithValue("@p14", ogrYurtBlok);
            baglanti.Cmd.Parameters.AddWithValue("@p15", ogrYurtKat);
            baglanti.Cmd.Parameters.AddWithValue("@p16", ogrYurtOda);
            baglanti.Cmd.Parameters.AddWithValue("@p17", ogrYurtYatak);
            baglanti.Cmd.Parameters.AddWithValue("@p23", ogrDogum);
            baglanti.Cmd.Parameters.AddWithValue("@p24", ogrKayitTarihi);
            baglanti.Cmd.Parameters.AddWithValue("@p25", foto);
            baglanti.SetData(query);
        }
    }
}
