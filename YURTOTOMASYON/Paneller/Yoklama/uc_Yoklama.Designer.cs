
namespace Yurt_Otomasyon.Paneller.Yoklama {
    partial class uc_Yoklama {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelBolum = new Guna.UI2.WinForms.Guna2Panel();
            this.uc_Yoklama_Duzenle1 = new Yurt_Otomasyon.Paneller.Yoklama.Duzenle.uc_Yoklama_Duzenle();
            this.panelBolum.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBolum
            // 
            this.panelBolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.panelBolum.Controls.Add(this.uc_Yoklama_Duzenle1);
            this.panelBolum.Location = new System.Drawing.Point(0, 20);
            this.panelBolum.Name = "panelBolum";
            this.panelBolum.ShadowDecoration.Parent = this.panelBolum;
            this.panelBolum.Size = new System.Drawing.Size(1251, 725);
            this.panelBolum.TabIndex = 4;
            // 
            // uc_Yoklama_Duzenle1
            // 
            this.uc_Yoklama_Duzenle1.Location = new System.Drawing.Point(139, 0);
            this.uc_Yoklama_Duzenle1.Name = "uc_Yoklama_Duzenle1";
            this.uc_Yoklama_Duzenle1.Size = new System.Drawing.Size(1003, 725);
            this.uc_Yoklama_Duzenle1.TabIndex = 0;
            // 
            // uc_Yoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBolum);
            this.Name = "uc_Yoklama";
            this.Size = new System.Drawing.Size(1264, 760);
            this.panelBolum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelBolum;
        private Duzenle.uc_Yoklama_Duzenle uc_Yoklama_Duzenle1;
    }
}
