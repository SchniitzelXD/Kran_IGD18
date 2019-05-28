namespace KranAnwendung
{
    partial class frm_Kran
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Kran));
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnRunter = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnHoch = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.timKran = new System.Windows.Forms.Timer(this.components);
            this.btnKoppeln = new System.Windows.Forms.Button();
            this.btnAllesAufAnfang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHilfe = new System.Windows.Forms.Button();
            this.pBoxKiste = new System.Windows.Forms.PictureBox();
            this.pBoxKranHaken = new System.Windows.Forms.PictureBox();
            this.pBoxHaken = new System.Windows.Forms.PictureBox();
            this.pBoxKran = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKranHaken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHaken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKran)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.Teal;
            this.btnLinks.Location = new System.Drawing.Point(676, 157);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(76, 54);
            this.btnLinks.TabIndex = 3;
            this.btnLinks.Text = "<----";
            this.btnLinks.UseVisualStyleBackColor = false;
            this.btnLinks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLinks_MouseDown);
            this.btnLinks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLinks_MouseUp);
            // 
            // btnRunter
            // 
            this.btnRunter.BackColor = System.Drawing.Color.Teal;
            this.btnRunter.Location = new System.Drawing.Point(758, 221);
            this.btnRunter.Name = "btnRunter";
            this.btnRunter.Size = new System.Drawing.Size(76, 54);
            this.btnRunter.TabIndex = 4;
            this.btnRunter.Text = "Runter";
            this.btnRunter.UseVisualStyleBackColor = false;
            this.btnRunter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRunter_MouseDown);
            this.btnRunter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRunter_MouseUp);
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.Teal;
            this.btnRechts.Location = new System.Drawing.Point(840, 157);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(76, 54);
            this.btnRechts.TabIndex = 5;
            this.btnRechts.Text = "---->";
            this.btnRechts.UseVisualStyleBackColor = false;
            this.btnRechts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRechts_MouseDown);
            this.btnRechts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRechts_MouseUp);
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.Teal;
            this.btnHoch.Location = new System.Drawing.Point(758, 96);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(76, 54);
            this.btnHoch.TabIndex = 6;
            this.btnHoch.Text = "Hoch";
            this.btnHoch.UseVisualStyleBackColor = false;
            this.btnHoch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHoch_MouseDown);
            this.btnHoch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHoch_MouseUp);
            // 
            // btnBeenden
            // 
            this.btnBeenden.BackColor = System.Drawing.Color.Red;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBeenden.Location = new System.Drawing.Point(729, 490);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(140, 132);
            this.btnBeenden.TabIndex = 8;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = false;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // timKran
            // 
            this.timKran.Interval = 40;
            this.timKran.Tick += new System.EventHandler(this.timKran_Tick);
            // 
            // btnKoppeln
            // 
            this.btnKoppeln.BackColor = System.Drawing.Color.Teal;
            this.btnKoppeln.Location = new System.Drawing.Point(758, 351);
            this.btnKoppeln.Name = "btnKoppeln";
            this.btnKoppeln.Size = new System.Drawing.Size(76, 54);
            this.btnKoppeln.TabIndex = 10;
            this.btnKoppeln.Text = "Koppeln";
            this.btnKoppeln.UseVisualStyleBackColor = false;
            this.btnKoppeln.Click += new System.EventHandler(this.btn_greifen_Click);
            // 
            // btnAllesAufAnfang
            // 
            this.btnAllesAufAnfang.BackColor = System.Drawing.Color.Teal;
            this.btnAllesAufAnfang.Location = new System.Drawing.Point(729, 429);
            this.btnAllesAufAnfang.Name = "btnAllesAufAnfang";
            this.btnAllesAufAnfang.Size = new System.Drawing.Size(140, 27);
            this.btnAllesAufAnfang.TabIndex = 11;
            this.btnAllesAufAnfang.Text = "Zurücksetzen";
            this.btnAllesAufAnfang.UseVisualStyleBackColor = false;
            this.btnAllesAufAnfang.Click += new System.EventHandler(this.btnAllesAufAnfang_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(1, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 152);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(78, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 40);
            this.panel2.TabIndex = 14;
            // 
            // btnHilfe
            // 
            this.btnHilfe.Location = new System.Drawing.Point(740, 26);
            this.btnHilfe.Name = "btnHilfe";
            this.btnHilfe.Size = new System.Drawing.Size(110, 24);
            this.btnHilfe.TabIndex = 15;
            this.btnHilfe.Text = "Hilfe";
            this.btnHilfe.UseVisualStyleBackColor = true;
            this.btnHilfe.Click += new System.EventHandler(this.btnHilfe_Click);
            // 
            // pBoxKiste
            // 
            this.pBoxKiste.Image = global::KranAnwendung.Properties.Resources.Kiste_Bier1;
            this.pBoxKiste.Location = new System.Drawing.Point(329, 490);
            this.pBoxKiste.Name = "pBoxKiste";
            this.pBoxKiste.Size = new System.Drawing.Size(97, 78);
            this.pBoxKiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxKiste.TabIndex = 2;
            this.pBoxKiste.TabStop = false;
            // 
            // pBoxKranHaken
            // 
            this.pBoxKranHaken.Image = global::KranAnwendung.Properties.Resources.Kran_Katze2;
            this.pBoxKranHaken.Location = new System.Drawing.Point(444, 179);
            this.pBoxKranHaken.Name = "pBoxKranHaken";
            this.pBoxKranHaken.Size = new System.Drawing.Size(53, 203);
            this.pBoxKranHaken.TabIndex = 1;
            this.pBoxKranHaken.TabStop = false;
            // 
            // pBoxHaken
            // 
            this.pBoxHaken.Image = global::KranAnwendung.Properties.Resources.Kranhaken_tha_goood_stuff;
            this.pBoxHaken.Location = new System.Drawing.Point(450, 370);
            this.pBoxHaken.Name = "pBoxHaken";
            this.pBoxHaken.Size = new System.Drawing.Size(46, 79);
            this.pBoxHaken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxHaken.TabIndex = 7;
            this.pBoxHaken.TabStop = false;
            // 
            // pBoxKran
            // 
            this.pBoxKran.BackColor = System.Drawing.Color.Transparent;
            this.pBoxKran.Image = global::KranAnwendung.Properties.Resources.Kran_Fertig1;
            this.pBoxKran.InitialImage = global::KranAnwendung.Properties.Resources.Kran_Fertig;
            this.pBoxKran.Location = new System.Drawing.Point(-43, 53);
            this.pBoxKran.Name = "pBoxKran";
            this.pBoxKran.Size = new System.Drawing.Size(711, 539);
            this.pBoxKran.TabIndex = 0;
            this.pBoxKran.TabStop = false;
            // 
            // frm_Kran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 688);
            this.Controls.Add(this.btnHilfe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAllesAufAnfang);
            this.Controls.Add(this.btnKoppeln);
            this.Controls.Add(this.pBoxKiste);
            this.Controls.Add(this.pBoxKranHaken);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.pBoxHaken);
            this.Controls.Add(this.btnHoch);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnRunter);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.pBoxKran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Kran";
            this.Text = "Krananwendung";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKranHaken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHaken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxKran;
        private System.Windows.Forms.PictureBox pBoxKranHaken;
        private System.Windows.Forms.PictureBox pBoxKiste;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnRunter;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Button btnHoch;
        private System.Windows.Forms.PictureBox pBoxHaken;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Timer timKran;
        private System.Windows.Forms.Button btnKoppeln;
        private System.Windows.Forms.Button btnAllesAufAnfang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHilfe;
    }
}

