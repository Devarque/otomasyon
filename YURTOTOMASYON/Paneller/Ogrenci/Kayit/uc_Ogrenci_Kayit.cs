using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Yurt_Otomasyon.Extensions;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;
using Z.BulkOperations;

namespace Yurt_Otomasyon.Paneller.Ogrenci.Kayit {
    public partial class uc_Ogrenci_Kayit : UserControl, IPanel, IIslemler {
        private Image ogrenciFoto;
        SqlSunucu baglanti = new SqlSunucu(0);
        public uc_Ogrenci_Kayit() {
            InitializeComponent();
        }

        public void PanelYukle(object sender, EventArgs e) {
            combo_Blok.VeriTabanindanDoldur("Blok", "blokAD");
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            //try {
            byte[] image = null;
            ImageConverter imageconverter = new ImageConverter();
            image = (byte[])imageconverter.ConvertTo(ogrenciFoto, typeof(byte[]));
            SqlVeri veri = new Veriler.Ogrenci(
                ogrAd: txtBox_Ad.Text,
                ogrSoyad: txtBox_Soyad.Text,
                ogrTCKN: masked_TCKN.Text,
                ogrKanGrubu: combo_KanGrubu.SelectedItem.ToString(),
                ogrCepTel: masked_CepTel.Text.ToString(),
                ogrEposta: txtBox_ePosta.Text,
                ogrOkul: txtBox_OkulAdi.Text,
                ogrBolum: txtBox_Bolumu.Text,
                ogrVeliAd: txtBox_VeliAdi.Text,
                ogrVeliSoyad: txtBox_VeliSoyAd.Text,
                ogrVeliCepTel: masked_VeliCepTel.Text.ToString(),
                ogrVeliCepTel2: masked_VeliCepTel2.Text.ToString(),
                ogrVeliAdres: txtBox_VeliAdres.Text,
                ogrYurtBlok: combo_Blok.SelectedItem.ToString()[0],
                ogrYurtKat: int.Parse(combo_Kat.SelectedItem.ToString()),
                ogrYurtOda: int.Parse(combo_Oda.SelectedItem.ToString()),
                ogrYurtYatak: int.Parse(combo_Yatak.SelectedItem.ToString()),
                ogrDogum: date_Dogum.Value,
                ogrKayitTarihi: date_Kayit.Value,
                foto: image);
            if (!OgrenciKontrol(masked_TCKN.Text)) {
                veri.VeriGir();

                int odaID = (int)baglanti.GetData("select * from Oda where oda_blokAdi='" + combo_Blok.SelectedItem.ToString() + "'" +
                    " AND kat_no=" + combo_Kat.SelectedItem.ToString() + "" +
                    " AND oda_no=" + combo_Oda.SelectedItem.ToString() + "").Tables[0].Rows[0][0];
                baglanti.SetData("Update Oda set oda_doluYatak+=" + 1 + " where oda_id=" + odaID + "");

                OgrenciHesapOlustur();
                YoklamaListeleriniOlustur();
                TaksitListeleriniOlustur();

                MessageBox.Show("Kayıt Başarılı!");
                AlanlariTemizle();
            } else {
                MessageBox.Show("Aynı Kimlik Numarasına Sahip Bir Öğrenci Sistemde Kayıtlıdır!");
                return;
            }
        }


        public void TabloGuncelle(string tablo) {

        }

        private void OgrenciHesapOlustur() {
            SqlVeri veri = new OgrenciHesap(ogrTCKN: masked_TCKN.Text,
                                                onOdeme: (int)numeric_OnOdeme.Value,
                                                toplamUcret: (double)numeric_ToplamUcret.Value,
                                                toplamTaksit: (int)numeric_TaksitSayisi.Value,
                                                odenenTaksitler: 0,
                                                kalanUcret: (double)numeric_ToplamUcret.Value,
                                                taksitUcreti: Convert.ToDouble(txtBox_TaksitTutari.Text));
            veri.VeriGir();
        }

        private void TaksitListeleriniOlustur() {
            string query = "create table Taksitler" + masked_TCKN.Text + "(id int identity(1,1) not null, ogrTCKN char(11) not null, taksitTutari decimal(18, 2) not null, taksitOdemeGunu date not null, odemeDurumu bit not null, odendigiGun date not null, constraint Pk_Taksitler" + masked_TCKN.Text + " primary key clustered(id ASC))";
            SqlSunucu taksitBaglantisi = new SqlSunucu(2);
            taksitBaglantisi.SetData(query);

            DataTable dt = new DataTable("Yoklama" + masked_TCKN.Text);

            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("ogrTCKN", typeof(string));
            dt.Columns.Add("taksitTutari", typeof(decimal));
            dt.Columns.Add("taksitOdemeGunu", typeof(DateTime));
            dt.Columns.Add("odemeDurumu", typeof(bool));
            dt.Columns.Add("odendigiGun", typeof(DateTime));


            DateTime taksitGunu = new DateTime(date_Kayit.Value.Year, date_Kayit.Value.Month, Convert.ToInt32(combo_VadeGunu.Text));
            for (int i = 0; i < (int)numeric_TaksitSayisi.Value; i++) {
                var dr = dt.NewRow();
                dr["ogrTCKN"] = masked_TCKN.Text;
                dr["taksitTutari"] = Convert.ToDecimal(txtBox_TaksitTutari.Text);
                dr["taksitOdemeGunu"] = taksitGunu;
                dr["odemeDurumu"] = false;
                dr["odendigiGun"] = DateTime.MinValue;

                taksitGunu = taksitGunu.AddMonths(1);
                dt.Rows.Add(dr);
            }
            taksitBaglantisi.Open();
            using (var bulk = new BulkOperation(taksitBaglantisi.Con)) {
                bulk.DestinationTableName = "Taksitler" + masked_TCKN.Text;
                bulk.BulkInsert(dt);
            }
            taksitBaglantisi.Stop();
        }

        public void YoklamaListeleriniOlustur() {
            string query = "create table Yoklama" + masked_TCKN.Text + "(id int identity(1,1) not null, tarih date not null, durum varchar(100) not null, constraint Pk_Yoklama" + masked_TCKN.Text + " primary key clustered(id ASC))";
            SqlSunucu yoklamaBaglantisi = new SqlSunucu(1);
            yoklamaBaglantisi.SetData(query);

            var baslangicTarihi = date_konaklamaBaslangic.Value;
            var sonGun = baslangicTarihi.AddMonths((int)numeric_KonaklamaAy.Value);
            int toplamKonaklama = Convert.ToInt32((sonGun - baslangicTarihi).TotalDays);

            DataTable dt = new DataTable("Yoklama" + masked_TCKN.Text);

            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("tarih", typeof(DateTime));
            dt.Columns.Add("durum", typeof(string));

            for (int i = 0; i < toplamKonaklama; i++) {
                var dr = dt.NewRow();
                dr["tarih"] = baslangicTarihi;
                dr["durum"] = "yok";
                baslangicTarihi = baslangicTarihi.AddDays(1);
                dt.Rows.Add(dr);
            }
            yoklamaBaglantisi.Open();
            using (var bulk = new BulkOperation(yoklamaBaglantisi.Con)) {
                bulk.DestinationTableName = "Yoklama" + masked_TCKN.Text;
                bulk.BulkInsert(dt);
            }
            yoklamaBaglantisi.Stop();
        }

        private void FotografSec(object sender, EventArgs e) {
            string imgLocation;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png uzantılı(*.png)|*.png|jpg uzantılı(*.jpg)|*.jpg|Tüm Dosyalar(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK) {
                imgLocation = dialog.FileName.ToString();
                picture_OgrenciFoto.ImageLocation = imgLocation;
                ogrenciFoto = FotografBoyutlandir(Image.FromFile(imgLocation), 100, 100);
            }
        }

        //Fotoğrafın Boyutunu Küçülten Fonksiyon. Hazır Alınmıştır.
        private Bitmap FotografBoyutlandir(Image image, int genislik, int yukseklik) {
            var destRect = new Rectangle(0, 0, genislik, yukseklik);
            var destImage = new Bitmap(genislik, yukseklik);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        private void KatDoldur(object sender, EventArgs e) {
            combo_Kat.Items.Clear();
            combo_Oda.Items.Clear();
            combo_Yatak.Items.Clear();
            AramaIslemleri.KatlariDoldur(combo_Blok, combo_Kat);
        }

        private void OdaDoldur(object sender, EventArgs e) {
            combo_Oda.Items.Clear();
            combo_Yatak.Items.Clear();
            AramaIslemleri.OdalariDoldur(combo_Blok, combo_Kat, combo_Oda);
        }

        private void YatakDoldur(object sender, EventArgs e) {
            List<int> yataklar = new List<int>();
            combo_Yatak.Items.Clear();
            int kapasite, doluYatak;
            string query;
            query = "select oda_kapasite from Oda where oda_blokAdi='" + combo_Blok.SelectedItem.ToString()[0] + "' AND kat_no=" + Convert.ToInt32(combo_Kat.SelectedItem) + " AND oda_no=" + Convert.ToInt32(combo_Oda.SelectedItem) + "";
            var sdr = new SqlSunucu(0).Read(query);
            sdr.Read();
            kapasite = Convert.ToInt32(sdr.GetValue(0));
            for (int i = 0; i < kapasite; i++) {
                yataklar.Add(i + 1);
            }

            query = "select oda_doluYatak from Oda where oda_blokAdi='" + combo_Blok.SelectedItem.ToString()[0] + "' AND kat_no=" + Convert.ToInt32(combo_Kat.SelectedItem) + " AND oda_no=" + Convert.ToInt32(combo_Oda.SelectedItem) + "";
            sdr = new SqlSunucu(0).Read(query);
            sdr.Read();
            doluYatak = Convert.ToInt32(sdr.GetValue(0));
            if (kapasite == doluYatak) {
                MessageBox.Show("Seçilen Odada Boş Yatak Kalmamıştır.\n" +
                                "Lütfen Başka Bir Oda Seçiniz!");
                combo_Oda.Items.Clear();
            } else {
                query = "select ogrYurtYatak from Ogrenci where ogrYurtBlok='" + combo_Blok.SelectedItem.ToString()[0] + "' AND ogrYurtKat=" + Convert.ToInt32(combo_Kat.SelectedItem) + " AND ogrYurtOda=" + Convert.ToInt32(combo_Oda.SelectedItem) + "";
                sdr = new SqlSunucu(0).Read(query);
                while (sdr.Read()) {
                    yataklar.Remove(Convert.ToInt32(sdr.GetValue(0)));
                }
                foreach (var item in yataklar) {
                    combo_Yatak.Items.Add(item);
                }
            }
        }

        private void OnOdemeAktif(object sender, EventArgs e) {
            numeric_OnOdeme.Enabled = true;
        }

        private void TaksitHesapla(object sender, EventArgs e) {
            txtBox_TaksitTutari.Text = ((numeric_ToplamUcret.Value - numeric_OnOdeme.Value) / numeric_TaksitSayisi.Value).ToString("0.00");
        }

        private void AlanlariTemizle() {
            picture_OgrenciFoto = null;
            txtBox_Ad.Text = "";
            txtBox_Bolumu.Text = "";
            txtBox_ePosta.Text = "";
            txtBox_OkulAdi.Text = "";
            txtBox_Soyad.Text = "";
            txtBox_TaksitTutari.Text = "";
            txtBox_VeliAdi.Text = "";
            txtBox_VeliAdres.Text = "";
            txtBox_VeliSoyAd.Text = "";
            masked_CepTel.Text = "";
            masked_TCKN.Text = "";
            masked_VeliCepTel.Text = "";
            masked_VeliCepTel2.Text = "";
            combo_Yatak.Items.Clear();
            numeric_OnOdeme.Value = numeric_OnOdeme.Minimum;
            numeric_TaksitSayisi.Value = numeric_TaksitSayisi.Minimum;
            numeric_ToplamUcret.Value = numeric_ToplamUcret.Minimum;
        }

        private bool OgrenciKontrol(string kullaniciAdi) {
            string query = "select ogrTCKN from Ogrenci";
            DataTable tablo = baglanti.TabloOku(query);
            bool check = false;

            for (int i = 0; i < tablo.Rows.Count; i++) {
                if (tablo.Rows[i]["ogrTCKN"].ToString() == kullaniciAdi)
                    check = true;
            }

            return check;
        }
    }
}
