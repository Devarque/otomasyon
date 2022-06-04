
namespace Yurt_Otomasyon.Paneller.Yoklama.Duzenle {
    partial class uc_Yoklama_Duzenle {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_YoklamaListele = new Guna.UI2.WinForms.Guna2Button();
            this.masked_TCKN = new System.Windows.Forms.MaskedTextBox();
            this.label_TCKN = new System.Windows.Forms.Label();
            this.date_Yoklama = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.check_ay = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label_ayagore = new System.Windows.Forms.Label();
            this.check_gun = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid_arama = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_CiktiAl = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_arama)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.ColumnHeadersHeight = 25;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.Black;
            this.dataGrid.Location = new System.Drawing.Point(14, 125);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid.Size = new System.Drawing.Size(972, 584);
            this.dataGrid.TabIndex = 40;
            this.dataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGrid.ThemeStyle.ReadOnly = true;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.ThemeStyle.RowsStyle.Height = 40;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.DataSourceChanged += new System.EventHandler(this.Formatla);
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VeriSec);
            this.dataGrid.VisibleChanged += new System.EventHandler(this.PanelYukle);
            // 
            // btn_YoklamaListele
            // 
            this.btn_YoklamaListele.BorderRadius = 15;
            this.btn_YoklamaListele.CheckedState.Parent = this.btn_YoklamaListele;
            this.btn_YoklamaListele.CustomImages.Parent = this.btn_YoklamaListele;
            this.btn_YoklamaListele.FillColor = System.Drawing.Color.Orange;
            this.btn_YoklamaListele.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YoklamaListele.ForeColor = System.Drawing.Color.White;
            this.btn_YoklamaListele.HoverState.Parent = this.btn_YoklamaListele;
            this.btn_YoklamaListele.Location = new System.Drawing.Point(758, 60);
            this.btn_YoklamaListele.Name = "btn_YoklamaListele";
            this.btn_YoklamaListele.ShadowDecoration.Parent = this.btn_YoklamaListele;
            this.btn_YoklamaListele.Size = new System.Drawing.Size(175, 36);
            this.btn_YoklamaListele.TabIndex = 3;
            this.btn_YoklamaListele.Tag = "sil";
            this.btn_YoklamaListele.Text = "Yoklama Listele";
            this.btn_YoklamaListele.Click += new System.EventHandler(this.IslemGerceklestir);
            // 
            // masked_TCKN
            // 
            this.masked_TCKN.AllowDrop = true;
            this.masked_TCKN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masked_TCKN.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masked_TCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masked_TCKN.Location = new System.Drawing.Point(226, 64);
            this.masked_TCKN.Mask = "00000000000";
            this.masked_TCKN.MinimumSize = new System.Drawing.Size(2, 30);
            this.masked_TCKN.Name = "masked_TCKN";
            this.masked_TCKN.Size = new System.Drawing.Size(140, 26);
            this.masked_TCKN.TabIndex = 0;
            this.masked_TCKN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.masked_TCKN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masked_TCKN.TextChanged += new System.EventHandler(this.DinamikAra);
            // 
            // label_TCKN
            // 
            this.label_TCKN.AutoSize = true;
            this.label_TCKN.BackColor = System.Drawing.Color.Transparent;
            this.label_TCKN.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_TCKN.Location = new System.Drawing.Point(18, 64);
            this.label_TCKN.Name = "label_TCKN";
            this.label_TCKN.Size = new System.Drawing.Size(202, 29);
            this.label_TCKN.TabIndex = 45;
            this.label_TCKN.Text = "ÖĞRENCİ TCKN:";
            // 
            // date_Yoklama
            // 
            this.date_Yoklama.CheckedState.Parent = this.date_Yoklama;
            this.date_Yoklama.CustomFormat = "dd MM yyyy";
            this.date_Yoklama.FillColor = System.Drawing.Color.White;
            this.date_Yoklama.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Yoklama.HoverState.Parent = this.date_Yoklama;
            this.date_Yoklama.Location = new System.Drawing.Point(403, 62);
            this.date_Yoklama.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_Yoklama.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_Yoklama.Name = "date_Yoklama";
            this.date_Yoklama.ShadowDecoration.Parent = this.date_Yoklama;
            this.date_Yoklama.Size = new System.Drawing.Size(200, 36);
            this.date_Yoklama.TabIndex = 47;
            this.date_Yoklama.Value = new System.DateTime(2021, 5, 29, 20, 47, 27, 892);
            // 
            // check_ay
            // 
            this.check_ay.Checked = true;
            this.check_ay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.check_ay.CheckedState.BorderRadius = 2;
            this.check_ay.CheckedState.BorderThickness = 0;
            this.check_ay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.check_ay.CheckedState.Parent = this.check_ay;
            this.check_ay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_ay.Location = new System.Drawing.Point(722, 60);
            this.check_ay.Name = "check_ay";
            this.check_ay.ShadowDecoration.Parent = this.check_ay;
            this.check_ay.Size = new System.Drawing.Size(20, 20);
            this.check_ay.TabIndex = 1;
            this.check_ay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.check_ay.UncheckedState.BorderRadius = 2;
            this.check_ay.UncheckedState.BorderThickness = 0;
            this.check_ay.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.check_ay.UncheckedState.Parent = this.check_ay;
            this.check_ay.Click += new System.EventHandler(this.AyAktif);
            // 
            // label_ayagore
            // 
            this.label_ayagore.AutoSize = true;
            this.label_ayagore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ayagore.Location = new System.Drawing.Point(632, 62);
            this.label_ayagore.Name = "label_ayagore";
            this.label_ayagore.Size = new System.Drawing.Size(84, 20);
            this.label_ayagore.TabIndex = 49;
            this.label_ayagore.Text = "Aya Göre";
            // 
            // check_gun
            // 
            this.check_gun.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.check_gun.CheckedState.BorderRadius = 2;
            this.check_gun.CheckedState.BorderThickness = 0;
            this.check_gun.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.check_gun.CheckedState.Parent = this.check_gun;
            this.check_gun.Location = new System.Drawing.Point(722, 82);
            this.check_gun.Name = "check_gun";
            this.check_gun.ShadowDecoration.Parent = this.check_gun;
            this.check_gun.Size = new System.Drawing.Size(20, 20);
            this.check_gun.TabIndex = 2;
            this.check_gun.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.check_gun.UncheckedState.BorderRadius = 2;
            this.check_gun.UncheckedState.BorderThickness = 0;
            this.check_gun.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.check_gun.UncheckedState.Parent = this.check_gun;
            this.check_gun.Click += new System.EventHandler(this.GunAktif);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(618, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Güne Göre";
            // 
            // dataGrid_arama
            // 
            this.dataGrid_arama.AllowUserToAddRows = false;
            this.dataGrid_arama.AllowUserToDeleteRows = false;
            this.dataGrid_arama.AllowUserToResizeColumns = false;
            this.dataGrid_arama.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataGrid_arama.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid_arama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_arama.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_arama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_arama.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_arama.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_arama.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGrid_arama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_arama.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGrid_arama.EnableHeadersVisualStyles = false;
            this.dataGrid_arama.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataGrid_arama.Location = new System.Drawing.Point(372, 13);
            this.dataGrid_arama.MultiSelect = false;
            this.dataGrid_arama.Name = "dataGrid_arama";
            this.dataGrid_arama.ReadOnly = true;
            this.dataGrid_arama.RowHeadersVisible = false;
            this.dataGrid_arama.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid_arama.RowTemplate.Height = 15;
            this.dataGrid_arama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_arama.Size = new System.Drawing.Size(309, 101);
            this.dataGrid_arama.TabIndex = 50;
            this.dataGrid_arama.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dataGrid_arama.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataGrid_arama.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_arama.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_arama.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_arama.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_arama.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_arama.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataGrid_arama.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dataGrid_arama.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_arama.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGrid_arama.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_arama.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_arama.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGrid_arama.ThemeStyle.ReadOnly = true;
            this.dataGrid_arama.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dataGrid_arama.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_arama.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGrid_arama.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_arama.ThemeStyle.RowsStyle.Height = 15;
            this.dataGrid_arama.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dataGrid_arama.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_arama.Visible = false;
            this.dataGrid_arama.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OgrenciSec);
            // 
            // btn_CiktiAl
            // 
            this.btn_CiktiAl.BorderRadius = 22;
            this.btn_CiktiAl.CheckedState.Parent = this.btn_CiktiAl;
            this.btn_CiktiAl.CustomImages.Parent = this.btn_CiktiAl;
            this.btn_CiktiAl.FillColor = System.Drawing.Color.Transparent;
            this.btn_CiktiAl.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CiktiAl.ForeColor = System.Drawing.Color.White;
            this.btn_CiktiAl.HoverState.Parent = this.btn_CiktiAl;
            this.btn_CiktiAl.Image = global::Yurt_Otomasyon.Properties.Resources.yazdir;
            this.btn_CiktiAl.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_CiktiAl.Location = new System.Drawing.Point(939, 49);
            this.btn_CiktiAl.Name = "btn_CiktiAl";
            this.btn_CiktiAl.ShadowDecoration.Parent = this.btn_CiktiAl;
            this.btn_CiktiAl.Size = new System.Drawing.Size(49, 53);
            this.btn_CiktiAl.TabIndex = 4;
            this.btn_CiktiAl.Click += new System.EventHandler(this.CiktiOlustur);
            // 
            // uc_Yoklama_Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_CiktiAl);
            this.Controls.Add(this.dataGrid_arama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check_gun);
            this.Controls.Add(this.label_ayagore);
            this.Controls.Add(this.check_ay);
            this.Controls.Add(this.date_Yoklama);
            this.Controls.Add(this.masked_TCKN);
            this.Controls.Add(this.label_TCKN);
            this.Controls.Add(this.btn_YoklamaListele);
            this.Controls.Add(this.dataGrid);
            this.Name = "uc_Yoklama_Duzenle";
            this.Size = new System.Drawing.Size(1003, 725);
            this.Load += new System.EventHandler(this.PanelYukle);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_arama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private Guna.UI2.WinForms.Guna2Button btn_YoklamaListele;
        private System.Windows.Forms.MaskedTextBox masked_TCKN;
        private System.Windows.Forms.Label label_TCKN;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_Yoklama;
        private Guna.UI2.WinForms.Guna2CustomCheckBox check_ay;
        private System.Windows.Forms.Label label_ayagore;
        private Guna.UI2.WinForms.Guna2CustomCheckBox check_gun;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_arama;
        private Guna.UI2.WinForms.Guna2Button btn_CiktiAl;
    }
}
