using Guna.UI2.WinForms;
using System.Data;
using Yurt_Otomasyon.SunucuBaglantisi;
using Yurt_Otomasyon.Veriler;

namespace Yurt_Otomasyon {
    public static class AramaIslemleri {

        /// <summary>
        /// Arama ve Silme İşlemleri Sırasında Kullanılmak Üzere,
        /// Seçilen Blok Adına Göre O Bloğun Katlarını Listeler.
        /// </summary>
        /// <param name="combo_Blok">Seçilen Blok İçin ComboBox</param>
        /// <param name="combo_Kat">Seçilen Bloğa Göre Listelenecek Katlar İçin ComboBox</param>
        public static void KatlariDoldur(Guna2ComboBox combo_Blok, Guna2ComboBox combo_Kat) {
            SqlSunucu baglanti = new SqlSunucu(0);

            string query = "select * from Blok where blokAD='" + combo_Blok.SelectedItem + "'";

            Blok blok = new Blok(baglanti.TabloOku(query));

            for (int i = 0; i < blok.KatSayisi; i++) {
                combo_Kat.Items.Add(i + 1);
            }
        }

        /// <summary>
        /// Arama ve Silme İşlemleri Sırasında Kullanılmak Üzere,
        /// Seçilen Blok Ve Kata Göre Odaları Listeler
        /// </summary>
        /// <param name="combo_blok">Seçilen Blok İçin ComboBox</param>
        /// <param name="combo_kat">Seçilen Kat İçin ComboBox</param>
        /// <param name="combo_Oda">Seçilen Blok Ve Kata Göre Listelenecek Odalar İçin ComboBox</param>
        public static void OdalariDoldur(Guna2ComboBox combo_Blok, Guna2ComboBox combo_Kat, Guna2ComboBox combo_Oda) {
            SqlSunucu baglanti = new SqlSunucu(0);

            string query = "select oda_no from Oda where oda_blokAdi='" + combo_Blok.SelectedItem + "' AND kat_no='" + combo_Kat.SelectedItem + "'";
            DataTable odalar = baglanti.TabloOku(query);

            for (int i = 0; i < odalar.Rows.Count; i++) {
                combo_Oda.Items.Add(odalar.Rows[i]["oda_no"]);
            }
        }

    }
}
