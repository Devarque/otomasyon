using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Veriler {
    public class OgrenciHesap : SqlVeri {
        private int id;
        private string ogrTCKN;
        private int onOdeme;
        private double toplamUcret;
        private int toplamTaksit;
        private int odenenTaksitler;
        private double kalanUcret;
        private double taksitUcreti;

        public OgrenciHesap(string ogrTCKN, int onOdeme, double toplamUcret, int toplamTaksit, int odenenTaksitler, double kalanUcret, double taksitUcreti) {
            this.ogrTCKN = ogrTCKN;
            this.onOdeme = onOdeme;
            this.toplamUcret = toplamUcret;
            this.toplamTaksit = toplamTaksit;
            this.odenenTaksitler = odenenTaksitler;
            this.kalanUcret = kalanUcret;
            this.taksitUcreti = taksitUcreti;
        }

        public OgrenciHesap(DataTable data) {
            id = Convert.ToInt32(data.Rows[0]["id"]);
            ogrTCKN = data.Rows[0]["ogrTCKN"].ToString();
            onOdeme = Convert.ToInt32(data.Rows[0]["onOdeme"]);
            toplamUcret = Convert.ToInt32(data.Rows[0]["toplamUcret"]);
            toplamTaksit = Convert.ToInt32(data.Rows[0]["toplamTaksit"]);
            odenenTaksitler = Convert.ToInt32(data.Rows[0]["odenenTaksitler"]);
            kalanUcret = Convert.ToDouble(data.Rows[0]["kalanUcret"]);
            taksitUcreti = Convert.ToDouble(data.Rows[0]["taksitUcreti"]);
        }

        public string OgrTCKN { get => ogrTCKN; }
        public double KalanUcret { get => kalanUcret; }
        public double TaksitUcreti { get => taksitUcreti; }

        public override void VeriGir() {
            query = "Insert Into OgrenciHesap(ogrTCKN, onOdeme, toplamUcret, toplamTaksit, odenenTaksitler, kalanUcret, taksitUcreti)Values(@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
            SqlSunucu baglanti = new SqlSunucu(0);
            baglanti.Cmd.Parameters.AddWithValue("@p1", ogrTCKN);
            baglanti.Cmd.Parameters.AddWithValue("@p2", onOdeme);
            baglanti.Cmd.Parameters.AddWithValue("@p3", toplamUcret);
            baglanti.Cmd.Parameters.AddWithValue("@p4", toplamTaksit);
            baglanti.Cmd.Parameters.AddWithValue("@p5", odenenTaksitler);
            baglanti.Cmd.Parameters.AddWithValue("@p6", kalanUcret);
            baglanti.Cmd.Parameters.AddWithValue("@p7", taksitUcreti);
            baglanti.SetData(query);
        }
    }
}
