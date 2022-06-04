using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());
        }
    }
}
