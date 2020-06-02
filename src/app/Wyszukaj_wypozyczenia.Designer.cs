namespace Bibioteka_Zieja_Błoniarz
{
    partial class Wyszukaj_wypozyczenia
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
            this.DATA_KSIAZKI = new System.Windows.Forms.DataGridView();
            this.INPUT_KARTA = new System.Windows.Forms.TextBox();
            this.KARTA = new System.Windows.Forms.Label();
            this.INPUT_NAZWISKO = new System.Windows.Forms.TextBox();
            this.NAZWISKO = new System.Windows.Forms.Label();
            this.INSTRUKCJA = new System.Windows.Forms.Label();
            this.BUT_SZUKAJ = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TUTUL = new System.Windows.Forms.Label();
            this.BUT_WYPOZYCZ = new System.Windows.Forms.Button();
            this.BUT_ZWRÓT = new System.Windows.Forms.Button();
            this.BUT_PRZETRZYMANIA = new System.Windows.Forms.Button();
            this.BUT_WSZYSTKIE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_KSIAZKI)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA_KSIAZKI
            // 
            this.DATA_KSIAZKI.AllowUserToAddRows = false;
            this.DATA_KSIAZKI.AllowUserToDeleteRows = false;
            this.DATA_KSIAZKI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA_KSIAZKI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_KSIAZKI.Location = new System.Drawing.Point(11, 104);
            this.DATA_KSIAZKI.MultiSelect = false;
            this.DATA_KSIAZKI.Name = "DATA_KSIAZKI";
            this.DATA_KSIAZKI.ReadOnly = true;
            this.DATA_KSIAZKI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATA_KSIAZKI.Size = new System.Drawing.Size(951, 309);
            this.DATA_KSIAZKI.TabIndex = 26;
            // 
            // INPUT_KARTA
            // 
            this.INPUT_KARTA.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_KARTA.Location = new System.Drawing.Point(737, 65);
            this.INPUT_KARTA.Name = "INPUT_KARTA";
            this.INPUT_KARTA.Size = new System.Drawing.Size(114, 28);
            this.INPUT_KARTA.TabIndex = 34;
            // 
            // KARTA
            // 
            this.KARTA.AutoSize = true;
            this.KARTA.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.KARTA.Location = new System.Drawing.Point(553, 53);
            this.KARTA.Name = "KARTA";
            this.KARTA.Size = new System.Drawing.Size(178, 48);
            this.KARTA.TabIndex = 33;
            this.KARTA.Text = "Numer karty \r\nbibliotycznej:";
            this.KARTA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INPUT_NAZWISKO
            // 
            this.INPUT_NAZWISKO.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_NAZWISKO.Location = new System.Drawing.Point(397, 65);
            this.INPUT_NAZWISKO.Name = "INPUT_NAZWISKO";
            this.INPUT_NAZWISKO.Size = new System.Drawing.Size(140, 28);
            this.INPUT_NAZWISKO.TabIndex = 32;
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.AutoSize = true;
            this.NAZWISKO.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.NAZWISKO.Location = new System.Drawing.Point(273, 66);
            this.NAZWISKO.Name = "NAZWISKO";
            this.NAZWISKO.Size = new System.Drawing.Size(118, 24);
            this.NAZWISKO.TabIndex = 31;
            this.NAZWISKO.Text = "Nazwisko:";
            this.NAZWISKO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INSTRUKCJA
            // 
            this.INSTRUKCJA.AutoSize = true;
            this.INSTRUKCJA.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.INSTRUKCJA.Location = new System.Drawing.Point(300, 9);
            this.INSTRUKCJA.Name = "INSTRUKCJA";
            this.INSTRUKCJA.Size = new System.Drawing.Size(373, 29);
            this.INSTRUKCJA.TabIndex = 28;
            this.INSTRUKCJA.Text = "Przeszukaj wypożyczenia:";
            this.INSTRUKCJA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUT_SZUKAJ
            // 
            this.BUT_SZUKAJ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_SZUKAJ.Location = new System.Drawing.Point(857, 61);
            this.BUT_SZUKAJ.Name = "BUT_SZUKAJ";
            this.BUT_SZUKAJ.Size = new System.Drawing.Size(105, 35);
            this.BUT_SZUKAJ.TabIndex = 27;
            this.BUT_SZUKAJ.Text = "Szukaj";
            this.BUT_SZUKAJ.UseVisualStyleBackColor = true;
            this.BUT_SZUKAJ.Click += new System.EventHandler(this.BUT_SZUKAJ_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.textBox1.Location = new System.Drawing.Point(100, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 28);
            this.textBox1.TabIndex = 36;
            // 
            // TUTUL
            // 
            this.TUTUL.AutoSize = true;
            this.TUTUL.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.TUTUL.Location = new System.Drawing.Point(12, 66);
            this.TUTUL.Name = "TUTUL";
            this.TUTUL.Size = new System.Drawing.Size(82, 24);
            this.TUTUL.TabIndex = 35;
            this.TUTUL.Text = "Tytuł:";
            this.TUTUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUT_WYPOZYCZ
            // 
            this.BUT_WYPOZYCZ.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_WYPOZYCZ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WYPOZYCZ.Location = new System.Drawing.Point(773, 426);
            this.BUT_WYPOZYCZ.Name = "BUT_WYPOZYCZ";
            this.BUT_WYPOZYCZ.Size = new System.Drawing.Size(189, 53);
            this.BUT_WYPOZYCZ.TabIndex = 37;
            this.BUT_WYPOZYCZ.Text = "Nowe wypożyczenie";
            this.BUT_WYPOZYCZ.UseVisualStyleBackColor = false;
            this.BUT_WYPOZYCZ.Click += new System.EventHandler(this.BUT_WYPOZYCZ_Click);
            // 
            // BUT_ZWRÓT
            // 
            this.BUT_ZWRÓT.Enabled = false;
            this.BUT_ZWRÓT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_ZWRÓT.Location = new System.Drawing.Point(578, 426);
            this.BUT_ZWRÓT.Name = "BUT_ZWRÓT";
            this.BUT_ZWRÓT.Size = new System.Drawing.Size(189, 53);
            this.BUT_ZWRÓT.TabIndex = 38;
            this.BUT_ZWRÓT.Text = "Oddaj książkę";
            this.BUT_ZWRÓT.UseVisualStyleBackColor = true;
            // 
            // BUT_PRZETRZYMANIA
            // 
            this.BUT_PRZETRZYMANIA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_PRZETRZYMANIA.Location = new System.Drawing.Point(11, 426);
            this.BUT_PRZETRZYMANIA.Name = "BUT_PRZETRZYMANIA";
            this.BUT_PRZETRZYMANIA.Size = new System.Drawing.Size(173, 53);
            this.BUT_PRZETRZYMANIA.TabIndex = 39;
            this.BUT_PRZETRZYMANIA.Text = "Przetrzymania";
            this.BUT_PRZETRZYMANIA.UseVisualStyleBackColor = true;
            // 
            // BUT_WSZYSTKIE
            // 
            this.BUT_WSZYSTKIE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WSZYSTKIE.Location = new System.Drawing.Point(190, 426);
            this.BUT_WSZYSTKIE.Name = "BUT_WSZYSTKIE";
            this.BUT_WSZYSTKIE.Size = new System.Drawing.Size(173, 53);
            this.BUT_WSZYSTKIE.TabIndex = 40;
            this.BUT_WSZYSTKIE.Text = "Aktywne wypożyczenia";
            this.BUT_WSZYSTKIE.UseVisualStyleBackColor = true;
            // 
            // Wyszukaj_wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 491);
            this.Controls.Add(this.BUT_WSZYSTKIE);
            this.Controls.Add(this.BUT_PRZETRZYMANIA);
            this.Controls.Add(this.BUT_ZWRÓT);
            this.Controls.Add(this.BUT_WYPOZYCZ);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TUTUL);
            this.Controls.Add(this.INPUT_KARTA);
            this.Controls.Add(this.KARTA);
            this.Controls.Add(this.INPUT_NAZWISKO);
            this.Controls.Add(this.NAZWISKO);
            this.Controls.Add(this.INSTRUKCJA);
            this.Controls.Add(this.BUT_SZUKAJ);
            this.Controls.Add(this.DATA_KSIAZKI);
            this.Name = "Wyszukaj_wypozyczenia";
            this.Text = "Wyszukaj_wypozyczenia";
            ((System.ComponentModel.ISupportInitialize)(this.DATA_KSIAZKI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DATA_KSIAZKI;
        private System.Windows.Forms.TextBox INPUT_KARTA;
        private System.Windows.Forms.Label KARTA;
        private System.Windows.Forms.TextBox INPUT_NAZWISKO;
        private System.Windows.Forms.Label NAZWISKO;
        private System.Windows.Forms.Label INSTRUKCJA;
        private System.Windows.Forms.Button BUT_SZUKAJ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TUTUL;
        private System.Windows.Forms.Button BUT_WYPOZYCZ;
        private System.Windows.Forms.Button BUT_ZWRÓT;
        private System.Windows.Forms.Button BUT_PRZETRZYMANIA;
        private System.Windows.Forms.Button BUT_WSZYSTKIE;
    }
}