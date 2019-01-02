namespace MainUIForm
{
    partial class CariDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariDuzenle));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.MAdi = new System.Windows.Forms.TextBox();
            this.Mid = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MutabikKal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TOdenen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MAdis = new System.Windows.Forms.Label();
            this.TAlacak = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(5, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "VAZGEÇ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.MAdi);
            this.groupBox1.Controls.Add(this.Mid);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.MutabikKal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TOdenen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MAdis);
            this.groupBox1.Controls.Add(this.TAlacak);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİ CARİ DÜZENLE";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(5, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 53);
            this.button3.TabIndex = 13;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MAdi
            // 
            this.MAdi.Location = new System.Drawing.Point(143, 32);
            this.MAdi.Name = "MAdi";
            this.MAdi.Size = new System.Drawing.Size(192, 26);
            this.MAdi.TabIndex = 12;
            this.MAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MAdi_KeyPress);
            // 
            // Mid
            // 
            this.Mid.AutoSize = true;
            this.Mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mid.Location = new System.Drawing.Point(308, -3);
            this.Mid.Name = "Mid";
            this.Mid.Size = new System.Drawing.Size(27, 24);
            this.Mid.TabIndex = 11;
            this.Mid.Text = "id";
            this.Mid.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox2.Location = new System.Drawing.Point(10, 128);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 24);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "BORÇ SİL";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "₺";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(170, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "KAYDET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MutabikKal
            // 
            this.MutabikKal.AutoSize = true;
            this.MutabikKal.ForeColor = System.Drawing.Color.DarkGreen;
            this.MutabikKal.Location = new System.Drawing.Point(170, 128);
            this.MutabikKal.Name = "MutabikKal";
            this.MutabikKal.Size = new System.Drawing.Size(144, 24);
            this.MutabikKal.TabIndex = 6;
            this.MutabikKal.Text = "MÜTABIK KAL";
            this.MutabikKal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOPLAM ÖDENEN:";
            // 
            // TOdenen
            // 
            this.TOdenen.Location = new System.Drawing.Point(170, 96);
            this.TOdenen.Name = "TOdenen";
            this.TOdenen.Size = new System.Drawing.Size(140, 26);
            this.TOdenen.TabIndex = 4;
            this.TOdenen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TAlacak_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOPLAM ALACAK:";
            // 
            // MAdis
            // 
            this.MAdis.AutoSize = true;
            this.MAdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MAdis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MAdis.Location = new System.Drawing.Point(6, 35);
            this.MAdis.Name = "MAdis";
            this.MAdis.Size = new System.Drawing.Size(130, 20);
            this.MAdis.TabIndex = 2;
            this.MAdis.Text = "MÜŞTERİ ADI:";
            // 
            // TAlacak
            // 
            this.TAlacak.Location = new System.Drawing.Point(170, 64);
            this.TAlacak.Name = "TAlacak";
            this.TAlacak.Size = new System.Drawing.Size(140, 26);
            this.TAlacak.TabIndex = 1;
            this.TAlacak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TAlacak_KeyPress);
            // 
            // CariDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 294);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 333);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 333);
            this.Name = "CariDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Düzenle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label MAdis;
        public System.Windows.Forms.TextBox TOdenen;
        public System.Windows.Forms.TextBox TAlacak;
        public System.Windows.Forms.CheckBox MutabikKal;
        public System.Windows.Forms.Label Mid;
        public System.Windows.Forms.TextBox MAdi;
        private System.Windows.Forms.Button button3;
    }
}