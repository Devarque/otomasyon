using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon.Paneller.Odeme.Ekle {
    public partial class uc_Odeme_Ekle : UserControl, IIslemler, IPanel {
        private SqlSunucu ogrenciBaglanti = new SqlSunucu(0);
        private SqlSunucu taksitBaglanti = new SqlSunucu(2);
        private OgrenciHesap ogrenciHesap;
        private bool taksitSecildi;
        private int odenecekTaksitID;
        private int secilenSatirNo;
        private bool flag = false;
        public uc_Odeme_Ekle() {
            InitializeComponent();
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
            Guna2Button buton = (Guna2Button)sender;
            if (buton.Tag.ToString() == "ara") {
                if (masked_TCKN.Text.Length == 11) {
                    try {
                        DataTable taksitler = null;
                        if (check_Yil.Checked) {
                            if (masked_YilSec.Text.Length != 0) {
                                taksitler = taksitBaglanti.TabloOku("select * from Taksitler" + masked_TCKN.Text + " where odemeDurumu=0 AND datepart(year, taksitOdemeGunu)=" + masked_YilSec.Text);
                            } else {
                                MessageBox.Show("Lütfen Yıl Girmeyi Unutmayınız!");
                                return;
                            }
                        } else {
                            taksitler = taksitBaglanti.TabloOku("select * from Taksitler" + masked_TCKN.Text + " where odemeDurumu=0");
                        }
                        ogrenciHesap = new OgrenciHesap(ogrenciBaglanti.TabloOku("select * from OgrenciHesap where ogrTCKN='" + masked_TCKN.Text + "'"));
                        dataGrid.DataSource = taksitler;
                        if (taksitler.Rows.Count != 0) {
                            if (!flag) {
                                flag = true;
                                dataGrid.Columns[0].HeaderText = "Taksit Numarası:";
                                dataGrid.Columns[1].HeaderText = "Ögrenci TCKN:";
                                dataGrid.Columns[2].HeaderText = "Tutar:";
                                dataGrid.Columns[3].HeaderText = "Son Ödeme Günü:";
                                dataGrid.Columns[4].Visible = false;
                                dataGrid.Columns[5].Visible = false;
                            }

                            dataGrid.ClearSelection();
                            txtBox_KalanOdeme.Text = ogrenciHesap.KalanUcret.ToString("0.00");
                        } else {
                            if (check_Yil.Checked) {
                                MessageBox.Show("Girilen Yılda Ödenmemiş Herhangi Bir Taksit Bulunmamaktadır!");
                            } else {
                                MessageBox.Show("Seçilen Öğrencinin Ödenmemiş Herhangi Bir Taksiti Bulunmamaktadır!");
                            }
                        }
                    } catch (SqlException) {
                        MessageBox.Show("Girilen Kimlik Numarasına Sahip Herhangi Bir Öğrenci Sistemde Kayıtlı Değildir!");
                    }
                } else {
                    MessageBox.Show("Lütfen 11 Haneli Kimlik Numarasını Giriniz!");
                }
            } else {
                if (taksitSecildi) {
                    string query = "update Taksitler" + ogrenciHesap.OgrTCKN + " set odemeDurumu=1, odendigiGun=@p1 where id=@p2";
                    taksitBaglanti.Cmd.Parameters.AddWithValue("@p1", date_Odeme.Value);
                    taksitBaglanti.Cmd.Parameters.AddWithValue("@p2", odenecekTaksitID);
                    taksitBaglanti.SetData(query);
                    taksitBaglanti.Cmd = new SqlCommand() {
                        Connection = taksitBaglanti.Con
                    };

                    txtBox_KalanOdeme.Text = (Convert.ToDouble(txtBox_KalanOdeme.Text) - ogrenciHesap.TaksitUcreti).ToString();

                    query = "update OgrenciHesap set odenenTaksitler+=@p1, kalanUcret-=@p2 where ogrTCKN=@p3";
                    ogrenciBaglanti.Cmd.Parameters.AddWithValue("@p1", 1);
                    ogrenciBaglanti.Cmd.Parameters.AddWithValue("@p2", ogrenciHesap.TaksitUcreti);
                    ogrenciBaglanti.Cmd.Parameters.AddWithValue("@p3", ogrenciHesap.OgrTCKN);
                    ogrenciBaglanti.SetData(query);
                    ogrenciBaglanti.Cmd = new SqlCommand() {
                        Connection = ogrenciBaglanti.Con
                    };

                    dataGrid.Rows.Remove(dataGrid.Rows[secilenSatirNo]);
                    dataGrid.ClearSelection();
                    taksitSecildi = false;
                } else {
                    MessageBox.Show("Lütfen Listeden Ödenecek Taksiti Seçiniz!");
                }
            }
        }

        public void PanelYukle(object sender, EventArgs e) {

        }

        public void TabloGuncelle(string tablo) {

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

        private void VeriSec(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex != -1) {
                taksitSecildi = true;
                odenecekTaksitID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["id"].Value);
                secilenSatirNo = e.RowIndex;
                OdemeDurumunuBelirle(null, null);
            }
        }

        private void OdemeDurumunuBelirle(object sender, EventArgs e) {
            int tarihFarki = (int)(Convert.ToDateTime(date_Odeme.Value.ToString("dd MM yyy")) - Convert.ToDateTime(dataGrid.Rows[secilenSatirNo].Cells["taksitOdemeGunu"].Value)).TotalDays;
            if (tarihFarki > 0) {
                label_odemeDurum.Text = "Geç Ödeme Yapılıyor";
            } else if (tarihFarki < 0) {
                label_odemeDurum.Text = "Erken Ödeme Yapılıyor";
            } else {
                label_odemeDurum.Text = "Gününde Ödeme Yapılıyor";
            }
        }

        private void CheckBoxKontrol(object sender, EventArgs e) {
            if (check_Yil.Checked) {
                masked_YilSec.Enabled = true;
            } else {
                masked_YilSec.Enabled = false;
                masked_YilSec.Text = "";
            }
        }
    }
}
