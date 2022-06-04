using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.MenuGecis;

namespace Yurt_Otomasyon.Paneller.Yonetici {
    public partial class uc_Yonetici : UserControl, IPanel, IMenu {
        private List<Guna2Button> butonListesi = new List<Guna2Button>();
        private MenuGecis.Menu menuNesne;

        public uc_Yonetici() {
            InitializeComponent();
            btn_YoneticiEkle.Tag = uc_Yonetici_Ekle1;
            btn_YoneticiSil.Tag = uc_Yonetici_Sil1;

            butonListesi.Add(btn_YoneticiEkle);
            butonListesi.Add(btn_YoneticiSil);

            menuNesne = new MenuGecis.Menu(butonListesi);

        }

        public void MenuSec(object sender, EventArgs e) {
            menuNesne.MenuSec(sender, e);
        }

        public void PanelYukle(object sender, EventArgs e) {

        }
    }
}
