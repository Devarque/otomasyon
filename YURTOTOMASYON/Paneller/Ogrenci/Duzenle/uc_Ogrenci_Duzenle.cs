using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yurt_Otomasyon.Extensions;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Paneller.Ogrenci.Duzenle {
    public partial class uc_Ogrenci_Duzenle : UserControl, IPanel, IIslemler {
        SqlSunucu baglanti = new SqlSunucu(0);
        private int? secilenid;
        private string blok;
        private int kat, oda, yatak;
        public uc_Ogrenci_Duzenle() {
            InitializeComponent();
        }

        public void IslemGerceklestir(object sender, EventArgs a) {
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
            } catch (NullReferenceException) {
                MessageBox.Show("Lütfen Blok Seçmeyi Unutmayınız!");
            } catch (SqlException) {
                MessageBox.Show("Sunucu Bağlantı Hatası!");
            }
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

        private void DinamikAra(object sender, EventArgs e) {
            string query;
            if (masked_TCKN.Text.Length > 0) {
                query = "select * from Ogrenci where ogrTCKN LIKE '%" + masked_TCKN.Text + "%'";
            } else {
                query = "select * from Ogrenci";
            }
            dataGrid.DataSource = baglanti.TabloOku(query);
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

        private void VeriSec(object sender, DataGridViewCellEventArgs e) {
            try {
                secilenid = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
                txtBox_VeliAdYeni.Text = dataGrid.Rows[e.RowIndex].Cells["ogrVeliAd"].Value.ToString();
                txtBox_VeliSoyadYeni.Text = dataGrid.Rows[e.RowIndex].Cells["ogrVeliSoyad"].Value.ToString();
                masked_VeliCepYeni.Text = dataGrid.Rows[e.RowIndex].Cells["ogrVeliCepTel"].Value.ToString();
                masked_VeliCep2Yeni.Text = dataGrid.Rows[e.RowIndex].Cells["ogrVeliCepTel2"].Value.ToString();
                txtBox_VeliAdresYeni.Text = dataGrid.Rows[e.RowIndex].Cells["ogrVeliAdres"].Value.ToString();

                string kanGrubu = dataGrid.Rows[e.RowIndex].Cells["ogrKanGrubu"].Value.ToString();
                combo_KanGrubuYeni.SelectedIndex = combo_KanGrubuYeni.Items.IndexOf(kanGrubu);

                masked_OgrenciCepYeni.Text = dataGrid.Rows[e.RowIndex].Cells["ogrCepTel"].Value.ToString();
                txtBox_ePostaYeni.Text = dataGrid.Rows[e.RowIndex].Cells["ogrEposta"].Value.ToString();

                combo_BlokYeni.VeriTabanindanDoldur("Blok", "blokAD");

                string blok;
                int kat, oda, yatak;
                blok = dataGrid.Rows[e.RowIndex].Cells["ogrYurtBlok"].Value.ToString();
                this.blok = blok;
                kat = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["ogrYurtKat"].Value);
                this.kat = kat;
                oda = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["ogrYurtOda"].Value);
                this.oda = oda;
                yatak = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["ogrYurtYatak"].Value);
                this.yatak = yatak;
                combo_BlokYeni.SelectedItem = blok;
                combo_KatYeni.SelectedItem = kat;
                combo_OdaYeni.SelectedItem = oda;
                combo_YatakYeni.SelectedItem = yatak;
            } catch (Exception a) {
                MessageBox.Show(a.Message);
            }
        }

        private void YeniKatlariDoldur(object sender, EventArgs e) {
            combo_KatYeni.Items.Clear();
            combo_OdaYeni.Items.Clear();
            combo_YatakYeni.Items.Clear();
            AramaIslemleri.KatlariDoldur(combo_BlokYeni, combo_KatYeni);
        }

        private void YeniOdalariDoldur(object sender, EventArgs e) {
            combo_OdaYeni.Items.Clear();
            combo_YatakYeni.Items.Clear();
            AramaIslemleri.OdalariDoldur(combo_BlokYeni, combo_KatYeni, combo_OdaYeni);
        }

        private void YeniYatakDoldur(object sender, EventArgs e) {
            combo_YatakYeni.Items.Clear();
            string query = "select oda_kapasite from Oda where oda_blokAdi='" + combo_BlokYeni.SelectedItem.ToString()[0] + "' AND kat_no=" + Convert.ToInt32(combo_KatYeni.SelectedItem) + " AND oda_no=" + Convert.ToInt32(combo_OdaYeni.SelectedItem) + "";
            var sdr = new SqlSunucu(0).Read(query);
            sdr.Read();
            int kapasite = Convert.ToInt32(sdr.GetValue(0));
            for (int i = 0; i < kapasite; i++) {
                combo_YatakYeni.Items.Add(i + 1);
            }
        }

        private void OgrenciGuncelle(object sender, EventArgs e) {
            try {
                Guna2Button buton = (Guna2Button)sender;
                string query = "update Ogrenci Set ";
                if (buton.Tag.ToString() == "odaguncelle") {
                    DataTable tablo = baglanti.GetData("select * from Ogrenci where ogrYurtBlok='" + combo_BlokYeni.SelectedItem.ToString() + "' " +
                        "AND ogrYurtKat='" + combo_KatYeni.SelectedItem.ToString() + "' " +
                        "AND ogrYurtOda='" + combo_OdaYeni.SelectedItem.ToString() + "' " +
                        "AND ogrYurtYatak='" + combo_YatakYeni.SelectedItem.ToString() + "'").Tables[0];
                    if (tablo.Rows.Count == 1) {
                        DialogResult dialogResult = MessageBox.Show("Seçilen Oda Bilgilerine Sahip Başka Bir Öğrenci Bulunmakta" +
                            "\nİki Öğrencinin Oda ve Yataklarını Değiştirmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes) {
                            int id = Convert.ToInt32(tablo.Rows[0][0]);
                            string query2 = "Update Ogrenci Set ogrYurtBlok='" + blok + "'" +
                                ", ogrYurtKat=" + kat +
                                ", ogrYurtOda=" + oda +
                                ", ogrYurtYatak=" + yatak + " where ogrID=" + id;
                            baglanti.SetData(query2);
                            query += "ogrYurtBlok='" + combo_BlokYeni.SelectedItem.ToString() + "'" +
                                ", ogrYurtKat=" + Convert.ToInt32(combo_KatYeni.SelectedItem) +
                                ", ogrYurtOda=" + Convert.ToInt32(combo_OdaYeni.SelectedItem) +
                                ", ogrYurtYatak= " + Convert.ToInt32(combo_YatakYeni.SelectedItem);
                        } else if (dialogResult == DialogResult.No) {
                            return;
                        }
                    } else {
                        //boş yatak, öğrenyici değiştir
                        query += "ogrYurtBlok='" + combo_BlokYeni.SelectedItem.ToString() + "'";
                        query += ", ogrYurtKat='" + combo_KatYeni.SelectedItem.ToString() + "'";
                        query += ", ogrYurtOda='" + combo_OdaYeni.SelectedItem.ToString() + "'";
                        query += ", ogrYurtYatak='" + combo_YatakYeni.SelectedItem.ToString() + "'";
                        //yeni oda dolu yatak sayısı 1 artırılır
                        int odaID = (int)baglanti.GetData("select * from Oda where oda_blokAdi='" + combo_BlokYeni.SelectedItem.ToString() + "'" +
                                        " AND kat_no=" + combo_KatYeni.SelectedItem.ToString() + "" +
                                        " AND oda_no=" + combo_OdaYeni.SelectedItem.ToString() + "").Tables[0].Rows[0][0];
                        baglanti.SetData("Update Oda set oda_doluYatak+=" + 1 + " where oda_id=" + odaID + "");
                        //eski oda dolu yatak sayısı 1 azaltılır
                        odaID = (int)baglanti.GetData("select * from Oda where oda_blokAdi='" + blok + "'" +
                                        " AND kat_no=" + kat + "" +
                                        " AND oda_no=" + oda + "").Tables[0].Rows[0][0];
                        baglanti.SetData("Update Oda set oda_doluYatak-=" + 1 + " where oda_id=" + odaID + "");
                    }
                    MessageBox.Show("Öğrenci Oda Bilgileri Başarıyla Güncellendi!");
                } else {
                    switch (buton.Tag.ToString()) {
                        case "veliguncelle":
                            query += "ogrVeliAd='" + txtBox_VeliAdYeni.Text + "'";
                            query += ", ogrVeliSoyad='" + txtBox_VeliSoyadYeni.Text + "'";
                            query += ", ogrVeliCepTel='" + masked_VeliCepYeni.Text + "'";
                            query += ", ogrVeliCepTel2='" + masked_VeliCep2Yeni.Text + "'";
                            query += ", ogrVeliAdres='" + txtBox_VeliAdresYeni.Text + "'";
                            MessageBox.Show("Öğrenci Veli Bilgileri Başarıyla Güncellendi!");
                            break;
                        case "ogrenciguncelle":
                            query += "ogrKanGrubu='" + combo_KanGrubuYeni.SelectedItem.ToString() + "'";
                            query += ", ogrCepTel='" + masked_OgrenciCepYeni.Text + "'";
                            query += ", ogrEposta='" + txtBox_ePostaYeni.Text + "'";
                            MessageBox.Show("Öğrenci Kişisel Bilgileri Başarıyla Güncellendi");
                            break;
                    }
                }
                query += " where ogrID=" + secilenid + "";
                baglanti.SetData(query);
            } catch (Exception) {
                MessageBox.Show("Hatalı Seçimler ve/ya Doldurmalar Yapıldı!");
            }
            TabloGuncelle("Ogrenci");
        }
    }
}
