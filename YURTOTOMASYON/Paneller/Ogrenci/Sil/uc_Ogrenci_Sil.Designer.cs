
namespace Yurt_Otomasyon.Paneller.Ogrenci.Sil {
    partial class uc_Ogrenci_Sil {
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
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.masked_TCKN = new System.Windows.Forms.MaskedTextBox();
            this.btn_Listele = new Guna.UI2.WinForms.Guna2Button();
            this.combo_Oda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_Kat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_Blok = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OgrenciSil = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.dataGrid.Location = new System.Drawing.Point(15, 152);
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
            this.dataGrid.RowTemplate.Height = 110;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(972, 554);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
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
            this.dataGrid.ThemeStyle.RowsStyle.Height = 110;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(199)))), ((int)(((byte)(220)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VeriSec);
            // 
            // masked_TCKN
            // 
            this.masked_TCKN.AllowDrop = true;
            this.masked_TCKN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masked_TCKN.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masked_TCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masked_TCKN.Location = new System.Drawing.Point(284, 94);
            this.masked_TCKN.Mask = "00000000000";
            this.masked_TCKN.MinimumSize = new System.Drawing.Size(2, 30);
            this.masked_TCKN.Name = "masked_TCKN";
            this.masked_TCKN.Size = new System.Drawing.Size(140, 26);
            this.masked_TCKN.TabIndex = 3;
            this.masked_TCKN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.masked_TCKN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masked_TCKN.TextChanged += new System.EventHandler(this.DinamikAra);
            // 
            // btn_Listele
            // 
            this.btn_Listele.BorderRadius = 22;
            this.btn_Listele.CheckedState.Parent = this.btn_Listele;
            this.btn_Listele.CustomImages.Parent = this.btn_Listele;
            this.btn_Listele.FillColor = System.Drawing.Color.Tan;
            this.btn_Listele.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.ForeColor = System.Drawing.Color.White;
            this.btn_Listele.HoverState.Parent = this.btn_Listele;
            this.btn_Listele.Location = new System.Drawing.Point(762, 33);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.ShadowDecoration.Parent = this.btn_Listele;
            this.btn_Listele.Size = new System.Drawing.Size(191, 49);
            this.btn_Listele.TabIndex = 4;
            this.btn_Listele.Tag = "ara";
            this.btn_Listele.Text = "Öğrenci Listele";
            this.btn_Listele.Click += new System.EventHandler(this.IslemGerceklestir);
            // 
            // combo_Oda
            // 
            this.combo_Oda.BackColor = System.Drawing.Color.White;
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
            this.combo_Oda.Location = new System.Drawing.Point(622, 39);
            this.combo_Oda.Name = "combo_Oda";
            this.combo_Oda.ShadowDecoration.Parent = this.combo_Oda;
            this.combo_Oda.Size = new System.Drawing.Size(119, 36);
            this.combo_Oda.TabIndex = 2;
            // 
            // combo_Kat
            // 
            this.combo_Kat.BackColor = System.Drawing.Color.White;
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
            this.combo_Kat.Location = new System.Drawing.Point(453, 39);
            this.combo_Kat.Name = "combo_Kat";
            this.combo_Kat.ShadowDecoration.Parent = this.combo_Kat;
            this.combo_Kat.Size = new System.Drawing.Size(134, 36);
            this.combo_Kat.TabIndex = 1;
            this.combo_Kat.SelectedIndexChanged += new System.EventHandler(this.OdalariDoldur);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(632, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "ODA NO:";
            // 
            // combo_Blok
            // 
            this.combo_Blok.BackColor = System.Drawing.Color.White;
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
            this.combo_Blok.Location = new System.Drawing.Point(284, 40);
            this.combo_Blok.Name = "combo_Blok";
            this.combo_Blok.ShadowDecoration.Parent = this.combo_Blok;
            this.combo_Blok.Size = new System.Drawing.Size(140, 36);
            this.combo_Blok.TabIndex = 0;
            this.combo_Blok.SelectedIndexChanged += new System.EventHandler(this.KatlariDoldur);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(470, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "KAT NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(293, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "BLOK ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "ÖĞRENCİ TCKN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "ODA BİLGİLERİ:";
            // 
            // btn_OgrenciSil
            // 
            this.btn_OgrenciSil.BorderRadius = 22;
            this.btn_OgrenciSil.CheckedState.Parent = this.btn_OgrenciSil;
            this.btn_OgrenciSil.CustomImages.Parent = this.btn_OgrenciSil;
            this.btn_OgrenciSil.FillColor = System.Drawing.Color.Orange;
            this.btn_OgrenciSil.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OgrenciSil.ForeColor = System.Drawing.Color.White;
            this.btn_OgrenciSil.HoverState.Parent = this.btn_OgrenciSil;
            this.btn_OgrenciSil.Location = new System.Drawing.Point(762, 88);
            this.btn_OgrenciSil.Name = "btn_OgrenciSil";
            this.btn_OgrenciSil.ShadowDecoration.Parent = this.btn_OgrenciSil;
            this.btn_OgrenciSil.Size = new System.Drawing.Size(191, 47);
            this.btn_OgrenciSil.TabIndex = 5;
            this.btn_OgrenciSil.Tag = "sil";
            this.btn_OgrenciSil.Text = "Öğrenci Sil";
            this.btn_OgrenciSil.Click += new System.EventHandler(this.IslemGerceklestir);
            // 
            // uc_Ogrenci_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.masked_TCKN);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.combo_Oda);
            this.Controls.Add(this.combo_Kat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_Blok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OgrenciSil);
            this.Controls.Add(this.dataGrid);
            this.Name = "uc_Ogrenci_Sil";
            this.Size = new System.Drawing.Size(1003, 725);
            this.Load += new System.EventHandler(this.PanelYukle);
            this.VisibleChanged += new System.EventHandler(this.PanelYukle);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private System.Windows.Forms.MaskedTextBox masked_TCKN;
        private Guna.UI2.WinForms.Guna2Button btn_Listele;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Oda;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Kat;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Blok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_OgrenciSil;
    }
}
