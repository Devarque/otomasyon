using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Extensions;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon.Paneller.Ogrenci.Sil {
    public partial class uc_Ogrenci_Sil : UserControl, IPanel, IIslemler {
        SqlSunucu baglanti = new SqlSunucu(0);
        private int odaID;

        private Veriler.Ogrenci silinecekOgrenci;

        public uc_Ogrenci_Sil() {
            InitializeComponent();
        }

        public void PanelYukle(object sender, EventArgs e) {
            TabloGuncelle("Ogrenci");

            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].HeaderText = "Ad:";
            dataGrid.Columns[2].HeaderText = "Soyad:";
            dataGrid.Columns[3].HeaderText = "TCKN:";
            dataGrid.Columns[4].HeaderText = "Doğum Tarihi:";
            dataGrid.Columns[5].HeaderText = "Kayıt Tarihi";
            dataGrid.Columns[6].HeaderText = "Kan Grubu";
            dataGrid.Columns[7].HeaderText = "Cep Tel:";
            dataGrid.Columns[8].HeaderText = "E-Posta:";
            dataGrid.Columns[9].HeaderText = "Okul:";
            dataGrid.Columns[10].HeaderText = "Bölüm:";
            dataGrid.Columns[11].HeaderText = "Veli Ad:";
            dataGrid.Columns[12].HeaderText = "Veli Soyad:";
            dataGrid.Columns[13].HeaderText = "Veli Cep Tel:";
            dataGrid.Columns[14].HeaderText = "Veli Cep Tel2:";
            dataGrid.Columns[15].HeaderText = "Veli Adres:";
            dataGrid.Columns[16].HeaderText = "Blok:";
            dataGrid.Columns[17].HeaderText = "Kat:";
            dataGrid.Columns[18].HeaderText = "Oda:";
            dataGrid.Columns[19].HeaderText = "Yatak:";
            dataGrid.Columns[20].HeaderText = "Fotoğraf:";

            combo_Blok.VeriTabanindanDoldur("Blok", "blokAD");

        }

        public void TabloGuncelle(string tablo) {
            dataGrid.DataSource = baglanti.DataGridDoldur(tablo);
            dataGrid.ClearSelection();
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

        public void IslemGerceklestir(object sender, EventArgs a) {
            var btn = (Guna2Button)sender;
            if (btn.Tag.ToString() == "sil") {
                try {
                    //öğrenci yoklamalarını sil
                    SqlSunucu yoklamaBaglanti = new SqlSunucu(1);
                    yoklamaBaglanti.SetData("drop table Yoklama" + silinecekOgrenci.OgrTCKN);

                    //öğrenci sil
                    SqlVeri veri = new Veriler.Ogrenci("Ogrenci");
                    veri.VeriSil(silinecekOgrenci.Id);
                    TabloGuncelle(veri.tabloAdi);

                    //oda yatak sayısını 1 arttır
                    odaID = (int)baglanti.TabloOku("select * from Oda where oda_blokAdi='" + silinecekOgrenci.OgrYurtBlok + "'" +
                                       " AND kat_no=" + silinecekOgrenci.OgrYurtKat + "" +
                                       " AND oda_no=" + silinecekOgrenci.OgrYurtOda + "").Rows[0][0];
                    baglanti.SetData("update Oda set oda_doluYatak-=" + 1 + " where oda_id=" + odaID + "");
                } catch (NullReferenceException) {
                    MessageBox.Show("Lütfen Listeden Silinecek Öğrenciyi Seçmeyi Unutmayınız!");
                } catch (SqlException) {
                    MessageBox.Show("Sunucu Bağlantı Hatası!");
                }
            } else {
                try {
                    string query = "select * from Ogrenci where ogrYurtBlok='" + combo_Blok.SelectedItem.ToString() + "'";
                    if (combo_Oda.SelectedIndex != -1) {
                        query += " AND ogrYurtKat='" + combo_Kat.SelectedItem + "' AND ogrYurtOda='" + combo_Oda.SelectedItem + "'";
                        dataGrid.DataSource = baglanti.TabloOku(query);
                    } else if (combo_Kat.SelectedIndex != -1) {
                        query += " AND ogrYurtKat='" + combo_Kat.SelectedItem + "'";
                        dataGrid.DataSource = baglanti.TabloOku(query);
                    } else {
                        dataGrid.DataSource = baglanti.TabloOku(query);
                    }
                    silinecekOgrenci = null;
                } catch (NullReferenceException) {
                    MessageBox.Show("Lütfen Blok Seçmeyi Unutmayınız!");
                } catch (SqlException) {
                    MessageBox.Show("Sunucu Bağlantı Hatası!");
                }
            }
        }

        private void DinamikAra(object sender, EventArgs e) {
            silinecekOgrenci = null;
            string query;
            if (masked_TCKN.Text.Length > 0) {
                query = "select * from Ogrenci where ogrTCKN LIKE '%" + masked_TCKN.Text + "%'";
            } else {
                query = "select * from Ogrenci";
            }
            dataGrid.DataSource = baglanti.TabloOku(query);
        }

        private void VeriSec(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex != -1) {
                string ogrenciSQL = "select * from Ogrenci where ogrTCKN='" + dataGrid.Rows[e.RowIndex].Cells["ogrTCKN"].Value.ToString() + "'";
                silinecekOgrenci = new Veriler.Ogrenci(baglanti.TabloOku(ogrenciSQL));
            }
        }
    }
}
