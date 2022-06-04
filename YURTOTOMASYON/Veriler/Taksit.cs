using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Veriler {
    public class Taksit : SqlVeri {
        private int id;
        private string ogrTCKN;
        private float taksitTutari;
        private DateTime taksitOdemeGunu;
        private bool odemeDurumu;

        public Taksit(string ogrTCKN, float taksitTutari, DateTime taksitOdemeGunu, bool odemeDurumu) {
            this.ogrTCKN = ogrTCKN;
            this.taksitTutari = taksitTutari;
            this.taksitOdemeGunu = taksitOdemeGunu;
            this.odemeDurumu = odemeDurumu;
        }

        public Taksit(DataTable data) {
            id = Convert.ToInt32(data.Rows[0]["id"]);
            ogrTCKN = data.Rows[0]["ogrTCKN"].ToString();
            taksitTutari = float.Parse(data.Rows[0]["taksitTutari"].ToString());
            taksitOdemeGunu = Convert.ToDateTime(data.Rows[0]["taksitOdemeGunu"]);
            odemeDurumu = Convert.ToBoolean(data.Rows[0]["odemeDurumu"]);
        }


        public override void VeriGir() {
            query = "Insert Into OgrenciHesap(ogrTCKN, taksitTutari, taksitOdemeGunu, odemeDurumu)Values(@p1, @p2, @p3, @p4)";
            SqlSunucu baglanti = new SqlSunucu(0);
            baglanti.Cmd.Parameters.AddWithValue("@p1", ogrTCKN);
            baglanti.Cmd.Parameters.AddWithValue("@p2", taksitTutari);
            baglanti.Cmd.Parameters.AddWithValue("@p3", taksitOdemeGunu);
            baglanti.Cmd.Parameters.AddWithValue("@p4", odemeDurumu);
            baglanti.SetData(query);

        }
    }
}
