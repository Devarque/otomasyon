using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.MenuGecis;

namespace Yurt_Otomasyon.Paneller.Ogrenci {
    public partial class uc_Ogrenci : UserControl, IPanel, IMenu {
        private List<Guna2Button> butonListesi = new List<Guna2Button>();
        private MenuGecis.Menu menuNesne;
        public uc_Ogrenci() {
            InitializeComponent();
            btn_OgrenciSil.Tag = uc_Ogrenci_Sil1;
            btn_OgrenciDuzenle.Tag = uc_Ogrenci_Duzenle1;
            btn_OgrenciKayit.Tag = uc_Ogrenci_Kayit1;
            btn_OgrenciListesi.Tag = uc_Ogrenci_Listele1;

            butonListesi.Add(btn_OgrenciDuzenle);
            butonListesi.Add(btn_OgrenciKayit);
            butonListesi.Add(btn_OgrenciListesi);
            butonListesi.Add(btn_OgrenciSil);

            menuNesne = new MenuGecis.Menu(butonListesi);

        }

        public void MenuSec(object sender, EventArgs e) {
            menuNesne.MenuSec(sender, e);
        }

        public void PanelYukle(object sender, EventArgs e) {

        }
    }
}
