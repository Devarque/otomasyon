using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Extensions;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Paneller.Odeme.Listele {
    public partial class uc_Odeme_Listele : UserControl, IIslemler, IPanel {
        private SqlSunucu ogrenciBaglanti = new SqlSunucu(0);
        private SqlSunucu taksitBaglanti = new SqlSunucu(2);
        private bool flag = false;
        public uc_Odeme_Listele() {
            InitializeComponent();
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            if (masked_TCKN.Text.Length == 11) {
                try {
                    DataTable taksitler = null;
                    if (check_Yil.Checked) {
                        if (masked_YilSec.Text.Length != 0) {
                            taksitler = taksitBaglanti.TabloOku("select * from Taksitler" + masked_TCKN.Text + " where odemeDurumu=1 AND datepart(year, taksitOdemeGunu)=" + masked_YilSec.Text);
                        } else {
                            MessageBox.Show("Lütfen Yıl Girmeyi Unutmayınız!");
                            return;
                        }
                    } else {
                        taksitler = taksitBaglanti.TabloOku("select * from Taksitler" + masked_TCKN.Text + " where odemeDurumu=1");
                    }
                    if (taksitler.Rows.Count != 0) {
                        if (!flag) {
                            dataGrid.Columns.Add("t", "T");
                            flag = true;
                        }
                        dataGrid.DataSource = taksitler;

                        dataGrid.Columns[0].Visible = false;
                        dataGrid.Columns[1].HeaderText = "Taksit Numarası:";
                        dataGrid.Columns[2].HeaderText = "Ögrenci TCKN:";
                        dataGrid.Columns[3].HeaderText = "Tutar:";
                        dataGrid.Columns[4].HeaderText = "Ödeme Günü:";
                        dataGrid.Columns[5].HeaderText = "Ödenme Durumu:";
                        dataGrid.Columns[6].HeaderText = "Ödendigi Tarih:";
                    } else {
                        if (check_Yil.Checked) {
                            MessageBox.Show("Girilen Yılda Ödenmiş Herhangi Bir Taksit Bulunmamaktadır!");
                        } else {
                            MessageBox.Show("Seçilen Öğrencinin Ödenmiş Herhangi Bir Taksiti Bulunmamaktadır!");
                        }
                    }
                } catch (SqlException) {
                    MessageBox.Show("Girilen Kimlik Numarasına Sahip Herhangi Bir Öğrenci Sistemde Kayıtlı Değildir!");
                }
            } else {
                MessageBox.Show("Lütfen 11 Haneli Kimlik Numarasını Giriniz!");
            }

        }

        public void PanelYukle(object sender, EventArgs e) {
            TabloGuncelle("Odeme");
        }

        public void TabloGuncelle(string tablo) {
        }

        private void CiktiOlustur(object sender, EventArgs e) {
            dataGrid.PdfeAktar("Ödeme Listesi", 0);
        }

        private void DinamikAra(object sender, EventArgs e) {
            if (masked_TCKN.Text.Length > 0 && masked_TCKN.Text.Length != 11)
                dataGrid_arama.Visible = true;
            else
                dataGrid_arama.Visible = false;
            string query;
            if (masked_TCKN.Text.Length > 0) {
                query = "select ogrAd, ogrSoyad, ogrTCKN  from Ogrenci where ogrTCKN LIKE '%" + masked_TCKN.Text + "%'";
                dataGrid_arama.DataSource = ogrenciBaglanti.TabloOku(query);

                dataGrid_arama.Columns["ogrAd"].HeaderText = "Ad:";
                dataGrid_arama.Columns["ogrSoyad"].HeaderText = "Soyad:";
                dataGrid_arama.Columns["ogrTCKN"].HeaderText = "TCKN:";
            }
        }

        private void OgrenciSec(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex != -1) {
                masked_TCKN.Text = dataGrid_arama.Rows[e.RowIndex].Cells["ogrTCKN"].Value.ToString();
                dataGrid_arama.Visible = false;
            }
        }

    }
}
