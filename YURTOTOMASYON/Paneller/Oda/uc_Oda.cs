using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Yurt_Otomasyon.Interface;
using Yurt_Otomasyon.MenuGecis;

namespace Yurt_Otomasyon.Paneller.Oda {
    public partial class uc_Oda : UserControl, IPanel, IMenu {
        private List<Guna2Button> butonListesi = new List<Guna2Button>();
        private MenuGecis.Menu menuNesne;

        public uc_Oda() {
            InitializeComponent();

            btn_BlokEkle.Tag = uc_Oda_BlokEkle1;
            btn_BlokSil.Tag = uc_Oda_BlokSil1;
            btn_Listele.Tag = uc_Oda_Listele1;
            btn_OdaEkle.Tag = uc_Oda_OdaEkle1;
            btn_OdaSil.Tag = uc_Oda_OdaSil1;

            butonListesi.Add(btn_BlokEkle);
            butonListesi.Add(btn_BlokSil);
            butonListesi.Add(btn_Listele);
            butonListesi.Add(btn_OdaEkle);
            butonListesi.Add(btn_OdaSil);

            menuNesne = new MenuGecis.Menu(butonListesi);
        }

        public void PanelYukle(object sender, EventArgs e) {
            Visible = true;
        }

        public void MenuSec(object sender, EventArgs e) {
            menuNesne.MenuSec(sender, e);
        }
    }
}
