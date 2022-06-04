
namespace Yurt_Otomasyon.Paneller.Oda.Oda_Sil {
    partial class uc_Oda_OdaSil {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.combo_Oda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_Kat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_Blok = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_OdaAra = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OdaSil = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TumOdalar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_Oda
            // 
            this.combo_Oda.BackColor = System.Drawing.Color.Transparent;
            this.combo_Oda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Oda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Oda.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Oda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Oda.FocusedState.Parent = this.combo_Oda;
            this.combo_Oda.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Oda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Oda.HoverState.Parent = this.combo_Oda;
            this.combo_Oda.ItemHeight = 30;
            this.combo_Oda.ItemsAppearance.Parent = this.combo_Oda;
            this.combo_Oda.Location = new System.Drawing.Point(627, 633);
            this.combo_Oda.Name = "combo_Oda";
            this.combo_Oda.ShadowDecoration.Parent = this.combo_Oda;
            this.combo_Oda.Size = new System.Drawing.Size(178, 36);
            this.combo_Oda.TabIndex = 2;
            // 
            // combo_Kat
            // 
            this.combo_Kat.BackColor = System.Drawing.Color.Transparent;
            this.combo_Kat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Kat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Kat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Kat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Kat.FocusedState.Parent = this.combo_Kat;
            this.combo_Kat.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Kat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Kat.HoverState.Parent = this.combo_Kat;
            this.combo_Kat.ItemHeight = 30;
            this.combo_Kat.ItemsAppearance.Parent = this.combo_Kat;
            this.combo_Kat.Location = new System.Drawing.Point(422, 633);
            this.combo_Kat.Name = "combo_Kat";
            this.combo_Kat.ShadowDecoration.Parent = this.combo_Kat;
            this.combo_Kat.Size = new System.Drawing.Size(178, 36);
            this.combo_Kat.TabIndex = 1;
            this.combo_Kat.Tag = "kat";
            this.combo_Kat.SelectedIndexChanged += new System.EventHandler(this.OdalariDoldur);
            // 
            // combo_Blok
            // 
            this.combo_Blok.BackColor = System.Drawing.Color.Transparent;
            this.combo_Blok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Blok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Blok.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Blok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Blok.FocusedState.Parent = this.combo_Blok;
            this.combo_Blok.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Blok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Blok.HoverState.Parent = this.combo_Blok;
            this.combo_Blok.ItemHeight = 30;
            this.combo_Blok.ItemsAppearance.Parent = this.combo_Blok;
            this.combo_Blok.Location = new System.Drawing.Point(223, 633);
            this.combo_Blok.Name = "combo_Blok";
            this.combo_Blok.ShadowDecoration.Parent = this.combo_Blok;
            this.combo_Blok.Size = new System.Drawing.Size(178, 36);
            this.combo_Blok.TabIndex = 0;
            this.combo_Blok.Tag = "blok";
            this.combo_Blok.SelectedIndexChanged += new System.EventHandler(this.KatlariDoldur);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(667, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "ODA NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(456, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "KAT NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(257, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "BLOK ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "ODA BİLGİLERİ:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeight = 25;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(199)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dataGrid.Location = new System.Drawing.Point(15, 14);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(972, 494);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGrid.ThemeStyle.ReadOnly = true;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(199)))), ((int)(((byte)(220)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VeriSec);
            // 
            // btn_OdaAra
            // 
            this.btn_OdaAra.BorderRadius = 22;
            this.btn_OdaAra.CheckedState.Parent = this.btn_OdaAra;
            this.btn_OdaAra.CustomImages.Parent = this.btn_OdaAra;
            this.btn_OdaAra.FillColor = System.Drawing.Color.Tan;
            this.btn_OdaAra.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdaAra.ForeColor = System.Drawing.Color.White;
            this.btn_OdaAra.HoverState.Parent = this.btn_OdaAra;
            this.btn_OdaAra.Location = new System.Drawing.Point(823, 607);
            this.btn_OdaAra.Name = "btn_OdaAra";
            this.btn_OdaAra.ShadowDecoration.Parent = this.btn_OdaAra;
            this.btn_OdaAra.Size = new System.Drawing.Size(164, 44);
            this.btn_OdaAra.TabIndex = 4;
            this.btn_OdaAra.Tag = "ara";
            this.btn_OdaAra.Text = "Oda Ara";
            this.btn_OdaAra.Click += new System.EventHandler(this.IslemGerceklestir);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "SİLMEK İSTEDİĞİNİZ ODAYI LİSTEDEN SEÇİNİZ";
            // 
            // btn_OdaSil
            // 
            this.btn_OdaSil.BorderRadius = 22;
            this.btn_OdaSil.CheckedState.Parent = this.btn_OdaSil;
            this.btn_OdaSil.CustomImages.Parent = this.btn_OdaSil;
            this.btn_OdaSil.FillColor = System.Drawing.Color.Orange;
            this.btn_OdaSil.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdaSil.ForeColor = System.Drawing.Color.White;
            this.btn_OdaSil.HoverState.Parent = this.btn_OdaSil;
            this.btn_OdaSil.Location = new System.Drawing.Point(823, 520);
            this.btn_OdaSil.Name = "btn_OdaSil";
            this.btn_OdaSil.ShadowDecoration.Parent = this.btn_OdaSil;
            this.btn_OdaSil.Size = new System.Drawing.Size(164, 44);
            this.btn_OdaSil.TabIndex = 3;
            this.btn_OdaSil.Tag = "sil";
            this.btn_OdaSil.Text = "Oda Sil";
            this.btn_OdaSil.Click += new System.EventHandler(this.IslemGerceklestir);
            // 
            // btn_TumOdalar
            // 
            this.btn_TumOdalar.BorderRadius = 15;
            this.btn_TumOdalar.CheckedState.Parent = this.btn_TumOdalar;
            this.btn_TumOdalar.CustomImages.Parent = this.btn_TumOdalar;
            this.btn_TumOdalar.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_TumOdalar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TumOdalar.ForeColor = System.Drawing.Color.White;
            this.btn_TumOdalar.HoverState.Parent = this.btn_TumOdalar;
            this.btn_TumOdalar.Location = new System.Drawing.Point(823, 657);
            this.btn_TumOdalar.Name = "btn_TumOdalar";
            this.btn_TumOdalar.ShadowDecoration.Parent = this.btn_TumOdalar;
            this.btn_TumOdalar.Size = new System.Drawing.Size(164, 33);
            this.btn_TumOdalar.TabIndex = 5;
            this.btn_TumOdalar.Text = "Tüm Odaları Listele";
            this.btn_TumOdalar.Click += new System.EventHandler(this.PanelYukle);
            // 
            // uc_Oda_OdaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_TumOdalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_OdaSil);
            this.Controls.Add(this.btn_OdaAra);
            this.Controls.Add(this.combo_Oda);
            this.Controls.Add(this.combo_Kat);
            this.Controls.Add(this.combo_Blok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Name = "uc_Oda_OdaSil";
            this.Size = new System.Drawing.Size(1003, 725);
            this.Load += new System.EventHandler(this.PanelYukle);
            this.VisibleChanged += new System.EventHandler(this.PanelYukle);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox combo_Oda;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Kat;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Blok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private Guna.UI2.WinForms.Guna2Button btn_OdaAra;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_OdaSil;
        private Guna.UI2.WinForms.Guna2Button btn_TumOdalar;
    }
}
