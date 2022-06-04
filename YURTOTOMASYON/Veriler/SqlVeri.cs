using System.Data;
using System.Data.SqlClient;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Veriler {

    public abstract class SqlVeri : ISqlVeri {
        public string tabloAdi;
        public string query;

        public abstract void VeriGir();

        public void VeriSil(int silinecekVeri) {
            SqlSunucu baglanti = new SqlSunucu(0);
            DataSet dataSet = baglanti.GetData("select * from " + tabloAdi);
            DataTable tablo = dataSet.Tables[0];
            string column = tablo.Columns[0].ColumnName;

            query = "Delete from " + tabloAdi + " where " + column + "=@id";
            SqlCommand komutsil = new SqlCommand(query, baglanti.Con);
            komutsil.Parameters.AddWithValue("@id", silinecekVeri);
            baglanti.Open();
            komutsil.ExecuteNonQuery();
            baglanti.Stop();
        }
    }
}
