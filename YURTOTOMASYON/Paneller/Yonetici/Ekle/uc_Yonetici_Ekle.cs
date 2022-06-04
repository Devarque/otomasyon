using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon.Paneller.Yonetici.Ekle {
    public partial class uc_Yonetici_Ekle : UserControl, IPanel, IIslemler {
        SqlSunucu baglanti = new SqlSunucu(0);
        public uc_Yonetici_Ekle() {
            InitializeComponent();
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            try {
                SqlVeri veri = new Veriler.Yonetici(
                    tabloAdi: "Yonetici",
                    yoneticiAd: txtBox_Ad.Text,
                    yoneticiSoyad: txtBox_SoyAd.Text,
                    yoneticiTCKN: masked_TCKN.Text.ToString(),
                    yoneticiCepTel: masked_Cep.Text.ToString(),
                    yoneticiEposta: txtBox_ePosta.Text,
                    yoneticiKullaniciAdi: txtBox_KullaniciAdi.Text,
                    yoneticiSifre: txtBox_Sifre.Text);

                if (!KullaniciKontrol(txtBox_KullaniciAdi.Text)) {
                    veri.VeriGir();
                } else {
                    MessageBox.Show("Aynı Kullanıcı Adına Sahip Başka Bir Yönetici Bulunmakta!");
                    return;
                }

                TabloGuncelle(veri.tabloAdi);

                txtBox_Ad.Clear();
                txtBox_SoyAd.Clear();
                txtBox_ePosta.Clear();
                txtBox_KullaniciAdi.Clear();
                txtBox_Sifre.Clear();
                masked_Cep.Clear();
                masked_TCKN.Clear();
            } catch (NullReferenceException) {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            } catch (SqlException) {
                MessageBox.Show("Sunucu Bağlantı Hatası!");
            }
        }

        public void PanelYukle(object sender, EventArgs e) {
            TabloGuncelle("Yonetici");

            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].HeaderText = "Ad:";
            dataGrid.Columns[2].HeaderText = "Soyad:";
            dataGrid.Columns[3].HeaderText = "TCKN:";
            dataGrid.Columns[4].HeaderText = "Cep:";
            dataGrid.Columns[5].HeaderText = "E-Posta:";
            dataGrid.Columns[6].HeaderText = "Kullanıcı Adı:";
            dataGrid.Columns[7].HeaderText = "Şifre:";
        }

        private bool KullaniciKontrol(string kullaniciAdi) {
            string query = "select yoneticiKullaniciAdi from Yonetici";
            DataTable tablo = baglanti.TabloOku(query);
            bool check = false;

            for (int i = 0; i < tablo.Rows.Count; i++) {
                if (tablo.Rows[i]["yoneticiKullaniciAdi"].ToString() == kullaniciAdi)
                    check = true;
            }

            return check;
        }

        public void TabloGuncelle(string tablo) {
            dataGrid.DataSource = baglanti.DataGridDoldur(tablo);
        }

        private void HucreFormatla(object sender, DataGridViewCellFormattingEventArgs e) {
            for (int i = 0; i < dataGrid.Rows.Count; i++) {
                if (e.ColumnIndex == 7 && e.Value != null) {
                    e.Value = new string('*', 10);
                }
            }
        }
    }
}
