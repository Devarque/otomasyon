using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon.Paneller.Yonetici.Sil {
    public partial class uc_Yonetici_Sil : UserControl, IPanel, IIslemler {
        public int? silinecekID;
        private SqlSunucu baglanti = new SqlSunucu(0);
        public uc_Yonetici_Sil() {
            InitializeComponent();
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            try {
                SqlVeri veri = new Veriler.Yonetici("Yonetici");
                if (silinecekID.Value != 1) {
                    veri.VeriSil(silinecekID.Value);
                } else {
                    MessageBox.Show("Varsayılan Yönetici Silinemez!");
                    return;
                }
                TabloGuncelle(veri.tabloAdi);
                silinecekID = null;
            } catch (SqlException) {
                MessageBox.Show("Sunucu Bağlantı Hatası!");
            } catch (InvalidOperationException) {
                MessageBox.Show("Lütfen Silinecek Yöneticiyi Seçiniz!");
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

        public void TabloGuncelle(string tablo) {
            dataGrid.DataSource = baglanti.DataGridDoldur(tablo);
            dataGrid.ClearSelection();
        }

        private void VeriSec(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex != -1)
                silinecekID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
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
