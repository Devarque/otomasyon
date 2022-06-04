using System;
using System.Data;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon.Paneller.Oda.Blok_Sil {
    public partial class uc_Oda_BlokSil : UserControl, IIslemler, IPanel {
        private SqlSunucu baglanti = new SqlSunucu(0);
        public int? silinecekveriID;
        public string silinecekBlok;
        public uc_Oda_BlokSil() {
            InitializeComponent();
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            if (!silinecekveriID.HasValue || (silinecekveriID.Value == dataGrid.Rows.Count - 1))
                MessageBox.Show("Lütfen Tablodan Silinecek Veriyi Seçiniz!");
            else {
                SqlVeri veri = new Blok("Blok");
                veri.VeriSil(silinecekveriID.Value);
                //Yoklamalar Silinir
                DataTable ogrenciler = baglanti.TabloOku("select ogrTCKN from Ogrenci where ogrYurtBlok ='" + silinecekBlok[0].ToString() + "'");
                baglanti = new SqlSunucu(1);
                for (int i = 0; i < ogrenciler.Rows.Count; i++) {
                    baglanti.SetData("drop table Yoklama" + ogrenciler.Rows[i]["ogrTCKN"].ToString());
                }
                baglanti = new SqlSunucu(0);
                //Öğrenciler Silinir
                baglanti.SetData("delete from Ogrenci where ogrYurtBlok='" + silinecekBlok[0].ToString() + "'");
                //Odalar Silinir
                baglanti.SetData("delete from Oda where oda_blokAdi='" + silinecekBlok[0].ToString() + "'");

                TabloGuncelle("Blok");
                MessageBox.Show("Blok Ve Bağlı Birimler Başarıyla Silindi!");
            }
        }

        public void PanelYukle(object sender, EventArgs e) {
            TabloGuncelle("Blok");
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].HeaderText = "Blok Adı:";
            dataGrid.Columns[2].HeaderText = "Kat Sayısı:";
        }

        public void TabloGuncelle(string tablo) {
            dataGrid.DataSource = baglanti.DataGridDoldur(tablo);
            dataGrid.ClearSelection();
        }

        private void VeriSec(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex != -1) {
                silinecekveriID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
                silinecekBlok = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            } 
        }
    }
}
