using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Yurt_Otomasyon.Extensions;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon.Paneller.Oda.Oda_Ekle {
    public partial class uc_Oda_OdaEkle : UserControl, IIslemler, IPanel {
        private SqlSunucu baglanti = new SqlSunucu(0);
        public uc_Oda_OdaEkle() {
            InitializeComponent();
        }
        public void PanelYukle(object sender, EventArgs e) {
            TabloGuncelle("Oda");

            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].HeaderText = "ODA NO:";
            dataGrid.Columns[2].HeaderText = "BLOK:";
            dataGrid.Columns[3].HeaderText = "KAT:";
            dataGrid.Columns[4].HeaderText = "YATAK SAYISI:";
            dataGrid.Columns[5].HeaderText = "DOLU YATAK";
            combo_Blok.VeriTabanindanDoldur("Blok", "blokAD");
        }


        public void IslemGerceklestir(object sender, EventArgs a) {
            if (combo_Blok.SelectedIndex != -1
                && combo_Kat.SelectedIndex != -1
                && Convert.ToInt32(numeric_Oda.Value) != 0
                && Convert.ToInt32(numeric_Kapasite.Value) != 0) {
                //Seçilen Değerlere Göre Yeni Odayı Oluşturur
                SqlVeri veri = new Veriler.Oda(
                    tabloAdi: "Oda",
                    odaNo: Convert.ToInt32(numeric_Oda.Value),
                    odaBlokAd: combo_Blok.SelectedItem.ToString()[0],
                    katNo: Convert.ToInt32(combo_Kat.SelectedItem),
                    kapasite: Convert.ToInt32(numeric_Kapasite.Value),
                    doluYatak: 0);

                //Seçilen Blok ve Kattaki Tüm Odaların Listesi Okunur
                string query = "select * from Oda" +
                    " where oda_blokAdi='" + combo_Blok.SelectedItem.ToString() + "'" +
                    " AND kat_no=" + Convert.ToInt32(combo_Kat.SelectedItem);
                DataTable odalarTablosu = baglanti.TabloOku(query);
                List<int> odalar = new List<int>();
                for (int i = 0; i < odalarTablosu.Rows.Count; i++) {
                    odalar.Add(Convert.ToInt32(odalarTablosu.Rows[i]["oda_no"]));
                }

                //Eğer Eklenecek Oda Numarasına Sahip Herhangi Bir Oda Yoksa Odayı Başarıyla Ekler
                if (odalar.Contains((int)numeric_Oda.Value)) {
                    MessageBox.Show("Aynı Oda Numarasına Sahip Bir Oda Bulunmakta! Lütfen Yeni Bir Oda Numarası Seçiniz!");
                } else {
                    veri.VeriGir();
                    TabloGuncelle(veri.tabloAdi);
                    MessageBox.Show("Oda Başarıyla Eklendi!");
                }
            } else {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }
        }

        public void TabloGuncelle(string tablo) {
            dataGrid.DataSource = baglanti.DataGridDoldur(tablo);
        }

        private void KatlariDoldur(object sender, EventArgs e) {
            combo_Kat.Items.Clear();
            AramaIslemleri.KatlariDoldur(combo_Blok, combo_Kat);
        }
    }
}
