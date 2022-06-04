using System.Data;
using System.Data.SqlClient;

namespace Yurt_Otomasyon.SunucuBaglantisi {
    public partial class SqlSunucu {
        private SqlCommand cmd;
        private SqlConnection con;

        /// <summary>
        /// Sunucu Bağlantısı
        /// </summary>
        /// <param name="x">0 Standart Bağlantı, 1 Yoklama, 2 Taksitler</param>
        public SqlSunucu(int x) {
            if(x == 0) {
                Con = new SqlConnection {
                    ConnectionString = "Server=tcp:otomasyon.database.windows.net,1433;Initial Catalog=Yurt Otomasyon;Persist Security Info=False;User ID=yurtotomasyon;Password=gJ3FjWk3Hu2Uk39;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                };
            } else if(x == 1) {
                Con = new SqlConnection {
                    ConnectionString = "Server=tcp:otomasyon.database.windows.net,1433;Initial Catalog=Yoklamalar;Persist Security Info=False;User ID=yurtotomasyon;Password=gJ3FjWk3Hu2Uk39;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                };
            } else if(x == 2) {
                Con = new SqlConnection {
                    ConnectionString = "Server=tcp:otomasyon.database.windows.net,1433;Initial Catalog=Taksitler;Persist Security Info=False;User ID=yurtotomasyon;Password=gJ3FjWk3Hu2Uk39;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                };
            }

            Cmd = new SqlCommand() {
                Connection = Con
            };
        }

        public SqlConnection Con { get => con; set => con = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }

        public void Stop() {
            Con.Close();
        }

        public void Open() {
            Con.Open();
        }
    }
}
