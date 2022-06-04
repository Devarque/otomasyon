using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Extensions;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon.Paneller.Oda.Oda_Sil {
    public partial class uc_Oda_OdaSil : UserControl, IIslemler, IPanel {
        private SqlSunucu baglanti = new SqlSunucu(0);
        private Veriler.Oda silinecekOda;

        public uc_Oda_OdaSil() {
            InitializeComponent();
        }
        public void PanelYukle(object sender, EventArgs e) {
            TabloGuncelle("Oda");
            combo_Blok.Items.Clear();
            combo_Kat.Items.Clear();
            combo_Oda.Items.Clear();

            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].HeaderText = "ODA NO:";
            dataGrid.Columns[2].HeaderText = "BLOK:";
            dataGrid.Columns[3].HeaderText = "KAT:";
            dataGrid.Columns[4].HeaderText = "YATAK SAYISI:";
            dataGrid.Columns[5].HeaderText = "DOLU YATAK:";
            combo_Blok.VeriTabanindanDoldur("Blok", "blokAD");
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            var btn = (Guna2Button)sender;
            if (btn.Tag.ToString() == "sil") {
                try {
                    //Odadaki Öğrencilerin Yoklama Tabloları Silinir
                    DataTable ogrenciler = baglanti.TabloOku("select ogrTCKN from Ogrenci" +
                                                             " where ogrYurtBlok ='" + silinecekOda.OdaBlokAd + "'" +
                                                             " AND ogrYurtKat=" + silinecekOda.KatNo +
                                                             " AND ogrYurtOda=" + silinecekOda.OdaNo);
                    baglanti = new SqlSunucu(1);
                    for (int i = 0; i < ogrenciler.Rows.Count; i++) {
                        baglanti.SetData("drop table Yoklama" + ogrenciler.Rows[i]["ogrTCKN"].ToString());
                    }
                    //Odadaki Öğrenciler Silinir
                    baglanti = new SqlSunucu(0);
                    baglanti.SetData("delete from Ogrenci" +
                                     " where ogrYurtBlok ='" + silinecekOda.OdaBlokAd + "'" +
                                     " AND ogrYurtKat=" + silinecekOda.KatNo +
                                     " AND ogrYurtOda=" + silinecekOda.OdaNo);
                    //Odanın Kendisi Silinir
                    SqlVeri veri = new Veriler.Oda("Oda");
                    veri.VeriSil(silinecekOda.ID);
                    TabloGuncelle(veri.tabloAdi);
                } catch (NullReferenceException) {
                    MessageBox.Show("Lütfen Tablodan Silinecek Odayı Seçiniz!");
                } catch (SqlException) {
                    MessageBox.Show("Sunucu Bağlantı Hatası!");
                }
            } else {
                try {
                    silinecekOda = null;
                    string query = "select * from Oda where oda_blokAdi='" + combo_Blok.SelectedItem.ToString() + "'";
                    if (combo_Oda.SelectedIndex != -1) {
                        query += " AND kat_no='" + combo_Kat.SelectedItem + "' AND oda_no='" + combo_Oda.SelectedItem + "'";
                        dataGrid.DataSource = baglanti.TabloOku(query);
                        dataGrid.ClearSelection();
                    } else if (combo_Kat.SelectedIndex != -1) {
                        query += " AND kat_no='" + combo_Kat.SelectedItem + "'";
                        dataGrid.DataSource = baglanti.TabloOku(query);
                        dataGrid.ClearSelection();
                    } else {
                        dataGrid.DataSource = baglanti.TabloOku(query);
                        dataGrid.ClearSelection();
                    }
                } catch (NullReferenceException) {
                    MessageBox.Show("Lütfen Blok Seçmeyi Unutmayınız!");
                } catch (SqlException) {
                    MessageBox.Show("Sunucu Bağlantı Hatası!");
                }
            }
        }

        private void KatlariDoldur(object sender, EventArgs e) {
            combo_Kat.Items.Clear();
            combo_Oda.Items.Clear();
            AramaIslemleri.KatlariDoldur(combo_Blok, combo_Kat);
        }

        private void OdalariDoldur(object sender, EventArgs e) {
            combo_Oda.Items.Clear();
            AramaIslemleri.OdalariDoldur(combo_Blok, combo_Kat, combo_Oda);
        }

        public void TabloGuncelle(string tablo) {
            dataGrid.DataSource = baglanti.DataGridDoldur(tablo);
            dataGrid.ClearSelection();
        }

        private void VeriSec(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex != -1) {
                silinecekOda = new Veriler.Oda(
                    id: Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["oda_id"].Value),
                    odaNo: Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["oda_no"].Value),
                    odaBlokAd: dataGrid.Rows[e.RowIndex].Cells["oda_blokAdi"].Value.ToString()[0],
                    katNo: Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["kat_no"].Value));
            }
        }

    }
}
