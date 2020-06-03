namespace Bibioteka_Zieja_Błoniarz
{
    partial class Dodaj_wypozyczenie
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
            this.CZYTELNICY = new System.Windows.Forms.Label();
            this.BUT_WYPOZYCZ = new System.Windows.Forms.Button();
            this.IMIE = new System.Windows.Forms.Label();
            this.BUT_WY_CZYT = new System.Windows.Forms.Button();
            this.NAZWISKO = new System.Windows.Forms.Label();
            this.BUT_WY_KS = new System.Windows.Forms.Button();
            this.TYTUL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CZYTELNICY
            // 
            this.CZYTELNICY.AutoSize = true;
            this.CZYTELNICY.Font = new System.Drawing.Font("Unispace", 18.25F, System.Drawing.FontStyle.Bold);
            this.CZYTELNICY.Location = new System.Drawing.Point(79, 9);
            this.CZYTELNICY.Name = "CZYTELNICY";
            this.CZYTELNICY.Size = new System.Drawing.Size(253, 30);
            this.CZYTELNICY.TabIndex = 3;
            this.CZYTELNICY.Text = "Wypożycz książkę";
            // 
            // BUT_WYPOZYCZ
            // 
            this.BUT_WYPOZYCZ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WYPOZYCZ.Location = new System.Drawing.Point(12, 389);
            this.BUT_WYPOZYCZ.Name = "BUT_WYPOZYCZ";
            this.BUT_WYPOZYCZ.Size = new System.Drawing.Size(373, 59);
            this.BUT_WYPOZYCZ.TabIndex = 34;
            this.BUT_WYPOZYCZ.Text = "Wypożycz";
            this.BUT_WYPOZYCZ.UseVisualStyleBackColor = true;
            this.BUT_WYPOZYCZ.Click += new System.EventHandler(this.BUT_WYPOZYCZ_Click);
            // 
            // IMIE
            // 
            this.IMIE.AutoSize = true;
            this.IMIE.Font = new System.Drawing.Font("Unispace", 16.25F, System.Drawing.FontStyle.Bold);
            this.IMIE.Location = new System.Drawing.Point(12, 72);
            this.IMIE.Name = "IMIE";
            this.IMIE.Size = new System.Drawing.Size(64, 26);
            this.IMIE.TabIndex = 35;
            this.IMIE.Text = "Imie";
            // 
            // BUT_WY_CZYT
            // 
            this.BUT_WY_CZYT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WY_CZYT.Location = new System.Drawing.Point(84, 179);
            this.BUT_WY_CZYT.Name = "BUT_WY_CZYT";
            this.BUT_WY_CZYT.Size = new System.Drawing.Size(248, 39);
            this.BUT_WY_CZYT.TabIndex = 36;
            this.BUT_WY_CZYT.Text = "Wybierz";
            this.BUT_WY_CZYT.UseVisualStyleBackColor = true;
            this.BUT_WY_CZYT.Click += new System.EventHandler(this.BUT_WY_CZYT_Click);
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.AutoSize = true;
            this.NAZWISKO.Font = new System.Drawing.Font("Unispace", 16.25F, System.Drawing.FontStyle.Bold);
            this.NAZWISKO.Location = new System.Drawing.Point(12, 120);
            this.NAZWISKO.Name = "NAZWISKO";
            this.NAZWISKO.Size = new System.Drawing.Size(116, 26);
            this.NAZWISKO.TabIndex = 37;
            this.NAZWISKO.Text = "Nazwisko";
            // 
            // BUT_WY_KS
            // 
            this.BUT_WY_KS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WY_KS.Location = new System.Drawing.Point(84, 317);
            this.BUT_WY_KS.Name = "BUT_WY_KS";
            this.BUT_WY_KS.Size = new System.Drawing.Size(248, 39);
            this.BUT_WY_KS.TabIndex = 38;
            this.BUT_WY_KS.Text = "Wybierz";
            this.BUT_WY_KS.UseVisualStyleBackColor = true;
            this.BUT_WY_KS.Click += new System.EventHandler(this.BUT_WY_KS_Click);
            // 
            // TYTUL
            // 
            this.TYTUL.AutoSize = true;
            this.TYTUL.Font = new System.Drawing.Font("Unispace", 16.25F, System.Drawing.FontStyle.Bold);
            this.TYTUL.Location = new System.Drawing.Point(12, 262);
            this.TYTUL.Name = "TYTUL";
            this.TYTUL.Size = new System.Drawing.Size(77, 26);
            this.TYTUL.TabIndex = 39;
            this.TYTUL.Text = "Tytuł";
            // 
            // Dodaj_wypozyczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(397, 460);
            this.Controls.Add(this.TYTUL);
            this.Controls.Add(this.BUT_WY_KS);
            this.Controls.Add(this.NAZWISKO);
            this.Controls.Add(this.BUT_WY_CZYT);
            this.Controls.Add(this.IMIE);
            this.Controls.Add(this.BUT_WYPOZYCZ);
            this.Controls.Add(this.CZYTELNICY);
            this.Name = "Dodaj_wypozyczenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj_wypożyczenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CZYTELNICY;
        private System.Windows.Forms.Button BUT_WYPOZYCZ;
        private System.Windows.Forms.Label IMIE;
        private System.Windows.Forms.Button BUT_WY_CZYT;
        private System.Windows.Forms.Label NAZWISKO;
        private System.Windows.Forms.Button BUT_WY_KS;
        private System.Windows.Forms.Label TYTUL;
    }
}