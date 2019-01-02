namespace MainUIForm
{
    partial class SiparisDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisDetay));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MIKTARTEXT = new System.Windows.Forms.TextBox();
            this.MIKTAR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNBUL = new System.Windows.Forms.Button();
            this.URUN = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ODEME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MUSTERI = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BTNSIL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FIYAT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ACIKLAMA = new System.Windows.Forms.RichTextBox();
            this.ACIKLABEL = new System.Windows.Forms.Label();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.URUN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSTERI.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(943, 290);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Arama Yapın...";
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsPrint.RtfPageFooter = resources.GetString("gridView1.OptionsPrint.RtfPageFooter");
            this.gridView1.OptionsPrint.RtfPageHeader = resources.GetString("gridView1.OptionsPrint.RtfPageHeader");
            this.gridView1.OptionsView.RowAutoHeight = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.MIKTARTEXT);
            this.groupBox1.Controls.Add(this.MIKTAR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BTNBUL);
            this.groupBox1.Controls.Add(this.URUN);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ODEME);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MUSTERI);
            this.groupBox1.Controls.Add(this.BTNSIL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FIYAT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ACIKLAMA);
            this.groupBox1.Controls.Add(this.ACIKLABEL);
            this.groupBox1.Controls.Add(this.BTNEKLE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞ EKLE";
            // 
            // MIKTARTEXT
            // 
            this.MIKTARTEXT.Location = new System.Drawing.Point(634, 27);
            this.MIKTARTEXT.Name = "MIKTARTEXT";
            this.MIKTARTEXT.Size = new System.Drawing.Size(80, 26);
            this.MIKTARTEXT.TabIndex = 4;
            this.MIKTARTEXT.Text = "0";
            this.MIKTARTEXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIYAT_KeyPress);
            // 
            // MIKTAR
            // 
            this.MIKTAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MIKTAR.FormattingEnabled = true;
            this.MIKTAR.Items.AddRange(new object[] {
            "KG",
            "ADET"});
            this.MIKTAR.Location = new System.Drawing.Point(550, 27);
            this.MIKTAR.Name = "MIKTAR";
            this.MIKTAR.Size = new System.Drawing.Size(73, 28);
            this.MIKTAR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = ":";
            // 
            // BTNBUL
            // 
            this.BTNBUL.BackColor = System.Drawing.Color.Orange;
            this.BTNBUL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNBUL.Location = new System.Drawing.Point(743, 80);
            this.BTNBUL.Name = "BTNBUL";
            this.BTNBUL.Size = new System.Drawing.Size(198, 43);
            this.BTNBUL.TabIndex = 9;
            this.BTNBUL.Text = "KAYDET ÇIK";
            this.BTNBUL.UseVisualStyleBackColor = false;
            this.BTNBUL.Click += new System.EventHandler(this.BTNBUL_Click);
            // 
            // URUN
            // 
            this.URUN.Location = new System.Drawing.Point(439, 59);
            this.URUN.Name = "URUN";
            this.URUN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.URUN.Properties.Appearance.Options.UseFont = true;
            this.URUN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.URUN.Size = new System.Drawing.Size(275, 26);
            this.URUN.TabIndex = 5;
            this.URUN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MUSTERI_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "ÜRÜN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(695, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "₺";
            // 
            // ODEME
            // 
            this.ODEME.Location = new System.Drawing.Point(609, 94);
            this.ODEME.Name = "ODEME";
            this.ODEME.Size = new System.Drawing.Size(80, 26);
            this.ODEME.TabIndex = 6;
            this.ODEME.Text = "0";
            this.ODEME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIYAT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ÜRÜN İÇİN ALINAN ÖDEME:";
            // 
            // MUSTERI
            // 
            this.MUSTERI.Location = new System.Drawing.Point(121, 30);
            this.MUSTERI.Name = "MUSTERI";
            this.MUSTERI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.MUSTERI.Properties.Appearance.Options.UseFont = true;
            this.MUSTERI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MUSTERI.Size = new System.Drawing.Size(232, 26);
            this.MUSTERI.TabIndex = 0;
            this.MUSTERI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MUSTERI_KeyPress);
            // 
            // BTNSIL
            // 
            this.BTNSIL.BackColor = System.Drawing.Color.DarkRed;
            this.BTNSIL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNSIL.Location = new System.Drawing.Point(844, 13);
            this.BTNSIL.Name = "BTNSIL";
            this.BTNSIL.Size = new System.Drawing.Size(97, 61);
            this.BTNSIL.TabIndex = 8;
            this.BTNSIL.Text = "SİL";
            this.BTNSIL.UseVisualStyleBackColor = false;
            this.BTNSIL.Click += new System.EventHandler(this.BTNSIL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "₺";
            // 
            // FIYAT
            // 
            this.FIYAT.Location = new System.Drawing.Point(439, 27);
            this.FIYAT.Name = "FIYAT";
            this.FIYAT.Size = new System.Drawing.Size(80, 26);
            this.FIYAT.TabIndex = 2;
            this.FIYAT.Text = "0";
            this.FIYAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIYAT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "FİYAT:";
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Location = new System.Drawing.Point(121, 62);
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.Size = new System.Drawing.Size(232, 61);
            this.ACIKLAMA.TabIndex = 1;
            this.ACIKLAMA.Text = "";
            // 
            // ACIKLABEL
            // 
            this.ACIKLABEL.AutoSize = true;
            this.ACIKLABEL.Location = new System.Drawing.Point(12, 65);
            this.ACIKLABEL.Name = "ACIKLABEL";
            this.ACIKLABEL.Size = new System.Drawing.Size(103, 20);
            this.ACIKLABEL.TabIndex = 4;
            this.ACIKLABEL.Text = "AÇIKLAMA:";
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.BackColor = System.Drawing.Color.DarkGreen;
            this.BTNEKLE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNEKLE.Location = new System.Drawing.Point(743, 13);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(97, 61);
            this.BTNEKLE.TabIndex = 7;
            this.BTNEKLE.Text = "EKLE";
            this.BTNEKLE.UseVisualStyleBackColor = false;
            this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MÜŞTERİ:";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton4.Location = new System.Drawing.Point(845, 16);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(105, 40);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "YAZICIYA GÖNDER";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton5.Location = new System.Drawing.Point(734, 16);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(105, 40);
            this.simpleButton5.TabIndex = 0;
            this.simpleButton5.Text = "EXCEL\'LE AKTAR";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // SiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SiparisDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Detayı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SiparisDetay_FormClosing);
            this.Load += new System.EventHandler(this.SiparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.URUN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSTERI.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MIKTARTEXT;
        private System.Windows.Forms.ComboBox MIKTAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNBUL;
        public DevExpress.XtraEditors.ComboBoxEdit URUN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ODEME;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.ComboBoxEdit MUSTERI;
        private System.Windows.Forms.Button BTNSIL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FIYAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ACIKLAMA;
        private System.Windows.Forms.Label ACIKLABEL;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}