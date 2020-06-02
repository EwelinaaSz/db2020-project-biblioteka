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
            this.Cz_Wyszukaj = new System.Windows.Forms.Button();
            this.Ks_Wyszukaj = new System.Windows.Forms.Button();
            this.Wy_Wyszukaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu_Powitanie
            // 
            this.Menu_Powitanie.AutoSize = true;
            this.Menu_Powitanie.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.Menu_Powitanie.Location = new System.Drawing.Point(12, 9);
            this.Menu_Powitanie.Name = "Menu_Powitanie";
            this.Menu_Powitanie.Size = new System.Drawing.Size(463, 116);
            this.Menu_Powitanie.TabIndex = 1;
            this.Menu_Powitanie.Text = "Witamy w aplikacji do obsługi \r\nbazy danych biblioteki.\r\n\r\nProsimy o wybranie pol" +
    "ecenia.";
            this.Menu_Powitanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cz_Wyszukaj
            // 
            this.Cz_Wyszukaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cz_Wyszukaj.Location = new System.Drawing.Point(15, 169);
            this.Cz_Wyszukaj.Name = "Cz_Wyszukaj";
            this.Cz_Wyszukaj.Size = new System.Drawing.Size(144, 52);
            this.Cz_Wyszukaj.TabIndex = 8;
            this.Cz_Wyszukaj.Text = "Dane czytelników";
            this.Cz_Wyszukaj.UseVisualStyleBackColor = true;
            this.Cz_Wyszukaj.Click += new System.EventHandler(this.Cz_Wyszukaj_Click);
            // 
            // Ks_Wyszukaj
            // 
            this.Ks_Wyszukaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ks_Wyszukaj.Location = new System.Drawing.Point(165, 169);
            this.Ks_Wyszukaj.Name = "Ks_Wyszukaj";
            this.Ks_Wyszukaj.Size = new System.Drawing.Size(147, 52);
            this.Ks_Wyszukaj.TabIndex = 10;
            this.Ks_Wyszukaj.Text = "Przeszukaj biblotekę";
            this.Ks_Wyszukaj.UseVisualStyleBackColor = true;
            this.Ks_Wyszukaj.Click += new System.EventHandler(this.Ks_Wyszukaj_Click);
            // 
            // Wy_Wyszukaj
            // 
            this.Wy_Wyszukaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wy_Wyszukaj.Location = new System.Drawing.Point(318, 169);
            this.Wy_Wyszukaj.Name = "Wy_Wyszukaj";
            this.Wy_Wyszukaj.Size = new System.Drawing.Size(147, 52);
            this.Wy_Wyszukaj.TabIndex = 12;
            this.Wy_Wyszukaj.Text = "Przeglądaj wypożyczenia";
            this.Wy_Wyszukaj.UseVisualStyleBackColor = true;
            this.Wy_Wyszukaj.Click += new System.EventHandler(this.Wy_Wyszukaj_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(479, 239);
            this.Controls.Add(this.Wy_Wyszukaj);
            this.Controls.Add(this.Ks_Wyszukaj);
            this.Controls.Add(this.Cz_Wyszukaj);
            this.Controls.Add(this.Menu_Powitanie);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Menu_Powitanie;
        private System.Windows.Forms.Button Cz_Wyszukaj;
        private System.Windows.Forms.Button Ks_Wyszukaj;
        private System.Windows.Forms.Button Wy_Wyszukaj;
    }
}

