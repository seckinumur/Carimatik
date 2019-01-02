namespace MainUIForm
{
    partial class UrunEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KYADET = new System.Windows.Forms.Button();
            this.Urunaditxt = new System.Windows.Forms.TextBox();
            this.SIL = new System.Windows.Forms.Button();
            this.Urunid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Urunid);
            this.groupBox1.Controls.Add(this.SIL);
            this.groupBox1.Controls.Add(this.Urunaditxt);
            this.groupBox1.Controls.Add(this.KYADET);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN EKLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN ADI:";
            // 
            // KYADET
            // 
            this.KYADET.BackColor = System.Drawing.Color.DarkGreen;
            this.KYADET.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KYADET.Location = new System.Drawing.Point(6, 112);
            this.KYADET.Name = "KYADET";
            this.KYADET.Size = new System.Drawing.Size(277, 43);
            this.KYADET.TabIndex = 1;
            this.KYADET.Text = "KAYDET";
            this.KYADET.UseVisualStyleBackColor = false;
            this.KYADET.Click += new System.EventHandler(this.button1_Click);
            // 
            // Urunaditxt
            // 
            this.Urunaditxt.Location = new System.Drawing.Point(6, 71);
            this.Urunaditxt.Name = "Urunaditxt";
            this.Urunaditxt.Size = new System.Drawing.Size(277, 35);
            this.Urunaditxt.TabIndex = 2;
            this.Urunaditxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Urunaditxt_KeyPress);
            // 
            // SIL
            // 
            this.SIL.BackColor = System.Drawing.Color.DarkRed;
            this.SIL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SIL.Location = new System.Drawing.Point(6, 161);
            this.SIL.Name = "SIL";
            this.SIL.Size = new System.Drawing.Size(277, 43);
            this.SIL.TabIndex = 3;
            this.SIL.Text = "SİL";
            this.SIL.UseVisualStyleBackColor = false;
            this.SIL.Click += new System.EventHandler(this.SIL_Click);
            // 
            // Urunid
            // 
            this.Urunid.AutoSize = true;
            this.Urunid.Location = new System.Drawing.Point(248, 18);
            this.Urunid.Name = "Urunid";
            this.Urunid.Size = new System.Drawing.Size(35, 29);
            this.Urunid.TabIndex = 4;
            this.Urunid.Text = "id";
            this.Urunid.Visible = false;
            // 
            // UrunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 232);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(329, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 271);
            this.Name = "UrunEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunEkleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UrunEkleForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Urunaditxt;
        public System.Windows.Forms.Label Urunid;
        public System.Windows.Forms.Button SIL;
        public System.Windows.Forms.Button KYADET;
    }
}