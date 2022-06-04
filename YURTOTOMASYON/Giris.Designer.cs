
namespace Yurt_Otomasyon {
    partial class Giris {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.exitButon = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buton_giris = new Guna.UI2.WinForms.Guna2Button();
            this.hataliGiris = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_kullaniciAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_sifre = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButon
            // 
            this.exitButon.BackColor = System.Drawing.Color.Transparent;
            this.exitButon.CheckedState.Parent = this.exitButon;
            this.exitButon.CustomImages.Parent = this.exitButon;
            this.exitButon.FillColor = System.Drawing.Color.Red;
            this.exitButon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.exitButon.ForeColor = System.Drawing.Color.White;
            this.exitButon.HoverState.Parent = this.exitButon;
            this.exitButon.Location = new System.Drawing.Point(549, 18);
            this.exitButon.Name = "exitButon";
            this.exitButon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButon.ShadowDecoration.Parent = this.exitButon;
            this.exitButon.Size = new System.Drawing.Size(34, 34);
            this.exitButon.TabIndex = 4;
            this.exitButon.Text = "X";
            this.exitButon.Click += new System.EventHandler(this.exitButon_Click);
            // 
            // buton_giris
            // 
            this.buton_giris.BackColor = System.Drawing.Color.Transparent;
            this.buton_giris.BorderRadius = 25;
            this.buton_giris.CheckedState.Parent = this.buton_giris;
            this.buton_giris.CustomImages.Parent = this.buton_giris;
            this.buton_giris.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buton_giris.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton_giris.ForeColor = System.Drawing.Color.White;
            this.buton_giris.HoverState.Parent = this.buton_giris;
            this.buton_giris.Location = new System.Drawing.Point(334, 181);
            this.buton_giris.Name = "buton_giris";
            this.buton_giris.ShadowDecoration.Parent = this.buton_giris;
            this.buton_giris.Size = new System.Drawing.Size(198, 45);
            this.buton_giris.TabIndex = 2;
            this.buton_giris.Text = "Giriş Yap";
            this.buton_giris.Click += new System.EventHandler(this.buton_giris_Click);
            // 
            // hataliGiris
            // 
            this.hataliGiris.AutoSize = true;
            this.hataliGiris.BackColor = System.Drawing.Color.Transparent;
            this.hataliGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hataliGiris.ForeColor = System.Drawing.Color.White;
            this.hataliGiris.Location = new System.Drawing.Point(317, 229);
            this.hataliGiris.Name = "hataliGiris";
            this.hataliGiris.Size = new System.Drawing.Size(239, 20);
            this.hataliGiris.TabIndex = 3;
            this.hataliGiris.Text = "Kullanıcı adı veya şifre hatalı!";
            this.hataliGiris.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "YURT OTOMASYONU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yurt_Otomasyon.Properties.Resources.yurt;
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.textBox_kullaniciAdi.BorderColor = System.Drawing.Color.White;
            this.textBox_kullaniciAdi.BorderRadius = 22;
            this.textBox_kullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_kullaniciAdi.DefaultText = "";
            this.textBox_kullaniciAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_kullaniciAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_kullaniciAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_kullaniciAdi.DisabledState.Parent = this.textBox_kullaniciAdi;
            this.textBox_kullaniciAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_kullaniciAdi.FillColor = System.Drawing.Color.Gray;
            this.textBox_kullaniciAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_kullaniciAdi.FocusedState.Parent = this.textBox_kullaniciAdi;
            this.textBox_kullaniciAdi.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.textBox_kullaniciAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_kullaniciAdi.HoverState.Parent = this.textBox_kullaniciAdi;
            this.textBox_kullaniciAdi.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBox_kullaniciAdi.IconLeftSize = new System.Drawing.Size(25, 30);
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(334, 66);
            this.textBox_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.PasswordChar = '\0';
            this.textBox_kullaniciAdi.PlaceholderForeColor = System.Drawing.Color.White;
            this.textBox_kullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.textBox_kullaniciAdi.SelectedText = "";
            this.textBox_kullaniciAdi.ShadowDecoration.Parent = this.textBox_kullaniciAdi;
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(198, 42);
            this.textBox_kullaniciAdi.TabIndex = 0;
            this.textBox_kullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.BackColor = System.Drawing.Color.Transparent;
            this.textBox_sifre.BorderColor = System.Drawing.Color.White;
            this.textBox_sifre.BorderRadius = 22;
            this.textBox_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_sifre.DefaultText = "";
            this.textBox_sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_sifre.DisabledState.Parent = this.textBox_sifre;
            this.textBox_sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_sifre.FillColor = System.Drawing.Color.Gray;
            this.textBox_sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_sifre.FocusedState.Parent = this.textBox_sifre;
            this.textBox_sifre.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_sifre.ForeColor = System.Drawing.Color.White;
            this.textBox_sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_sifre.HoverState.Parent = this.textBox_sifre;
            this.textBox_sifre.IconLeftSize = new System.Drawing.Size(35, 30);
            this.textBox_sifre.Location = new System.Drawing.Point(334, 123);
            this.textBox_sifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.PlaceholderForeColor = System.Drawing.Color.White;
            this.textBox_sifre.PlaceholderText = "Şifre";
            this.textBox_sifre.SelectedText = "";
            this.textBox_sifre.ShadowDecoration.Parent = this.textBox_sifre;
            this.textBox_sifre.Size = new System.Drawing.Size(198, 42);
            this.textBox_sifre.TabIndex = 1;
            this.textBox_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Giris
            // 
            this.AcceptButton = this.buton_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_kullaniciAdi);
            this.Controls.Add(this.hataliGiris);
            this.Controls.Add(this.buton_giris);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.exitButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yurt Otomasyon Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton exitButon;
        private Guna.UI2.WinForms.Guna2TextBox textBox_sifre;
        private Guna.UI2.WinForms.Guna2TextBox textBox_kullaniciAdi;
        private Guna.UI2.WinForms.Guna2Button buton_giris;
        private System.Windows.Forms.Label hataliGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

