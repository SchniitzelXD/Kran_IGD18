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
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnRunter = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnHoch = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.timKran = new System.Windows.Forms.Timer(this.components);
            this.btnKoppeln = new System.Windows.Forms.Button();
            this.pBoxKiste = new System.Windows.Forms.PictureBox();
            this.pBoxKranHaken = new System.Windows.Forms.PictureBox();
            this.pBoxHaken = new System.Windows.Forms.PictureBox();
            this.pBoxKran = new System.Windows.Forms.PictureBox();
            this.btnAllesAufAnfang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKranHaken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHaken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKran)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLinks
            // 
            this.btnLinks.Location = new System.Drawing.Point(674, 114);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(76, 54);
            this.btnLinks.TabIndex = 3;
            this.btnLinks.Text = "Links";
            this.btnLinks.UseVisualStyleBackColor = true;
            this.btnLinks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLinks_MouseDown);
            this.btnLinks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLinks_MouseUp);
            // 
            // btnRunter
            // 
            this.btnRunter.Location = new System.Drawing.Point(756, 178);
            this.btnRunter.Name = "btnRunter";
            this.btnRunter.Size = new System.Drawing.Size(76, 54);
            this.btnRunter.TabIndex = 4;
            this.btnRunter.Text = "Runter";
            this.btnRunter.UseVisualStyleBackColor = true;
            this.btnRunter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRunter_MouseDown);
            this.btnRunter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRunter_MouseUp);
            // 
            // btnRechts
            // 
            this.btnRechts.Location = new System.Drawing.Point(838, 114);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(76, 54);
            this.btnRechts.TabIndex = 5;
            this.btnRechts.Text = "Rechts";
            this.btnRechts.UseVisualStyleBackColor = true;
            this.btnRechts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRechts_MouseDown);
            this.btnRechts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRechts_MouseUp);
            // 
            // btnHoch
            // 
            this.btnHoch.Location = new System.Drawing.Point(756, 53);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(76, 54);
            this.btnHoch.TabIndex = 6;
            this.btnHoch.Text = "Hoch";
            this.btnHoch.UseVisualStyleBackColor = true;
            this.btnHoch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHoch_MouseDown);
            this.btnHoch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHoch_MouseUp);
            // 
            // btnBeenden
            // 
            this.btnBeenden.BackColor = System.Drawing.Color.Red;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBeenden.Location = new System.Drawing.Point(727, 419);
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
            this.btnKoppeln.Location = new System.Drawing.Point(756, 308);
            this.btnKoppeln.Name = "btnKoppeln";
            this.btnKoppeln.Size = new System.Drawing.Size(76, 54);
            this.btnKoppeln.TabIndex = 10;
            this.btnKoppeln.Text = "Koppeln";
            this.btnKoppeln.UseVisualStyleBackColor = true;
            this.btnKoppeln.Click += new System.EventHandler(this.btn_greifen_Click);
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
            this.pBoxKranHaken.Image = global::KranAnwendung.Properties.Resources.Kran_Katze_real_shit_dude1;
            this.pBoxKranHaken.Location = new System.Drawing.Point(429, 178);
            this.pBoxKranHaken.Name = "pBoxKranHaken";
            this.pBoxKranHaken.Size = new System.Drawing.Size(85, 203);
            this.pBoxKranHaken.TabIndex = 1;
            this.pBoxKranHaken.TabStop = false;
            // 
            // pBoxHaken
            // 
            this.pBoxHaken.Image = global::KranAnwendung.Properties.Resources.Kranhaken_tha_goood_stuff;
            this.pBoxHaken.Location = new System.Drawing.Point(445, 370);
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
            // btnAllesAufAnfang
            // 
            this.btnAllesAufAnfang.Location = new System.Drawing.Point(727, 386);
            this.btnAllesAufAnfang.Name = "btnAllesAufAnfang";
            this.btnAllesAufAnfang.Size = new System.Drawing.Size(140, 27);
            this.btnAllesAufAnfang.TabIndex = 11;
            this.btnAllesAufAnfang.Text = "zurücksetzen";
            this.btnAllesAufAnfang.UseVisualStyleBackColor = true;
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
            // frm_Kran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 688);
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
            this.Name = "frm_Kran";
            this.Text = "Krananwendung";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKranHaken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHaken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKran)).EndInit();
            this.ResumeLayout(false);

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
    }
}

