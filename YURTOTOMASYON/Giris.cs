using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Yurt_Otomasyon.MenuGecis;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon {
    public partial class Giris : Form {
        SqlSunucu baglanti = new SqlSunucu(0);

        public Giris() {
            InitializeComponent();
        }

        private void exitButon_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void buton_giris_Click(object sender, EventArgs e) {
            List<YoneticiGiris> yoneticiler = new List<YoneticiGiris>();
            
            DataTable tablo = baglanti.DataGridDoldur("Yonetici");
            for (int i = 0; i < tablo.Rows.Count; i++) {
                var id = tablo.Rows[i]["yoneticiKullaniciAdi"].ToString();
                var sifre = tablo.Rows[i]["yoneticiSifre"].ToString();
                yoneticiler.Add(new YoneticiGiris(id, sifre));
            }
            
            if (yoneticiler.Contains(new YoneticiGiris(textBox_kullaniciAdi.Text, textBox_sifre.Text))) {
                OtomasyonMenu menu = new OtomasyonMenu();
                this.Hide();
                menu.Show();
            } else {
                textBox_sifre.Clear();
                textBox_kullaniciAdi.Clear();
                hataliGiris.Visible = true;
                textBox_kullaniciAdi.Select();
            }
        }
    }

    public struct YoneticiGiris {
        public YoneticiGiris(string id, string sifre) {
            this.id = id;
            this.sifre = sifre;
        }
        public string id;
        public string sifre;
    }
}
