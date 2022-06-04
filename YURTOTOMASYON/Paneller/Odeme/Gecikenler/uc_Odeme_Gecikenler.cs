using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Paneller.Odeme.Gecikenler {
    public partial class uc_Odeme_Gecikenler : UserControl, IPanel {
        private SqlSunucu ogrenciBaglanti = new SqlSunucu(0);
        private SqlSunucu taksitBaglanti = new SqlSunucu(2);

        public uc_Odeme_Gecikenler() {
            InitializeComponent();
        }

        public void PanelYukle(object sender, EventArgs e) {
            List<DataTable> ogrTaksitGunleri = new List<DataTable>();
            DataTable ogrenciTCKN = ogrenciBaglanti.TabloOku("select ogrTCKN from Ogrenci");
            for (int i = 0; i < ogrenciTCKN.Rows.Count; i++) {
                string query = "select taksitOdemeGunu, ogrTCKN from Taksitler" + ogrenciTCKN.Rows[i]["ogrTCKN"] + " where odemeDurumu=0";
                DataTable odemeGunleri = taksitBaglanti.TabloOku(query);
                ogrTaksitGunleri.Add(odemeGunleri);
            }

            DateTime bugun = Convert.ToDateTime(DateTime.Now.ToString("dd MM yyyy"));
            DataTable tumOdenmemisler = new DataTable();
            DataColumn col;

            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "ogrTCKN";
            tumOdenmemisler.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(DateTime);
            col.ColumnName = "taksitOdemeGunu";
            tumOdenmemisler.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "gecikenGun";
            tumOdenmemisler.Columns.Add(col);

            DataRow row;

            foreach (var ogr in ogrTaksitGunleri) {
                for (int i = 0; i < ogr.Rows.Count; i++) {
                    DateTime taksit = Convert.ToDateTime(ogr.Rows[i]["taksitOdemeGunu"]);
                    if ((bugun - taksit).TotalDays > 0) {
                        row = tumOdenmemisler.NewRow();
                        row["ogrTCKN"] = ogr.Rows[i]["ogrTCKN"].ToString();
                        row["taksitOdemeGunu"] = Convert.ToDateTime(ogr.Rows[i]["taksitOdemeGunu"]);
                        row["gecikenGun"] = (int)((bugun - taksit).TotalDays);
                        tumOdenmemisler.Rows.Add(row);
                    }
                }
            }

            dataGrid.DataSource = tumOdenmemisler;
            dataGrid.Columns[0].HeaderText = "Öğrenci Kimlik Numarası:";
            dataGrid.Columns[1].HeaderText = "Son Ödeme Günü:";
            dataGrid.Columns[2].HeaderText = "Geciken Gün Sayısı:";
        }
    }
}
