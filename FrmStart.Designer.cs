namespace Hangman
{
    partial class FrmStart
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
            this.lblWord = new System.Windows.Forms.Label();
            this.tBCharacter = new System.Windows.Forms.TextBox();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdGuess = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.pb_statusbalken = new System.Windows.Forms.PictureBox();
            this.pb_senkrechtb = new System.Windows.Forms.PictureBox();
            this.pb_hügel = new System.Windows.Forms.Panel();
            this.pb_statusbalken6 = new System.Windows.Forms.PictureBox();
            this.pb_statusbalken5 = new System.Windows.Forms.PictureBox();
            this.pb_statusbalken4 = new System.Windows.Forms.PictureBox();
            this.pb_waagerechtb = new System.Windows.Forms.PictureBox();
            this.pb_seil = new System.Windows.Forms.Panel();
            this.pb_statusbalken2 = new System.Windows.Forms.PictureBox();
            this.pb_statusbalken3 = new System.Windows.Forms.PictureBox();
            this.pb_statusbalken7 = new System.Windows.Forms.PictureBox();
            this.pb_statusbalken9 = new System.Windows.Forms.PictureBox();
            this.pb_statusbalken8 = new System.Windows.Forms.PictureBox();
            this.pb_statusbalken10 = new System.Windows.Forms.PictureBox();
            this.pb_lukas1 = new System.Windows.Forms.PictureBox();
            this.pb_lukas2 = new System.Windows.Forms.PictureBox();
            this.pb_lukas6 = new System.Windows.Forms.PictureBox();
            this.pb_lukas3 = new System.Windows.Forms.PictureBox();
            this.pb_lucas4 = new System.Windows.Forms.PictureBox();
            this.pb_lukas5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_senkrechtb)).BeginInit();
            this.pb_hügel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_waagerechtb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lucas4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.White;
            this.lblWord.Location = new System.Drawing.Point(455, 143);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(60, 33);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "[...]";
            // 
            // tBCharacter
            // 
            this.tBCharacter.Location = new System.Drawing.Point(719, 382);
            this.tBCharacter.Name = "tBCharacter";
            this.tBCharacter.Size = new System.Drawing.Size(57, 20);
            this.tBCharacter.TabIndex = 1;
            this.tBCharacter.TextChanged += new System.EventHandler(this.tBCharacter_TextChanged);
            // 
            // cmdLoad
            // 
            this.cmdLoad.BackgroundImage = global::Hangman.Properties.Resources.Blau_Button;
            this.cmdLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdLoad.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdLoad.Location = new System.Drawing.Point(660, 425);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(83, 30);
            this.cmdLoad.TabIndex = 2;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdGuess
            // 
            this.cmdGuess.BackColor = System.Drawing.Color.Transparent;
            this.cmdGuess.BackgroundImage = global::Hangman.Properties.Resources.Orange_Button;
            this.cmdGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGuess.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuess.Location = new System.Drawing.Point(660, 461);
            this.cmdGuess.Name = "cmdGuess";
            this.cmdGuess.Size = new System.Drawing.Size(180, 46);
            this.cmdGuess.TabIndex = 3;
            this.cmdGuess.Text = "Guess";
            this.cmdGuess.UseVisualStyleBackColor = false;
            this.cmdGuess.Click += new System.EventHandler(this.cmdGuess_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.BackColor = System.Drawing.Color.Transparent;
            this.cmdReset.BackgroundImage = global::Hangman.Properties.Resources.Blau_Button;
            this.cmdReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdReset.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdReset.Location = new System.Drawing.Point(749, 425);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(91, 30);
            this.cmdReset.TabIndex = 4;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = false;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // pb_statusbalken
            // 
            this.pb_statusbalken.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken.Location = new System.Drawing.Point(94, 504);
            this.pb_statusbalken.Name = "pb_statusbalken";
            this.pb_statusbalken.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken.TabIndex = 5;
            this.pb_statusbalken.TabStop = false;
            // 
            // pb_senkrechtb
            // 
            this.pb_senkrechtb.BackColor = System.Drawing.Color.Transparent;
            this.pb_senkrechtb.BackgroundImage = global::Hangman.Properties.Resources.Stab_senkrecht;
            this.pb_senkrechtb.Location = new System.Drawing.Point(395, 143);
            this.pb_senkrechtb.Name = "pb_senkrechtb";
            this.pb_senkrechtb.Size = new System.Drawing.Size(42, 234);
            this.pb_senkrechtb.TabIndex = 7;
            this.pb_senkrechtb.TabStop = false;
            // 
            // pb_hügel
            // 
            this.pb_hügel.BackColor = System.Drawing.Color.Transparent;
            this.pb_hügel.BackgroundImage = global::Hangman.Properties.Resources.Hügel;
            this.pb_hügel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_hügel.Controls.Add(this.pb_statusbalken6);
            this.pb_hügel.Controls.Add(this.pb_statusbalken5);
            this.pb_hügel.Controls.Add(this.pb_statusbalken4);
            this.pb_hügel.Location = new System.Drawing.Point(269, 320);
            this.pb_hügel.Name = "pb_hügel";
            this.pb_hügel.Size = new System.Drawing.Size(299, 250);
            this.pb_hügel.TabIndex = 8;
            // 
            // pb_statusbalken6
            // 
            this.pb_statusbalken6.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken6.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken6.Location = new System.Drawing.Point(192, 184);
            this.pb_statusbalken6.Name = "pb_statusbalken6";
            this.pb_statusbalken6.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken6.TabIndex = 16;
            this.pb_statusbalken6.TabStop = false;
            // 
            // pb_statusbalken5
            // 
            this.pb_statusbalken5.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken5.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken5.Location = new System.Drawing.Point(115, 184);
            this.pb_statusbalken5.Name = "pb_statusbalken5";
            this.pb_statusbalken5.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken5.TabIndex = 16;
            this.pb_statusbalken5.TabStop = false;
            // 
            // pb_statusbalken4
            // 
            this.pb_statusbalken4.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken4.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken4.Location = new System.Drawing.Point(42, 184);
            this.pb_statusbalken4.Name = "pb_statusbalken4";
            this.pb_statusbalken4.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken4.TabIndex = 15;
            this.pb_statusbalken4.TabStop = false;
            // 
            // pb_waagerechtb
            // 
            this.pb_waagerechtb.BackColor = System.Drawing.Color.Transparent;
            this.pb_waagerechtb.BackgroundImage = global::Hangman.Properties.Resources.Stab_waagerecht;
            this.pb_waagerechtb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_waagerechtb.Location = new System.Drawing.Point(94, 143);
            this.pb_waagerechtb.Name = "pb_waagerechtb";
            this.pb_waagerechtb.Size = new System.Drawing.Size(325, 30);
            this.pb_waagerechtb.TabIndex = 9;
            this.pb_waagerechtb.TabStop = false;
            // 
            // pb_seil
            // 
            this.pb_seil.BackColor = System.Drawing.Color.Transparent;
            this.pb_seil.BackgroundImage = global::Hangman.Properties.Resources.Seil;
            this.pb_seil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_seil.Location = new System.Drawing.Point(94, 166);
            this.pb_seil.Name = "pb_seil";
            this.pb_seil.Size = new System.Drawing.Size(43, 61);
            this.pb_seil.TabIndex = 12;
            // 
            // pb_statusbalken2
            // 
            this.pb_statusbalken2.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken2.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken2.Location = new System.Drawing.Point(168, 504);
            this.pb_statusbalken2.Name = "pb_statusbalken2";
            this.pb_statusbalken2.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken2.TabIndex = 13;
            this.pb_statusbalken2.TabStop = false;
            // 
            // pb_statusbalken3
            // 
            this.pb_statusbalken3.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken3.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken3.Location = new System.Drawing.Point(235, 504);
            this.pb_statusbalken3.Name = "pb_statusbalken3";
            this.pb_statusbalken3.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken3.TabIndex = 14;
            this.pb_statusbalken3.TabStop = false;
            // 
            // pb_statusbalken7
            // 
            this.pb_statusbalken7.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken7.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken7.Location = new System.Drawing.Point(537, 504);
            this.pb_statusbalken7.Name = "pb_statusbalken7";
            this.pb_statusbalken7.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken7.TabIndex = 16;
            this.pb_statusbalken7.TabStop = false;
            // 
            // pb_statusbalken9
            // 
            this.pb_statusbalken9.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken9.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken9.Location = new System.Drawing.Point(684, 504);
            this.pb_statusbalken9.Name = "pb_statusbalken9";
            this.pb_statusbalken9.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken9.TabIndex = 17;
            this.pb_statusbalken9.TabStop = false;
            // 
            // pb_statusbalken8
            // 
            this.pb_statusbalken8.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken8.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken8.Location = new System.Drawing.Point(609, 504);
            this.pb_statusbalken8.Name = "pb_statusbalken8";
            this.pb_statusbalken8.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken8.TabIndex = 18;
            this.pb_statusbalken8.TabStop = false;
            // 
            // pb_statusbalken10
            // 
            this.pb_statusbalken10.BackColor = System.Drawing.Color.Transparent;
            this.pb_statusbalken10.BackgroundImage = global::Hangman.Properties.Resources.Statusbalken;
            this.pb_statusbalken10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_statusbalken10.Location = new System.Drawing.Point(761, 504);
            this.pb_statusbalken10.Name = "pb_statusbalken10";
            this.pb_statusbalken10.Size = new System.Drawing.Size(82, 31);
            this.pb_statusbalken10.TabIndex = 19;
            this.pb_statusbalken10.TabStop = false;
            // 
            // pb_lukas1
            // 
            this.pb_lukas1.BackColor = System.Drawing.Color.Transparent;
            this.pb_lukas1.BackgroundImage = global::Hangman.Properties.Resources.Lukas_1;
            this.pb_lukas1.Location = new System.Drawing.Point(52, 179);
            this.pb_lukas1.Name = "pb_lukas1";
            this.pb_lukas1.Size = new System.Drawing.Size(124, 230);
            this.pb_lukas1.TabIndex = 20;
            this.pb_lukas1.TabStop = false;
            // 
            // pb_lukas2
            // 
            this.pb_lukas2.BackColor = System.Drawing.Color.Transparent;
            this.pb_lukas2.BackgroundImage = global::Hangman.Properties.Resources.Lukas_21;
            this.pb_lukas2.Location = new System.Drawing.Point(52, 181);
            this.pb_lukas2.Name = "pb_lukas2";
            this.pb_lukas2.Size = new System.Drawing.Size(177, 228);
            this.pb_lukas2.TabIndex = 21;
            this.pb_lukas2.TabStop = false;
            // 
            // pb_lukas6
            // 
            this.pb_lukas6.BackColor = System.Drawing.Color.Transparent;
            this.pb_lukas6.BackgroundImage = global::Hangman.Properties.Resources.Lukas_61;
            this.pb_lukas6.Location = new System.Drawing.Point(12, 181);
            this.pb_lukas6.Name = "pb_lukas6";
            this.pb_lukas6.Size = new System.Drawing.Size(222, 326);
            this.pb_lukas6.TabIndex = 22;
            this.pb_lukas6.TabStop = false;
            // 
            // pb_lukas3
            // 
            this.pb_lukas3.BackColor = System.Drawing.Color.Transparent;
            this.pb_lukas3.BackgroundImage = global::Hangman.Properties.Resources.Lukas_31;
            this.pb_lukas3.Location = new System.Drawing.Point(12, 181);
            this.pb_lukas3.Name = "pb_lukas3";
            this.pb_lukas3.Size = new System.Drawing.Size(217, 228);
            this.pb_lukas3.TabIndex = 23;
            this.pb_lukas3.TabStop = false;
            // 
            // pb_lucas4
            // 
            this.pb_lucas4.BackColor = System.Drawing.Color.Transparent;
            this.pb_lucas4.BackgroundImage = global::Hangman.Properties.Resources.Lukas_41;
            this.pb_lucas4.Location = new System.Drawing.Point(12, 181);
            this.pb_lucas4.Name = "pb_lucas4";
            this.pb_lucas4.Size = new System.Drawing.Size(217, 326);
            this.pb_lucas4.TabIndex = 24;
            this.pb_lucas4.TabStop = false;
            // 
            // pb_lukas5
            // 
            this.pb_lukas5.BackColor = System.Drawing.Color.Transparent;
            this.pb_lukas5.BackgroundImage = global::Hangman.Properties.Resources.Lukas_51;
            this.pb_lukas5.Location = new System.Drawing.Point(12, 181);
            this.pb_lukas5.Name = "pb_lukas5";
            this.pb_lukas5.Size = new System.Drawing.Size(217, 326);
            this.pb_lukas5.TabIndex = 25;
            this.pb_lukas5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Hangman.Properties.Resources.Blau_micro___wie_lukas_schaüq;
            this.pictureBox1.Location = new System.Drawing.Point(706, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 66);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.Hintergrund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(939, 529);
            this.Controls.Add(this.pb_lukas6);
            this.Controls.Add(this.pb_lukas5);
            this.Controls.Add(this.pb_lucas4);
            this.Controls.Add(this.pb_lukas3);
            this.Controls.Add(this.pb_statusbalken10);
            this.Controls.Add(this.pb_statusbalken8);
            this.Controls.Add(this.pb_statusbalken9);
            this.Controls.Add(this.pb_statusbalken7);
            this.Controls.Add(this.pb_statusbalken3);
            this.Controls.Add(this.pb_statusbalken2);
            this.Controls.Add(this.pb_senkrechtb);
            this.Controls.Add(this.pb_statusbalken);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdGuess);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.tBCharacter);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.pb_hügel);
            this.Controls.Add(this.pb_lukas2);
            this.Controls.Add(this.pb_waagerechtb);
            this.Controls.Add(this.pb_lukas1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_seil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmStart";
            this.Text = "Häng den Lukas";
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_senkrechtb)).EndInit();
            this.pb_hügel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_waagerechtb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statusbalken10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lucas4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lukas5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox tBCharacter;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdGuess;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.PictureBox pb_statusbalken;
        private System.Windows.Forms.PictureBox pb_senkrechtb;
        private System.Windows.Forms.Panel pb_hügel;
        private System.Windows.Forms.PictureBox pb_waagerechtb;
        private System.Windows.Forms.Panel pb_seil;
        private System.Windows.Forms.PictureBox pb_statusbalken2;
        private System.Windows.Forms.PictureBox pb_statusbalken6;
        private System.Windows.Forms.PictureBox pb_statusbalken5;
        private System.Windows.Forms.PictureBox pb_statusbalken4;
        private System.Windows.Forms.PictureBox pb_statusbalken3;
        private System.Windows.Forms.PictureBox pb_statusbalken7;
        private System.Windows.Forms.PictureBox pb_statusbalken9;
        private System.Windows.Forms.PictureBox pb_statusbalken8;
        private System.Windows.Forms.PictureBox pb_statusbalken10;
        private System.Windows.Forms.PictureBox pb_lukas1;
        private System.Windows.Forms.PictureBox pb_lukas2;
        private System.Windows.Forms.PictureBox pb_lukas6;
        private System.Windows.Forms.PictureBox pb_lukas3;
        private System.Windows.Forms.PictureBox pb_lucas4;
        private System.Windows.Forms.PictureBox pb_lukas5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

