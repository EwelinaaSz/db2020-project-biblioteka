namespace Bibioteka_Zieja_Błoniarz
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu_Powitanie = new System.Windows.Forms.Label();
            this.Menu_Czytelnicy = new System.Windows.Forms.Label();
            this.Menu_Ksiazki = new System.Windows.Forms.Label();
            this.Menu_Wypozyczenia = new System.Windows.Forms.Label();
            this.Cz_Dodaj = new System.Windows.Forms.Button();
            this.Ks_Dodaj = new System.Windows.Forms.Button();
            this.Wy_Dodaj = new System.Windows.Forms.Button();
            this.Cz_Wyszukaj = new System.Windows.Forms.Button();
            this.Ks_Wyszukaj = new System.Windows.Forms.Button();
            this.Wy_Wyszukaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu_Powitanie
            // 
            this.Menu_Powitanie.AutoSize = true;
            this.Menu_Powitanie.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.Menu_Powitanie.Location = new System.Drawing.Point(10, 20);
            this.Menu_Powitanie.Name = "Menu_Powitanie";
            this.Menu_Powitanie.Size = new System.Drawing.Size(808, 58);
            this.Menu_Powitanie.TabIndex = 1;
            this.Menu_Powitanie.Text = "Witamy w aplikacji do obsługi bazy danych biblioteki.\r\n Prosimy o wybranie polece" +
    "nia.";
            this.Menu_Powitanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_Czytelnicy
            // 
            this.Menu_Czytelnicy.AutoSize = true;
            this.Menu_Czytelnicy.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.Menu_Czytelnicy.Location = new System.Drawing.Point(10, 143);
            this.Menu_Czytelnicy.Name = "Menu_Czytelnicy";
            this.Menu_Czytelnicy.Size = new System.Drawing.Size(163, 29);
            this.Menu_Czytelnicy.TabIndex = 2;
            this.Menu_Czytelnicy.Text = "Czytelnicy";
            this.Menu_Czytelnicy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_Ksiazki
            // 
            this.Menu_Ksiazki.AutoSize = true;
            this.Menu_Ksiazki.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.Menu_Ksiazki.Location = new System.Drawing.Point(347, 143);
            this.Menu_Ksiazki.Name = "Menu_Ksiazki";
            this.Menu_Ksiazki.Size = new System.Drawing.Size(118, 29);
            this.Menu_Ksiazki.TabIndex = 3;
            this.Menu_Ksiazki.Text = "Książki";
            this.Menu_Ksiazki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_Wypozyczenia
            // 
            this.Menu_Wypozyczenia.AutoSize = true;
            this.Menu_Wypozyczenia.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.Menu_Wypozyczenia.Location = new System.Drawing.Point(625, 143);
            this.Menu_Wypozyczenia.Name = "Menu_Wypozyczenia";
            this.Menu_Wypozyczenia.Size = new System.Drawing.Size(193, 29);
            this.Menu_Wypozyczenia.TabIndex = 4;
            this.Menu_Wypozyczenia.Text = "Wypożyczenia";
            this.Menu_Wypozyczenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cz_Dodaj
            // 
            this.Cz_Dodaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cz_Dodaj.Location = new System.Drawing.Point(15, 202);
            this.Cz_Dodaj.Name = "Cz_Dodaj";
            this.Cz_Dodaj.Size = new System.Drawing.Size(158, 52);
            this.Cz_Dodaj.TabIndex = 5;
            this.Cz_Dodaj.Text = "Nowa rejestracja";
            this.Cz_Dodaj.UseVisualStyleBackColor = true;
            this.Cz_Dodaj.Click += new System.EventHandler(this.Cz_Dodaj_Click);
            // 
            // Ks_Dodaj
            // 
            this.Ks_Dodaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ks_Dodaj.Location = new System.Drawing.Point(325, 202);
            this.Ks_Dodaj.Name = "Ks_Dodaj";
            this.Ks_Dodaj.Size = new System.Drawing.Size(158, 52);
            this.Ks_Dodaj.TabIndex = 6;
            this.Ks_Dodaj.Text = "Dodaj do biblioteki";
            this.Ks_Dodaj.UseVisualStyleBackColor = true;
            this.Ks_Dodaj.Click += new System.EventHandler(this.Ks_Dodaj_Click);
            // 
            // Wy_Dodaj
            // 
            this.Wy_Dodaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wy_Dodaj.Location = new System.Drawing.Point(641, 202);
            this.Wy_Dodaj.Name = "Wy_Dodaj";
            this.Wy_Dodaj.Size = new System.Drawing.Size(158, 52);
            this.Wy_Dodaj.TabIndex = 7;
            this.Wy_Dodaj.Text = "Nowe wypożyczenie";
            this.Wy_Dodaj.UseVisualStyleBackColor = true;
            this.Wy_Dodaj.Click += new System.EventHandler(this.Wy_Dodaj_Click);
            // 
            // Cz_Wyszukaj
            // 
            this.Cz_Wyszukaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cz_Wyszukaj.Location = new System.Drawing.Point(15, 260);
            this.Cz_Wyszukaj.Name = "Cz_Wyszukaj";
            this.Cz_Wyszukaj.Size = new System.Drawing.Size(158, 52);
            this.Cz_Wyszukaj.TabIndex = 8;
            this.Cz_Wyszukaj.Text = "Dane czytelników";
            this.Cz_Wyszukaj.UseVisualStyleBackColor = true;
            this.Cz_Wyszukaj.Click += new System.EventHandler(this.Cz_Wyszukaj_Click);
            // 
            // Ks_Wyszukaj
            // 
            this.Ks_Wyszukaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ks_Wyszukaj.Location = new System.Drawing.Point(325, 260);
            this.Ks_Wyszukaj.Name = "Ks_Wyszukaj";
            this.Ks_Wyszukaj.Size = new System.Drawing.Size(158, 52);
            this.Ks_Wyszukaj.TabIndex = 10;
            this.Ks_Wyszukaj.Text = "Przeszukaj bibliotekę";
            this.Ks_Wyszukaj.UseVisualStyleBackColor = true;
            this.Ks_Wyszukaj.Click += new System.EventHandler(this.Ks_Wyszukaj_Click);
            // 
            // Wy_Wyszukaj
            // 
            this.Wy_Wyszukaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wy_Wyszukaj.Location = new System.Drawing.Point(641, 260);
            this.Wy_Wyszukaj.Name = "Wy_Wyszukaj";
            this.Wy_Wyszukaj.Size = new System.Drawing.Size(158, 52);
            this.Wy_Wyszukaj.TabIndex = 12;
            this.Wy_Wyszukaj.Text = "Przeglądaj wypożyczenia";
            this.Wy_Wyszukaj.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(830, 344);
            this.Controls.Add(this.Wy_Wyszukaj);
            this.Controls.Add(this.Ks_Wyszukaj);
            this.Controls.Add(this.Cz_Wyszukaj);
            this.Controls.Add(this.Wy_Dodaj);
            this.Controls.Add(this.Ks_Dodaj);
            this.Controls.Add(this.Cz_Dodaj);
            this.Controls.Add(this.Menu_Wypozyczenia);
            this.Controls.Add(this.Menu_Ksiazki);
            this.Controls.Add(this.Menu_Czytelnicy);
            this.Controls.Add(this.Menu_Powitanie);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Menu_Powitanie;
        private System.Windows.Forms.Label Menu_Czytelnicy;
        private System.Windows.Forms.Label Menu_Ksiazki;
        private System.Windows.Forms.Label Menu_Wypozyczenia;
        private System.Windows.Forms.Button Cz_Dodaj;
        private System.Windows.Forms.Button Ks_Dodaj;
        private System.Windows.Forms.Button Wy_Dodaj;
        private System.Windows.Forms.Button Cz_Wyszukaj;
        private System.Windows.Forms.Button Ks_Wyszukaj;
        private System.Windows.Forms.Button Wy_Wyszukaj;
    }
}

