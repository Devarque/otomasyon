using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Yurt_Otomasyon.Extensions;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Paneller.Yoklama.Duzenle {
    public partial class uc_Yoklama_Duzenle : UserControl, IIslemler, IPanel {
        private string TCKN;
        private SqlSunucu ogrBaglanti = new SqlSunucu(0);
        private SqlSunucu yoklamaBaglanti = new SqlSunucu(1);

        public uc_Yoklama_Duzenle() {
            InitializeComponent();
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            try {
                if (masked_TCKN.Text.Length == 11) {
                    string query;
                    if (check_ay.Checked) {
                        query = "select * from Yoklama" + TCKN + " where datepart(month, tarih)=" + date_Yoklama.Value.Month + " AND datepart(year, tarih)=" + date_Yoklama.Value.Year;
                        dataGrid.DataSource = yoklamaBaglanti.TabloOku(query);
                    } else if (check_gun.Checked) {
                        query = "select * from Yoklama" + TCKN + " where tarih='" + date_Yoklama.Value.ToString("yyyy-MM-dd") + "'";
                        dataGrid.DataSource = yoklamaBaglanti.TabloOku(query);
                    }

                    DurumSutunlariniEkle();

                    dataGrid.Columns[0].Visible = false;
                    dataGrid.Columns[1].HeaderText = "Tarih:";
                    dataGrid.Columns[2].Visible = false;
                } else {
                    MessageBox.Show("Lütfen 11 Haneli Kimlik Numarasını Giriniz!");
                }
            } catch (SqlException) {
                MessageBox.Show("Girilen Kimlik Numarasına Sahip Herhangi Bir Öğrenci Bulunmamaktadır!");
            }
        }

        private void DurumSutunlariniEkle() {
            if (dataGrid.Columns.Contains("var") && dataGrid.Columns.Contains("yok") && dataGrid.Columns.Contains("izinli")) {
                dataGrid.Columns.Remove("var");
                dataGrid.Columns.Remove("yok");
                dataGrid.Columns.Remove("izinli");
            }
            if (!dataGrid.Columns.Contains("var") && !dataGrid.Columns.Contains("yok") && !dataGrid.Columns.Contains("izinli")) {
                dataGrid.Columns.Add("var", "Var");
                dataGrid.Columns.Add("yok", "Yok");
                dataGrid.Columns.Add("izinli", "Izinli");

                for (int i = 0; i < dataGrid.Rows.Count; i++) {
                    switch (dataGrid.Rows[i].Cells["durum"].Value.ToString()) {
                        case "var":
                            dataGrid.Rows[i].Cells["var"].Style.BackColor = Color.Green;
                            dataGrid.Rows[i].Cells["var"].Value = "X";
                            dataGrid.Rows[i].Cells["yok"].Value = " ";
                            dataGrid.Rows[i].Cells["izinli"].Value = " ";
                            break;
                        case "yok":
                            dataGrid.Rows[i].Cells["yok"].Style.BackColor = Color.Red;
                            dataGrid.Rows[i].Cells["yok"].Value = "X";
                            dataGrid.Rows[i].Cells["var"].Value = " ";
                            dataGrid.Rows[i].Cells["izinli"].Value = " ";
                            break;
                        case "izinli":
                            dataGrid.Rows[i].Cells["izinli"].Style.BackColor = Color.Yellow;
                            dataGrid.Rows[i].Cells["izinli"].Value = "X";
                            dataGrid.Rows[i].Cells["yok"].Value = " ";
                            dataGrid.Rows[i].Cells["var"].Value = " ";
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void PanelYukle(object sender, EventArgs e) {
            dataGrid.DataSource = null;
        }

        public void TabloGuncelle(string tablo) {
        }

        private void AyAktif(object sender, EventArgs e) {
            check_ay.Checked = true;
            check_gun.Checked = false;
        }

        private void GunAktif(object sender, EventArgs e) {
            check_ay.Checked = false;
            check_gun.Checked = true;
        }

        private void DinamikAra(object sender, EventArgs e) {
            if (masked_TCKN.Text.Length > 0 && masked_TCKN.Text.Length != 11)
                dataGrid_arama.Visible = true;
            else
                dataGrid_arama.Visible = false;

            string query;
            if (masked_TCKN.Text.Length > 0) {
                query = "select ogrAd, ogrSoyad, ogrTCKN  from Ogrenci where ogrTCKN LIKE '%" + masked_TCKN.Text + "%'";
                dataGrid_arama.DataSource = ogrBaglanti.TabloOku(query);

                dataGrid_arama.Columns["ogrAd"].HeaderText = "Ad:";
                dataGrid_arama.Columns["ogrSoyad"].HeaderText = "Soyad:";
                dataGrid_arama.Columns["ogrTCKN"].HeaderText = "TCKN:";
            }
        }

        private void OgrenciSec(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex != -1) {
                TCKN = dataGrid_arama.Rows[e.RowIndex].Cells["ogrTCKN"].Value.ToString();
                masked_TCKN.Text = TCKN;

                dataGrid_arama.Visible = false;
            }
        }

        private void VeriSec(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex != -1) {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5) {
                    string query = "update Yoklama" + TCKN + " set durum='";
                    switch (e.ColumnIndex) {
                        case 3:
                            query += "var'";
                            dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Green;
                            dataGrid.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Green;
                            dataGrid.Rows[e.RowIndex].Cells[3].Value = "X";
                            dataGrid.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.FromArgb(235, 221, 240);
                            dataGrid.Rows[e.RowIndex].Cells[4].Value = " ";
                            dataGrid.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.FromArgb(235, 221, 240);
                            dataGrid.Rows[e.RowIndex].Cells[5].Value = " ";
                            break;
                        case 4:
                            query += "yok'";
                            dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Red;
                            dataGrid.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.FromArgb(235, 221, 240);
                            dataGrid.Rows[e.RowIndex].Cells[3].Value = " ";
                            dataGrid.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.Red;
                            dataGrid.Rows[e.RowIndex].Cells[4].Value = "X";
                            dataGrid.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.FromArgb(235, 221, 240);
                            dataGrid.Rows[e.RowIndex].Cells[5].Value = " ";
                            break;
                        case 5:
                            query += "izinli'";
                            dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Yellow;
                            dataGrid.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.FromArgb(235, 221, 240);
                            dataGrid.Rows[e.RowIndex].Cells[3].Value = " ";
                            dataGrid.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.Yellow;
                            dataGrid.Rows[e.RowIndex].Cells[5].Value = "X";
                            dataGrid.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.FromArgb(235, 221, 240);
                            dataGrid.Rows[e.RowIndex].Cells[4].Value = " ";
                            break;
                        default:
                            break;
                    }
                    query += " where id=" + dataGrid.Rows[e.RowIndex].Cells["id"].Value;
                    yoklamaBaglanti.SetData(query);
                }
            }
        }

        private void Formatla(object sender, EventArgs e) {
            dataGrid.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void CiktiOlustur(object sender, EventArgs e) {
            dataGrid.Columns.Remove("durum");
            dataGrid.PdfeAktar(TCKN + "Yoklama", 0);
            IslemGerceklestir(null, null);
        }
    }
}
