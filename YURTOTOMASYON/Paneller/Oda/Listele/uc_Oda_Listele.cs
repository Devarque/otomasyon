using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Extensions;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Paneller.Oda.Listele {
    public partial class uc_Oda_Listele : UserControl, IPanel, IIslemler {
        private SqlSunucu baglanti = new SqlSunucu(0);
        public uc_Oda_Listele() {
            InitializeComponent();
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            try {
                string query = "SELECT * FROM Oda WHERE oda_blokAdi='" + combo_Blok.SelectedItem.ToString() + "'";

                if (combo_Kat.SelectedIndex != -1) {
                    query += " AND kat_no='" + combo_Kat.SelectedItem + "'";
                    dataGrid.DataSource = baglanti.TabloOku(query);
                } else {
                    dataGrid.DataSource = baglanti.TabloOku(query);
                }
            } catch (NullReferenceException) {
                MessageBox.Show("Lütfen Blok Seçmeyi Unutmayınız!");
            } catch (SqlException) {
                MessageBox.Show("Sunucu Bağlantı Hatası!");
            }
        }

        public void PanelYukle(object sender, EventArgs e) {
            TabloGuncelle("Oda");

            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].HeaderText = "ODA NO:";
            dataGrid.Columns[2].HeaderText = "BLOK:";
            dataGrid.Columns[3].HeaderText = "KAT:";
            dataGrid.Columns[4].HeaderText = "YATAK SAYISI:";
            dataGrid.Columns[5].HeaderText = "DOLU YATAK:";

            combo_Blok.VeriTabanindanDoldur("Blok", "blokAD");
            combo_Kat.Items.Clear();
        }

        public void KatlariDoldur(object sender, EventArgs e) {
            combo_Kat.Items.Clear();
            AramaIslemleri.KatlariDoldur(combo_Blok, combo_Kat);
        }

        public void TabloGuncelle(string tablo) {
            dataGrid.DataSource = baglanti.DataGridDoldur(tablo);
        }

        private void CiktiOlustur(object sender, EventArgs e) {
            dataGrid.PdfeAktar("Oda Listesi", 0);
        }
    }
}
