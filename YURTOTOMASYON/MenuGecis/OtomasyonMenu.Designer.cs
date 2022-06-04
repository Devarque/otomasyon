
namespace Yurt_Otomasyon.MenuGecis {
    partial class OtomasyonMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtomasyonMenu));
            this.label_YurtOtomasyon = new System.Windows.Forms.Label();
            this.panelButonlar = new Guna.UI2.WinForms.Guna2Panel();
            this.buton_Oda = new Guna.UI2.WinForms.Guna2Button();
            this.buton_Yonetici = new Guna.UI2.WinForms.Guna2Button();
            this.buton_Yoklama = new Guna.UI2.WinForms.Guna2Button();
            this.buton_Odeme = new Guna.UI2.WinForms.Guna2Button();
            this.buton_Ogrenci = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.uc_Yoklama1 = new Yurt_Otomasyon.Paneller.Yoklama.uc_Yoklama();
            this.uc_Odeme1 = new Yurt_Otomasyon.Paneller.Odeme.uc_Odeme();
            this.uc_Ogrenci1 = new Yurt_Otomasyon.Paneller.Ogrenci.uc_Ogrenci();
            this.uc_Yonetici1 = new Yurt_Otomasyon.Paneller.Yonetici.uc_Yonetici();
            this.uc_Oda1 = new Yurt_Otomasyon.Paneller.Oda.uc_Oda();
            this.panelButonlar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_YurtOtomasyon
            // 
            this.label_YurtOtomasyon.AutoSize = true;
            this.label_YurtOtomasyon.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YurtOtomasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.label_YurtOtomasyon.Location = new System.Drawing.Point(424, 9);
            this.label_YurtOtomasyon.Name = "label_YurtOtomasyon";
            this.label_YurtOtomasyon.Size = new System.Drawing.Size(435, 43);
            this.label_YurtOtomasyon.TabIndex = 1;
            this.label_YurtOtomasyon.Text = "YURT OTOMASYONU";
            // 
            // panelButonlar
            // 
            this.panelButonlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.panelButonlar.Controls.Add(this.buton_Oda);
            this.panelButonlar.Controls.Add(this.buton_Yonetici);
            this.panelButonlar.Controls.Add(this.buton_Yoklama);
            this.panelButonlar.Controls.Add(this.buton_Odeme);
            this.panelButonlar.Controls.Add(this.buton_Ogrenci);
            this.panelButonlar.Location = new System.Drawing.Point(0, 70);
            this.panelButonlar.Name = "panelButonlar";
            this.panelButonlar.ShadowDecoration.Parent = this.panelButonlar;
            this.panelButonlar.Size = new System.Drawing.Size(1264, 85);
            this.panelButonlar.TabIndex = 2;
            // 
            // buton_Oda
            // 
            this.buton_Oda.BackColor = System.Drawing.Color.Transparent;
            this.buton_Oda.BorderRadius = 20;
            this.buton_Oda.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buton_Oda.CheckedState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.buton_Oda.CheckedState.Parent = this.buton_Oda;
            this.buton_Oda.CustomImages.Parent = this.buton_Oda;
            this.buton_Oda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(123)))), ((int)(((byte)(150)))));
            this.buton_Oda.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Oda.ForeColor = System.Drawing.Color.White;
            this.buton_Oda.HoverState.Parent = this.buton_Oda;
            this.buton_Oda.Image = global::Yurt_Otomasyon.Properties.Resources.odablok;
            this.buton_Oda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buton_Oda.ImageSize = new System.Drawing.Size(40, 40);
            this.buton_Oda.Location = new System.Drawing.Point(146, 7);
            this.buton_Oda.Name = "buton_Oda";
            this.buton_Oda.PressedColor = System.Drawing.Color.White;
            this.buton_Oda.ShadowDecoration.Parent = this.buton_Oda;
            this.buton_Oda.Size = new System.Drawing.Size(179, 70);
            this.buton_Oda.TabIndex = 0;
            this.buton_Oda.Text = "ODA İŞLEMLERİ";
            this.buton_Oda.TextOffset = new System.Drawing.Point(20, 0);
            this.buton_Oda.Click += new System.EventHandler(this.MenuSec);
            // 
            // buton_Yonetici
            // 
            this.buton_Yonetici.BorderRadius = 20;
            this.buton_Yonetici.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buton_Yonetici.CheckedState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.buton_Yonetici.CheckedState.Parent = this.buton_Yonetici;
            this.buton_Yonetici.CustomImages.Parent = this.buton_Yonetici;
            this.buton_Yonetici.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(123)))), ((int)(((byte)(150)))));
            this.buton_Yonetici.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Yonetici.ForeColor = System.Drawing.Color.White;
            this.buton_Yonetici.HoverState.Parent = this.buton_Yonetici;
            this.buton_Yonetici.Image = global::Yurt_Otomasyon.Properties.Resources.admin;
            this.buton_Yonetici.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buton_Yonetici.ImageSize = new System.Drawing.Size(40, 40);
            this.buton_Yonetici.Location = new System.Drawing.Point(917, 7);
            this.buton_Yonetici.Name = "buton_Yonetici";
            this.buton_Yonetici.ShadowDecoration.Parent = this.buton_Yonetici;
            this.buton_Yonetici.Size = new System.Drawing.Size(184, 70);
            this.buton_Yonetici.TabIndex = 0;
            this.buton_Yonetici.Text = "YÖNETİCİ AYARLARI";
            this.buton_Yonetici.TextOffset = new System.Drawing.Point(20, 0);
            this.buton_Yonetici.Click += new System.EventHandler(this.MenuSec);
            // 
            // buton_Yoklama
            // 
            this.buton_Yoklama.BorderRadius = 20;
            this.buton_Yoklama.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buton_Yoklama.CheckedState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.buton_Yoklama.CheckedState.Parent = this.buton_Yoklama;
            this.buton_Yoklama.CustomImages.Parent = this.buton_Yoklama;
            this.buton_Yoklama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(123)))), ((int)(((byte)(150)))));
            this.buton_Yoklama.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Yoklama.ForeColor = System.Drawing.Color.White;
            this.buton_Yoklama.HoverState.Parent = this.buton_Yoklama;
            this.buton_Yoklama.Image = global::Yurt_Otomasyon.Properties.Resources.yoklama;
            this.buton_Yoklama.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buton_Yoklama.ImageSize = new System.Drawing.Size(40, 40);
            this.buton_Yoklama.Location = new System.Drawing.Point(729, 7);
            this.buton_Yoklama.Name = "buton_Yoklama";
            this.buton_Yoklama.ShadowDecoration.Parent = this.buton_Yoklama;
            this.buton_Yoklama.Size = new System.Drawing.Size(182, 70);
            this.buton_Yoklama.TabIndex = 0;
            this.buton_Yoklama.Text = "YOKLAMA";
            this.buton_Yoklama.TextOffset = new System.Drawing.Point(20, 0);
            this.buton_Yoklama.Click += new System.EventHandler(this.MenuSec);
            // 
            // buton_Odeme
            // 
            this.buton_Odeme.BorderRadius = 20;
            this.buton_Odeme.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buton_Odeme.CheckedState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.buton_Odeme.CheckedState.Parent = this.buton_Odeme;
            this.buton_Odeme.CustomImages.Parent = this.buton_Odeme;
            this.buton_Odeme.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(123)))), ((int)(((byte)(150)))));
            this.buton_Odeme.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Odeme.ForeColor = System.Drawing.Color.White;
            this.buton_Odeme.HoverState.Parent = this.buton_Odeme;
            this.buton_Odeme.Image = global::Yurt_Otomasyon.Properties.Resources.odeme;
            this.buton_Odeme.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buton_Odeme.ImageSize = new System.Drawing.Size(40, 40);
            this.buton_Odeme.Location = new System.Drawing.Point(527, 7);
            this.buton_Odeme.Name = "buton_Odeme";
            this.buton_Odeme.ShadowDecoration.Parent = this.buton_Odeme;
            this.buton_Odeme.Size = new System.Drawing.Size(196, 70);
            this.buton_Odeme.TabIndex = 0;
            this.buton_Odeme.Text = "ÖDEME İŞLEMLERİ";
            this.buton_Odeme.TextOffset = new System.Drawing.Point(20, 0);
            this.buton_Odeme.Click += new System.EventHandler(this.MenuSec);
            // 
            // buton_Ogrenci
            // 
            this.buton_Ogrenci.BorderRadius = 20;
            this.buton_Ogrenci.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buton_Ogrenci.CheckedState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.buton_Ogrenci.CheckedState.Parent = this.buton_Ogrenci;
            this.buton_Ogrenci.CustomImages.Parent = this.buton_Ogrenci;
            this.buton_Ogrenci.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(123)))), ((int)(((byte)(150)))));
            this.buton_Ogrenci.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Ogrenci.ForeColor = System.Drawing.Color.White;
            this.buton_Ogrenci.HoverState.Parent = this.buton_Ogrenci;
            this.buton_Ogrenci.Image = global::Yurt_Otomasyon.Properties.Resources.ogrenci;
            this.buton_Ogrenci.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buton_Ogrenci.ImageSize = new System.Drawing.Size(40, 50);
            this.buton_Ogrenci.Location = new System.Drawing.Point(331, 7);
            this.buton_Ogrenci.Name = "buton_Ogrenci";
            this.buton_Ogrenci.ShadowDecoration.Parent = this.buton_Ogrenci;
            this.buton_Ogrenci.Size = new System.Drawing.Size(190, 70);
            this.buton_Ogrenci.TabIndex = 0;
            this.buton_Ogrenci.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.buton_Ogrenci.TextOffset = new System.Drawing.Point(20, 0);
            this.buton_Ogrenci.Click += new System.EventHandler(this.MenuSec);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.uc_Yoklama1);
            this.panelMenu.Controls.Add(this.uc_Odeme1);
            this.panelMenu.Controls.Add(this.uc_Ogrenci1);
            this.panelMenu.Controls.Add(this.uc_Yonetici1);
            this.panelMenu.Controls.Add(this.uc_Oda1);
            this.panelMenu.Location = new System.Drawing.Point(0, 161);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShadowDecoration.Parent = this.panelMenu;
            this.panelMenu.Size = new System.Drawing.Size(1264, 761);
            this.panelMenu.TabIndex = 0;
            // 
            // uc_Yoklama1
            // 
            this.uc_Yoklama1.BackColor = System.Drawing.Color.Transparent;
            this.uc_Yoklama1.Location = new System.Drawing.Point(0, -8);
            this.uc_Yoklama1.Name = "uc_Yoklama1";
            this.uc_Yoklama1.Size = new System.Drawing.Size(1264, 760);
            this.uc_Yoklama1.TabIndex = 4;
            this.uc_Yoklama1.Visible = false;
            // 
            // uc_Odeme1
            // 
            this.uc_Odeme1.BackColor = System.Drawing.Color.Transparent;
            this.uc_Odeme1.Location = new System.Drawing.Point(0, 0);
            this.uc_Odeme1.Name = "uc_Odeme1";
            this.uc_Odeme1.Size = new System.Drawing.Size(1264, 760);
            this.uc_Odeme1.TabIndex = 3;
            this.uc_Odeme1.Visible = false;
            // 
            // uc_Ogrenci1
            // 
            this.uc_Ogrenci1.BackColor = System.Drawing.Color.Transparent;
            this.uc_Ogrenci1.Location = new System.Drawing.Point(0, 0);
            this.uc_Ogrenci1.Name = "uc_Ogrenci1";
            this.uc_Ogrenci1.Size = new System.Drawing.Size(1264, 760);
            this.uc_Ogrenci1.TabIndex = 2;
            this.uc_Ogrenci1.Visible = false;
            // 
            // uc_Yonetici1
            // 
            this.uc_Yonetici1.BackColor = System.Drawing.Color.Transparent;
            this.uc_Yonetici1.Location = new System.Drawing.Point(0, 0);
            this.uc_Yonetici1.Name = "uc_Yonetici1";
            this.uc_Yonetici1.Size = new System.Drawing.Size(1264, 760);
            this.uc_Yonetici1.TabIndex = 1;
            this.uc_Yonetici1.Visible = false;
            // 
            // uc_Oda1
            // 
            this.uc_Oda1.BackColor = System.Drawing.Color.Transparent;
            this.uc_Oda1.Location = new System.Drawing.Point(0, 0);
            this.uc_Oda1.Name = "uc_Oda1";
            this.uc_Oda1.Size = new System.Drawing.Size(1264, 760);
            this.uc_Oda1.TabIndex = 0;
            this.uc_Oda1.Visible = false;
            // 
            // OtomasyonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelButonlar);
            this.Controls.Add(this.label_YurtOtomasyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OtomasyonMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yurt Otomasyon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtomasyonMenu_FormClosing);
            this.Load += new System.EventHandler(this.OtomasyonMenu_Load);
            this.panelButonlar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_YurtOtomasyon;
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Panel panelButonlar;
        private Guna.UI2.WinForms.Guna2Button buton_Yonetici;
        private Guna.UI2.WinForms.Guna2Button buton_Yoklama;
        private Guna.UI2.WinForms.Guna2Button buton_Odeme;
        private Guna.UI2.WinForms.Guna2Button buton_Ogrenci;
        private Guna.UI2.WinForms.Guna2Button buton_Oda;
        private Paneller.Yonetici.uc_Yonetici uc_Yonetici1;
        private Paneller.Oda.uc_Oda uc_Oda1;
        private Paneller.Ogrenci.uc_Ogrenci uc_Ogrenci1;
        private Paneller.Odeme.uc_Odeme uc_Odeme1;
        private Paneller.Yoklama.uc_Yoklama uc_Yoklama1;
    }
}