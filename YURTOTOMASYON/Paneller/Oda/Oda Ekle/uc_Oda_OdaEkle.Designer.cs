
namespace Yurt_Otomasyon.Paneller.Oda.Oda_Ekle {
    partial class uc_Oda_OdaEkle {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OdaEkle = new Guna.UI2.WinForms.Guna2Button();
            this.combo_Blok = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_Kat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numeric_Oda = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numeric_Kapasite = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Oda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Kapasite)).BeginInit();
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
            this.dataGrid.Size = new System.Drawing.Size(974, 426);
            this.dataGrid.TabIndex = 5;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Doppio One", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "KAT NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Doppio One", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "BLOK ADI:";
            // 
            // btn_OdaEkle
            // 
            this.btn_OdaEkle.BorderRadius = 22;
            this.btn_OdaEkle.CheckedState.Parent = this.btn_OdaEkle;
            this.btn_OdaEkle.CustomImages.Parent = this.btn_OdaEkle;
            this.btn_OdaEkle.FillColor = System.Drawing.Color.Orange;
            this.btn_OdaEkle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdaEkle.ForeColor = System.Drawing.Color.White;
            this.btn_OdaEkle.HoverState.Parent = this.btn_OdaEkle;
            this.btn_OdaEkle.Location = new System.Drawing.Point(785, 575);
            this.btn_OdaEkle.Name = "btn_OdaEkle";
            this.btn_OdaEkle.ShadowDecoration.Parent = this.btn_OdaEkle;
            this.btn_OdaEkle.Size = new System.Drawing.Size(203, 60);
            this.btn_OdaEkle.TabIndex = 4;
            this.btn_OdaEkle.Text = "Oda Ekle";
            this.btn_OdaEkle.Click += new System.EventHandler(this.IslemGerceklestir);
            // 
            // combo_Blok
            // 
            this.combo_Blok.BackColor = System.Drawing.Color.Transparent;
            this.combo_Blok.BorderRadius = 15;
            this.combo_Blok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Blok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Blok.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Blok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Blok.FocusedState.Parent = this.combo_Blok;
            this.combo_Blok.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.combo_Blok.ForeColor = System.Drawing.Color.Black;
            this.combo_Blok.HoverState.Parent = this.combo_Blok;
            this.combo_Blok.ItemHeight = 30;
            this.combo_Blok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "R",
            "S",
            "T",
            "U",
            "V",
            "Y",
            "Z"});
            this.combo_Blok.ItemsAppearance.Parent = this.combo_Blok;
            this.combo_Blok.Location = new System.Drawing.Point(187, 464);
            this.combo_Blok.Name = "combo_Blok";
            this.combo_Blok.ShadowDecoration.Parent = this.combo_Blok;
            this.combo_Blok.Size = new System.Drawing.Size(203, 36);
            this.combo_Blok.TabIndex = 0;
            this.combo_Blok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.combo_Blok.SelectedIndexChanged += new System.EventHandler(this.KatlariDoldur);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Doppio One", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(627, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "ODA NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Doppio One", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(599, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "KAPASİTE:";
            // 
            // combo_Kat
            // 
            this.combo_Kat.BackColor = System.Drawing.Color.Transparent;
            this.combo_Kat.BorderRadius = 15;
            this.combo_Kat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Kat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Kat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Kat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Kat.FocusedState.Parent = this.combo_Kat;
            this.combo_Kat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.combo_Kat.ForeColor = System.Drawing.Color.Black;
            this.combo_Kat.HoverState.Parent = this.combo_Kat;
            this.combo_Kat.ItemHeight = 30;
            this.combo_Kat.ItemsAppearance.Parent = this.combo_Kat;
            this.combo_Kat.Location = new System.Drawing.Point(187, 522);
            this.combo_Kat.Name = "combo_Kat";
            this.combo_Kat.ShadowDecoration.Parent = this.combo_Kat;
            this.combo_Kat.Size = new System.Drawing.Size(203, 36);
            this.combo_Kat.TabIndex = 1;
            this.combo_Kat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numeric_Oda
            // 
            this.numeric_Oda.BackColor = System.Drawing.Color.Transparent;
            this.numeric_Oda.BorderRadius = 15;
            this.numeric_Oda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numeric_Oda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numeric_Oda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numeric_Oda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numeric_Oda.DisabledState.Parent = this.numeric_Oda;
            this.numeric_Oda.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numeric_Oda.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numeric_Oda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numeric_Oda.FocusedState.Parent = this.numeric_Oda;
            this.numeric_Oda.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numeric_Oda.ForeColor = System.Drawing.Color.Black;
            this.numeric_Oda.Location = new System.Drawing.Point(785, 464);
            this.numeric_Oda.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numeric_Oda.Name = "numeric_Oda";
            this.numeric_Oda.ShadowDecoration.Parent = this.numeric_Oda;
            this.numeric_Oda.Size = new System.Drawing.Size(203, 36);
            this.numeric_Oda.TabIndex = 2;
            // 
            // numeric_Kapasite
            // 
            this.numeric_Kapasite.BackColor = System.Drawing.Color.Transparent;
            this.numeric_Kapasite.BorderRadius = 15;
            this.numeric_Kapasite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numeric_Kapasite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numeric_Kapasite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numeric_Kapasite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numeric_Kapasite.DisabledState.Parent = this.numeric_Kapasite;
            this.numeric_Kapasite.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numeric_Kapasite.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numeric_Kapasite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numeric_Kapasite.FocusedState.Parent = this.numeric_Kapasite;
            this.numeric_Kapasite.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numeric_Kapasite.ForeColor = System.Drawing.Color.Black;
            this.numeric_Kapasite.Location = new System.Drawing.Point(785, 522);
            this.numeric_Kapasite.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numeric_Kapasite.Name = "numeric_Kapasite";
            this.numeric_Kapasite.ShadowDecoration.Parent = this.numeric_Kapasite;
            this.numeric_Kapasite.Size = new System.Drawing.Size(203, 36);
            this.numeric_Kapasite.TabIndex = 3;
            // 
            // uc_Oda_OdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numeric_Kapasite);
            this.Controls.Add(this.numeric_Oda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OdaEkle);
            this.Controls.Add(this.combo_Kat);
            this.Controls.Add(this.combo_Blok);
            this.Controls.Add(this.dataGrid);
            this.Name = "uc_Oda_OdaEkle";
            this.Size = new System.Drawing.Size(1003, 725);
            this.Load += new System.EventHandler(this.PanelYukle);
            this.VisibleChanged += new System.EventHandler(this.PanelYukle);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Oda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Kapasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_OdaEkle;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Blok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Kat;
        private Guna.UI2.WinForms.Guna2NumericUpDown numeric_Oda;
        private Guna.UI2.WinForms.Guna2NumericUpDown numeric_Kapasite;
    }
}
