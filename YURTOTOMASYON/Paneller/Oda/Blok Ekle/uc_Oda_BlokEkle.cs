using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon.Paneller.Oda.Blok_Ekle {
    public partial class uc_Oda_BlokEkle : UserControl, IIslemler, IPanel {
        private SqlSunucu baglanti = new SqlSunucu(0);
        public uc_Oda_BlokEkle() {
            InitializeComponent();
        }

        public void PanelYukle(object sender, EventArgs e) {
            TabloGuncelle("Blok");

            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].HeaderText = "Blok Adı:";
            dataGrid.Columns[2].HeaderText = "Kat Sayısı:";
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            try {
                SqlVeri blok = new Blok(tabloAdi: "Blok",
                                        blokAD: combo_Blok.SelectedItem.ToString()[0],
                                        katSayisi: Convert.ToInt32(numeric_Kat.Value));
                blok.VeriGir();
                TabloGuncelle(blok.tabloAdi);
            } catch (NullReferenceException) {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            } catch (SqlException) {
                MessageBox.Show("Sunucu Bağlantı Hatası!");
            }
        }

        public void TabloGuncelle(string tablo) {
            dataGrid.DataSource = baglanti.DataGridDoldur(tablo);
            for (int i = 0; i < dataGrid.Rows.Count; i++) {
                string blok = dataGrid.Rows[i].Cells["blokAD"].Value.ToString();
                if (combo_Blok.Items.Contains(blok)) {
                    combo_Blok.Items.Remove(blok);
                }
            }
        }
    }
}
