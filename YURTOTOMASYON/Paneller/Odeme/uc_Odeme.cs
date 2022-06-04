using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.MenuGecis;

namespace Yurt_Otomasyon.Paneller.Odeme {
    public partial class uc_Odeme : UserControl, IPanel, IMenu {
        private List<Guna2Button> butonListesi = new List<Guna2Button>();

        MenuGecis.Menu menu;
        public uc_Odeme() {
            InitializeComponent();
            btn_gecikenOdemeler.Tag = uc_Odeme_Gecikenler1;
            btn_OdemeListesi.Tag = uc_Odeme_Listele1;
            btn_OdemeYap.Tag = uc_Odeme_Ekle1;
            butonListesi.Add(btn_OdemeListesi);
            butonListesi.Add(btn_OdemeYap);
            butonListesi.Add(btn_gecikenOdemeler);

            menu = new MenuGecis.Menu(butonListesi);

        }

        public void MenuSec(object sender, EventArgs e) {
            menu.MenuSec(sender, e);
        }

        public void PanelYukle(object sender, EventArgs e) {

        }
    }
}
