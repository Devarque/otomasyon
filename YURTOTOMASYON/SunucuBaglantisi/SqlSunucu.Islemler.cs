using System.Data;
using System.Data.SqlClient;

namespace Yurt_Otomasyon.SunucuBaglantisi {
    partial class SqlSunucu {
        public DataSet GetData(string query) {
            cmd = new SqlCommand {
                Connection = Con,
                CommandText = query
            };
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void SetData(string query) {
            cmd.CommandText = query;
            Open();
            Cmd.ExecuteNonQuery();
            Stop();
        }

        public SqlDataReader Read(string query) {
            cmd = new SqlCommand {
                Connection = Con
            };
            if(Con.State.ToString() != "Open")
                Open();
            cmd = new SqlCommand(query, Con);
            SqlDataReader sdr = Cmd.ExecuteReader();
            return sdr;
        }

        public DataTable DataGridDoldur(string tabloAdi) {
            string query = "select * from " + tabloAdi;
            DataSet ds = GetData(query);
            Stop();
            return ds.Tables[0];
        }

        public DataTable TabloOku(string query) {
            DataSet ds = GetData(query);
            Stop();
            return ds.Tables[0];
        }
    }
}
