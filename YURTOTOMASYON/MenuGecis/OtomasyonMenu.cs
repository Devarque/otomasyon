using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;

namespace Yurt_Otomasyon.MenuGecis {
    public partial class OtomasyonMenu : Form, IMenu {
        private List<Guna2Button> butonListesi = new List<Guna2Button>();
        Menu menu;

        public OtomasyonMenu() {
            InitializeComponent();
            buton_Oda.Tag = uc_Oda1;
            buton_Odeme.Tag = uc_Odeme1;
            buton_Ogrenci.Tag = uc_Ogrenci1;
            buton_Yoklama.Tag = uc_Yoklama1;
            buton_Yonetici.Tag = uc_Yonetici1;


            butonListesi.Add(buton_Oda);
            butonListesi.Add(buton_Odeme);
            butonListesi.Add(buton_Ogrenci);
            butonListesi.Add(buton_Yoklama);
            butonListesi.Add(buton_Yonetici);

            menu = new Menu(butonListesi);
        }

        public void MenuSec(object sender, EventArgs e) {
            menu.MenuSec(sender, e);
        }

        private void OtomasyonMenu_Load(object sender, EventArgs e) {

        }

        private void OtomasyonMenu_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
