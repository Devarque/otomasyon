using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Yurt_Otomasyon.MenuGecis {
    public class Menu {
        private List<Guna2Button> butonListesi = new List<Guna2Button>();

        public Menu(List<Guna2Button> ButonListesi) {
            butonListesi = ButonListesi;
        }

        public void MenuSec(object sender, EventArgs e) {
            Guna2Button buton = (Guna2Button)sender;
            foreach (var item in butonListesi) {
                item.Checked = false;
                UserControl uc = (UserControl)item.Tag;
                if (uc != null) {
                    uc.Visible = false;
                }
            }
            buton.Checked = true;

            UserControl altMenu = (UserControl)buton.Tag;
            if (altMenu != null) {
                altMenu.Visible = true;
            }
        }
    }
}
