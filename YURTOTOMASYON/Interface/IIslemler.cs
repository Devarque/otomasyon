using System;

namespace Yurt_Otomasyon.Interface {
    interface IIslemler {
        void IslemGerceklestir(object sender, EventArgs a);
        void TabloGuncelle(string tablo);

    }
}
