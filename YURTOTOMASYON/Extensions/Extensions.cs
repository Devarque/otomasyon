using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Yurt_Otomasyon.SunucuBaglantisi;

namespace Yurt_Otomasyon.Extensions {
    public static class Extensions {
        /// <summary>
        /// Veritabanından Doldurur
        /// </summary>
        /// <param name="tabloAdi">Kaynak Tablo</param>
        /// <param name="sutunAdi">Verilerin Ekleneceği ComboBox</param>
        public static void VeriTabanindanDoldur(this Guna2ComboBox box, string tabloAdi, string sutunAdi) {
            box.Items.Clear();
            SqlSunucu baglanti = new SqlSunucu(0);
            string query = "select " + sutunAdi + " from " + tabloAdi; ;

            SqlDataReader rdr = baglanti.Read(query);
            while (rdr.Read()) {
                for (int i = 0; i < rdr.FieldCount; i++) {
                    box.Items.Add(rdr.GetString(i));
                }
            }
            rdr.Close();
            baglanti.Stop();
        }

        /// <summary>
        /// DataGrid tablosu pdf formatında çıktı olarak alınır.
        /// </summary>
        /// <param name="sayfaYonu">Dikay Sayfalar İçin 0, Yatay İçin Herhangi Bir Sayı</param>
        public static void PdfeAktar(this Guna2DataGridView dataGrid, string dosyaAdi, int sayfaYonu) {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dataGrid.Columns.Count - 1);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            Font text = new Font(bf, 12, Font.NORMAL);

            //başlıkları ekleme
            for (int i = 1; i < dataGrid.Columns.Count; i++) {
                var column = dataGrid.Columns[i];
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text)) {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    BackgroundColor = new BaseColor(233, 241, 255)
                };
                pdfTable.AddCell(cell);
            }

            //hücreleri oluşturma
            for (int i = 0; i < dataGrid.Rows.Count - 1; i++) {
                var row = dataGrid.Rows[i];
                for (int j = 1; j < row.Cells.Count; j++) {
                    var okunanCell = row.Cells[j];
                    PdfPCell cell = new PdfPCell(new Phrase(okunanCell.Value.ToString(), text)) {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    pdfTable.AddCell(cell);
                }
            }
            var savedialoge = new SaveFileDialog();
            savedialoge.FileName = dosyaAdi;
            savedialoge.DefaultExt = ".pdf";
            if (savedialoge.ShowDialog() == DialogResult.OK) {
                try {
                    using (FileStream stream = new FileStream(savedialoge.FileName, FileMode.Create)) {
                        Document pdfdoc;
                        if (sayfaYonu == 0) {
                            pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 2f);
                        } else {
                            pdfdoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 2f);
                        }
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdfTable);
                        pdfdoc.Close();
                        stream.Close();
                    }
                } catch (Exception) {
                    MessageBox.Show("Lütfen Aynı İsimde Dosya Açıksa Dosyayı Kapatınız!");
                }
            }
        }
    }
}
