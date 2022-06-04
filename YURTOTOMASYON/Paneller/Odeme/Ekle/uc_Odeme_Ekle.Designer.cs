
using System;

namespace Yurt_Otomasyon.Paneller.Odeme.Ekle {
    partial class uc_Odeme_Ekle {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBox_KalanOdeme = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.date_Odeme = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Odeme = new Guna.UI2.WinForms.Guna2Button();
            this.label_odemeDurum = new System.Windows.Forms.Label();
            this.dataGrid_arama = new Guna.UI2.WinForms.Guna2DataGridView();
            this.masked_TCKN = new System.Windows.Forms.MaskedTextBox();
            this.label_TCKN = new System.Windows.Forms.Label();
            this.btn_YoklamaListele = new Guna.UI2.WinForms.Guna2Button();
            this.masked_YilSec = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ayagore = new System.Windows.Forms.Label();
            this.check_Yil = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(972, 485);
            this.dataGrid.TabIndex = 7;
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
            this.dataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(199)))), ((int)(((byte)(220)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VeriSec);
            // 
            // txtBox_KalanOdeme
            // 
            this.txtBox_KalanOdeme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_KalanOdeme.DefaultText = "";
            this.txtBox_KalanOdeme.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_KalanOdeme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_KalanOdeme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_KalanOdeme.DisabledState.Parent = this.txtBox_KalanOdeme;
            this.txtBox_KalanOdeme.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_KalanOdeme.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_KalanOdeme.FocusedState.Parent = this.txtBox_KalanOdeme;
            this.txtBox_KalanOdeme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_KalanOdeme.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_KalanOdeme.HoverState.Parent = this.txtBox_KalanOdeme;
            this.txtBox_KalanOdeme.Location = new System.Drawing.Point(152, 662);
            this.txtBox_KalanOdeme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_KalanOdeme.Name = "txtBox_KalanOdeme";
            this.txtBox_KalanOdeme.PasswordChar = '\0';
            this.txtBox_KalanOdeme.PlaceholderText = "";
            this.txtBox_KalanOdeme.ReadOnly = true;
            this.txtBox_KalanOdeme.SelectedText = "";
            this.txtBox_KalanOdeme.ShadowDecoration.Parent = this.txtBox_KalanOdeme;
            this.txtBox_KalanOdeme.Size = new System.Drawing.Size(200, 34);
            this.txtBox_KalanOdeme.TabIndex = 25;
            this.txtBox_KalanOdeme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 662);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 38);
            this.label8.TabIndex = 26;
            this.label8.Text = "KALAN TOPLAM\r\nTAKSİT TUTARI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date_Odeme
            // 
            this.date_Odeme.BackColor = System.Drawing.Color.Transparent;
            this.date_Odeme.BorderRadius = 15;
            this.date_Odeme.CheckedState.Parent = this.date_Odeme;
            this.date_Odeme.FillColor = System.Drawing.Color.White;
            this.date_Odeme.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_Odeme.HoverState.Parent = this.date_Odeme;
            this.date_Odeme.Location = new System.Drawing.Point(520, 649);
            this.date_Odeme.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_Odeme.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_Odeme.Name = "date_Odeme";
            this.date_Odeme.ShadowDecoration.Parent = this.date_Odeme;
            this.date_Odeme.Size = new System.Drawing.Size(200, 30);
            this.date_Odeme.TabIndex = 28;
            this.date_Odeme.Tag = "tarih";
            this.date_Odeme.Value = new System.DateTime(2021, 5, 27, 21, 19, 43, 71);
            this.date_Odeme.ValueChanged += new System.EventHandler(this.OdemeDurumunuBelirle);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(380, 657);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "ÖDEME TARİHİ:";
            // 
            // btn_Odeme
            // 
            this.btn_Odeme.BorderRadius = 22;
            this.btn_Odeme.CheckedState.Parent = this.btn_Odeme;
            this.btn_Odeme.CustomImages.Parent = this.btn_Odeme;
            this.btn_Odeme.FillColor = System.Drawing.Color.Orange;
            this.btn_Odeme.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Odeme.ForeColor = System.Drawing.Color.White;
            this.btn_Odeme.HoverState.Parent = this.btn_Odeme;
            this.btn_Odeme.Location = new System.Drawing.Point(769, 657);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.ShadowDecoration.Parent = this.btn_Odeme;
            this.btn_Odeme.Size = new System.Drawing.Size(200, 46);
            this.btn_Odeme.TabIndex = 6;
            this.btn_Odeme.Tag = "ode";
            this.btn_Odeme.Text = "ÖDEME YAP";
            this.btn_Odeme.Click += new System.EventHandler(this.IslemGerceklestir);
            // 
            // label_odemeDurum
            // 
            this.label_odemeDurum.AutoSize = true;
            this.label_odemeDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_odemeDurum.ForeColor = System.Drawing.Color.Red;
            this.label_odemeDurum.Location = new System.Drawing.Point(520, 685);
            this.label_odemeDurum.Name = "label_odemeDurum";
            this.label_odemeDurum.Size = new System.Drawing.Size(0, 20);
            this.label_odemeDurum.TabIndex = 71;
            // 
            // dataGrid_arama
            // 
            this.dataGrid_arama.AllowUserToAddRows = false;
            this.dataGrid_arama.AllowUserToDeleteRows = false;
            this.dataGrid_arama.AllowUserToResizeColumns = false;
            this.dataGrid_arama.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataGrid_arama.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_arama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_arama.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_arama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_arama.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_arama.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_arama.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_arama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_arama.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_arama.EnableHeadersVisualStyles = false;
            this.dataGrid_arama.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataGrid_arama.Location = new System.Drawing.Point(376, 24);
            this.dataGrid_arama.MultiSelect = false;
            this.dataGrid_arama.Name = "dataGrid_arama";
            this.dataGrid_arama.ReadOnly = true;
            this.dataGrid_arama.RowHeadersVisible = false;
            this.dataGrid_arama.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid_arama.RowTemplate.Height = 15;
            this.dataGrid_arama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_arama.Size = new System.Drawing.Size(333, 101);
            this.dataGrid_arama.TabIndex = 81;
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
            // masked_TCKN
            // 
            this.masked_TCKN.AllowDrop = true;
            this.masked_TCKN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masked_TCKN.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masked_TCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masked_TCKN.Location = new System.Drawing.Point(230, 70);
            this.masked_TCKN.Mask = "00000000000";
            this.masked_TCKN.MinimumSize = new System.Drawing.Size(2, 30);
            this.masked_TCKN.Name = "masked_TCKN";
            this.masked_TCKN.Size = new System.Drawing.Size(140, 26);
            this.masked_TCKN.TabIndex = 73;
            this.masked_TCKN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.masked_TCKN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masked_TCKN.TextChanged += new System.EventHandler(this.DinamikAra);
            // 
            // label_TCKN
            // 
            this.label_TCKN.AutoSize = true;
            this.label_TCKN.BackColor = System.Drawing.Color.Transparent;
            this.label_TCKN.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_TCKN.Location = new System.Drawing.Point(22, 70);
            this.label_TCKN.Name = "label_TCKN";
            this.label_TCKN.Size = new System.Drawing.Size(202, 29);
            this.label_TCKN.TabIndex = 77;
            this.label_TCKN.Text = "ÖĞRENCİ TCKN:";
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
            this.btn_YoklamaListele.Location = new System.Drawing.Point(743, 63);
            this.btn_YoklamaListele.Name = "btn_YoklamaListele";
            this.btn_YoklamaListele.ShadowDecoration.Parent = this.btn_YoklamaListele;
            this.btn_YoklamaListele.Size = new System.Drawing.Size(175, 36);
            this.btn_YoklamaListele.TabIndex = 76;
            this.btn_YoklamaListele.Tag = "ara";
            this.btn_YoklamaListele.Text = "Taksitleri Listele";
            this.btn_YoklamaListele.Click += new System.EventHandler(this.IslemGerceklestir);
            // 
            // masked_YilSec
            // 
            this.masked_YilSec.AllowDrop = true;
            this.masked_YilSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masked_YilSec.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masked_YilSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masked_YilSec.Location = new System.Drawing.Point(558, 63);
            this.masked_YilSec.Mask = "0000";
            this.masked_YilSec.MinimumSize = new System.Drawing.Size(2, 30);
            this.masked_YilSec.Name = "masked_YilSec";
            this.masked_YilSec.Size = new System.Drawing.Size(140, 26);
            this.masked_YilSec.TabIndex = 73;
            this.masked_YilSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.masked_YilSec.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masked_YilSec.TextChanged += new System.EventHandler(this.DinamikAra);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(493, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "YIL:";
            // 
            // label_ayagore
            // 
            this.label_ayagore.AutoSize = true;
            this.label_ayagore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ayagore.Location = new System.Drawing.Point(554, 40);
            this.label_ayagore.Name = "label_ayagore";
            this.label_ayagore.Size = new System.Drawing.Size(117, 20);
            this.label_ayagore.TabIndex = 83;
            this.label_ayagore.Text = "Yıla Göre Ara";
            // 
            // check_Yil
            // 
            this.check_Yil.Checked = true;
            this.check_Yil.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.check_Yil.CheckedState.BorderRadius = 2;
            this.check_Yil.CheckedState.BorderThickness = 0;
            this.check_Yil.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.check_Yil.CheckedState.Parent = this.check_Yil;
            this.check_Yil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Yil.Location = new System.Drawing.Point(677, 40);
            this.check_Yil.Name = "check_Yil";
            this.check_Yil.ShadowDecoration.Parent = this.check_Yil;
            this.check_Yil.Size = new System.Drawing.Size(20, 20);
            this.check_Yil.TabIndex = 82;
            this.check_Yil.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.check_Yil.UncheckedState.BorderRadius = 2;
            this.check_Yil.UncheckedState.BorderThickness = 0;
            this.check_Yil.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.check_Yil.UncheckedState.Parent = this.check_Yil;
            this.check_Yil.CheckedChanged += new System.EventHandler(this.CheckBoxKontrol);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(363, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "ÖDEME DURUMU:";
            // 
            // uc_Odeme_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid_arama);
            this.Controls.Add(this.label_ayagore);
            this.Controls.Add(this.check_Yil);
            this.Controls.Add(this.masked_YilSec);
            this.Controls.Add(this.masked_TCKN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_TCKN);
            this.Controls.Add(this.btn_YoklamaListele);
            this.Controls.Add(this.label_odemeDurum);
            this.Controls.Add(this.btn_Odeme);
            this.Controls.Add(this.date_Odeme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBox_KalanOdeme);
            this.Controls.Add(this.dataGrid);
            this.Name = "uc_Odeme_Ekle";
            this.Size = new System.Drawing.Size(1003, 725);
            this.Load += new System.EventHandler(this.PanelYukle);
            this.VisibleChanged += new System.EventHandler(this.PanelYukle);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_arama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_KalanOdeme;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_Odeme;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btn_Odeme;
        private System.Windows.Forms.Label label_odemeDurum;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_arama;
        private System.Windows.Forms.MaskedTextBox masked_TCKN;
        private System.Windows.Forms.Label label_TCKN;
        private Guna.UI2.WinForms.Guna2Button btn_YoklamaListele;
        private System.Windows.Forms.MaskedTextBox masked_YilSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ayagore;
        private Guna.UI2.WinForms.Guna2CustomCheckBox check_Yil;
        private System.Windows.Forms.Label label2;
    }
}
