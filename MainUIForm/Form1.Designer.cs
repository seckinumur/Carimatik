namespace MainUIForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.YILLIKODEME = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.YILLIKSATIS = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.YILLIKALACAK = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AYLIKALACAK = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AYLIKODEME = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AYLIKSATIS = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.progressPanel2 = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.URUN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSTERI.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(943, 314);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
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
            this.gridView1.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Preview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView1.AppearancePrint.Preview.Options.UseTextOptions = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 489);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gridControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SİPARİŞ HAZIRLA";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(3, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 130);
            this.groupBox1.TabIndex = 5;
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
            this.MIKTARTEXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.BTNBUL.Text = "SİPARİŞİ TAMAMLA";
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
            this.ODEME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.MUSTERI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEdit1_KeyPress);
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
            this.BTNSIL.Click += new System.EventHandler(this.button2_Click);
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
            this.FIYAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.BTNEKLE.Click += new System.EventHandler(this.button1_Click);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.simpleButton6);
            this.tabPage2.Controls.Add(this.simpleButton7);
            this.tabPage2.Controls.Add(this.gridControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CARİLER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton6.Location = new System.Drawing.Point(836, 6);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(105, 40);
            this.simpleButton6.TabIndex = 11;
            this.simpleButton6.Text = "YAZICIYA GÖNDER";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton7.Location = new System.Drawing.Point(725, 6);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(105, 40);
            this.simpleButton7.TabIndex = 10;
            this.simpleButton7.Text = "EXCEL\'LE AKTAR";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(943, 450);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.Empty.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.Preview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView2.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowRowSizing = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView2.OptionsFind.FindNullPrompt = "Arama Yapın...";
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsPrint.ExpandAllDetails = true;
            this.gridView2.OptionsPrint.PrintDetails = true;
            this.gridView2.OptionsPrint.PrintFilterInfo = true;
            this.gridView2.OptionsPrint.PrintPreview = true;
            this.gridView2.OptionsPrint.RtfPageFooter = resources.GetString("gridView2.OptionsPrint.RtfPageFooter");
            this.gridView2.OptionsPrint.RtfPageHeader = resources.GetString("gridView2.OptionsPrint.RtfPageHeader");
            this.gridView2.OptionsView.RowAutoHeight = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.simpleButton3);
            this.tabPage3.Controls.Add(this.simpleButton2);
            this.tabPage3.Controls.Add(this.progressPanel1);
            this.tabPage3.Controls.Add(this.gridControl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(949, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SİPARİŞ GEÇMİŞİ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton3.Location = new System.Drawing.Point(836, 6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(105, 40);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "YAZICIYA GÖNDER";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.Location = new System.Drawing.Point(725, 6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(105, 40);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "EXCEL\'LE AKTAR";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // progressPanel1
            // 
            this.progressPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Caption = "Lütfen Bekleyin";
            this.progressPanel1.Description = "Liste Hazırlanıyor...";
            this.progressPanel1.Location = new System.Drawing.Point(393, 149);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(167, 238);
            this.progressPanel1.TabIndex = 3;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(3, 3);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(943, 450);
            this.gridControl3.TabIndex = 2;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gridControl3.DoubleClick += new System.EventHandler(this.gridControl3_DoubleClick);
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView3.Appearance.Empty.Options.UseFont = true;
            this.gridView3.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView3.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView3.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView3.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridView3.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView3.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView3.AppearancePrint.Preview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView3.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView3.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsCustomization.AllowRowSizing = true;
            this.gridView3.OptionsFind.AlwaysVisible = true;
            this.gridView3.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView3.OptionsFind.FindNullPrompt = "Arama Yapın...";
            this.gridView3.OptionsFind.ShowFindButton = false;
            this.gridView3.OptionsPrint.ExpandAllDetails = true;
            this.gridView3.OptionsPrint.PrintDetails = true;
            this.gridView3.OptionsPrint.PrintFilterInfo = true;
            this.gridView3.OptionsPrint.PrintPreview = true;
            this.gridView3.OptionsPrint.RtfPageFooter = resources.GetString("gridView3.OptionsPrint.RtfPageFooter");
            this.gridView3.OptionsPrint.RtfPageHeader = resources.GetString("gridView3.OptionsPrint.RtfPageHeader");
            this.gridView3.OptionsView.RowAutoHeight = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.progressPanel2);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(949, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "AI ANALİZ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.YILLIKODEME);
            this.groupBox7.Location = new System.Drawing.Point(222, 167);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "YILLIK TAHSİLAT";
            // 
            // YILLIKODEME
            // 
            this.YILLIKODEME.AutoSize = true;
            this.YILLIKODEME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YILLIKODEME.Location = new System.Drawing.Point(33, 41);
            this.YILLIKODEME.Name = "YILLIKODEME";
            this.YILLIKODEME.Size = new System.Drawing.Size(126, 31);
            this.YILLIKODEME.TabIndex = 4;
            this.YILLIKODEME.Text = "450650₺";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.YILLIKSATIS);
            this.groupBox6.Location = new System.Drawing.Point(16, 167);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "YILLIK SATIŞ";
            // 
            // YILLIKSATIS
            // 
            this.YILLIKSATIS.AutoSize = true;
            this.YILLIKSATIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YILLIKSATIS.Location = new System.Drawing.Point(33, 41);
            this.YILLIKSATIS.Name = "YILLIKSATIS";
            this.YILLIKSATIS.Size = new System.Drawing.Size(126, 31);
            this.YILLIKSATIS.TabIndex = 4;
            this.YILLIKSATIS.Text = "450650₺";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.YILLIKALACAK);
            this.groupBox5.Location = new System.Drawing.Point(428, 167);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "YILLIK ALACAK";
            // 
            // YILLIKALACAK
            // 
            this.YILLIKALACAK.AutoSize = true;
            this.YILLIKALACAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YILLIKALACAK.Location = new System.Drawing.Point(33, 41);
            this.YILLIKALACAK.Name = "YILLIKALACAK";
            this.YILLIKALACAK.Size = new System.Drawing.Size(126, 31);
            this.YILLIKALACAK.TabIndex = 4;
            this.YILLIKALACAK.Text = "450650₺";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AYLIKALACAK);
            this.groupBox4.Location = new System.Drawing.Point(428, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AYLIK ALACAK";
            // 
            // AYLIKALACAK
            // 
            this.AYLIKALACAK.AutoSize = true;
            this.AYLIKALACAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AYLIKALACAK.Location = new System.Drawing.Point(33, 41);
            this.AYLIKALACAK.Name = "AYLIKALACAK";
            this.AYLIKALACAK.Size = new System.Drawing.Size(126, 31);
            this.AYLIKALACAK.TabIndex = 4;
            this.AYLIKALACAK.Text = "450650₺";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AYLIKODEME);
            this.groupBox3.Location = new System.Drawing.Point(222, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AYLIK TAHSİLAT";
            // 
            // AYLIKODEME
            // 
            this.AYLIKODEME.AutoSize = true;
            this.AYLIKODEME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AYLIKODEME.Location = new System.Drawing.Point(33, 41);
            this.AYLIKODEME.Name = "AYLIKODEME";
            this.AYLIKODEME.Size = new System.Drawing.Size(126, 31);
            this.AYLIKODEME.TabIndex = 4;
            this.AYLIKODEME.Text = "450650₺";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AYLIKSATIS);
            this.groupBox2.Location = new System.Drawing.Point(16, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AYLIK SATIŞ";
            // 
            // AYLIKSATIS
            // 
            this.AYLIKSATIS.AutoSize = true;
            this.AYLIKSATIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AYLIKSATIS.Location = new System.Drawing.Point(33, 41);
            this.AYLIKSATIS.Name = "AYLIKSATIS";
            this.AYLIKSATIS.Size = new System.Drawing.Size(126, 31);
            this.AYLIKSATIS.TabIndex = 4;
            this.AYLIKSATIS.Text = "450650₺";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "VERİLER GELİŞMİŞ YAPAY ZEKA İLE İŞLENMEKTEDİR.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(581, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "BURASI YAPIM AŞAMASINDADIR. TEMEL VERİLER GÖSTERİLİYOR";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox8);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(949, 456);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "AYARLAR";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.gridControl4);
            this.groupBox8.Location = new System.Drawing.Point(8, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(314, 444);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ÜRÜN LİSTESİ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "ÜRÜN EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gridControl4
            // 
            this.gridControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl4.Location = new System.Drawing.Point(3, 22);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(305, 378);
            this.gridControl4.TabIndex = 3;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gridControl4.DoubleClick += new System.EventHandler(this.gridControl4_DoubleClick);
            // 
            // gridView4
            // 
            this.gridView4.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView4.Appearance.Empty.Options.UseFont = true;
            this.gridView4.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView4.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView4.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView4.Appearance.Row.Options.UseFont = true;
            this.gridView4.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView4.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView4.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridView4.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView4.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView4.AppearancePrint.Preview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView4.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView4.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsCustomization.AllowRowSizing = true;
            this.gridView4.OptionsFind.AllowFindPanel = false;
            this.gridView4.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView4.OptionsFind.FindNullPrompt = "Arama Yapın...";
            this.gridView4.OptionsFind.ShowClearButton = false;
            this.gridView4.OptionsFind.ShowCloseButton = false;
            this.gridView4.OptionsFind.ShowFindButton = false;
            this.gridView4.OptionsPrint.ExpandAllDetails = true;
            this.gridView4.OptionsPrint.PrintDetails = true;
            this.gridView4.OptionsPrint.PrintFilterInfo = true;
            this.gridView4.OptionsPrint.PrintPreview = true;
            this.gridView4.OptionsPrint.RtfPageFooter = resources.GetString("gridView4.OptionsPrint.RtfPageFooter");
            this.gridView4.OptionsPrint.RtfPageHeader = resources.GetString("gridView4.OptionsPrint.RtfPageHeader");
            this.gridView4.OptionsView.RowAutoHeight = true;
            // 
            // progressPanel2
            // 
            this.progressPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressPanel2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel2.Appearance.Options.UseBackColor = true;
            this.progressPanel2.BarAnimationElementThickness = 2;
            this.progressPanel2.Caption = "Lütfen Bekleyin";
            this.progressPanel2.Description = "Liste Hazırlanıyor...";
            this.progressPanel2.Location = new System.Drawing.Point(420, 352);
            this.progressPanel2.Name = "progressPanel2";
            this.progressPanel2.Size = new System.Drawing.Size(167, 61);
            this.progressPanel2.TabIndex = 8;
            this.progressPanel2.Text = "progressPanel2";
            this.progressPanel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 489);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(973, 528);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carimatik V.0.6 BETA seçkinumur İnce Memed Edition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.URUN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSTERI.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        public DevExpress.XtraGrid.GridControl gridControl2;
        public DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label YILLIKODEME;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label YILLIKSATIS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label YILLIKALACAK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label AYLIKALACAK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label AYLIKODEME;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AYLIKSATIS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public DevExpress.XtraEditors.ComboBoxEdit URUN;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.Button BTNBUL;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button1;
        public DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.TextBox MIKTARTEXT;
        private System.Windows.Forms.ComboBox MIKTAR;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel2;
    }
}

