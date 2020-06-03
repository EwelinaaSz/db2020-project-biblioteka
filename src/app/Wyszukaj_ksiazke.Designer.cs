namespace Bibioteka_Zieja_Błoniarz
{
    partial class Wyszukaj_ksiazke
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
            this.KATEGORIA = new System.Windows.Forms.Label();
            this.INPUT_NAZWISKO = new System.Windows.Forms.TextBox();
            this.NAZWISKO = new System.Windows.Forms.Label();
            this.INPUT_TYTUL = new System.Windows.Forms.TextBox();
            this.TUTUL = new System.Windows.Forms.Label();
            this.INSTRUKCJA = new System.Windows.Forms.Label();
            this.BUT_SZUKAJ = new System.Windows.Forms.Button();
            this.DATA_KSIAZKI = new System.Windows.Forms.DataGridView();
            this.INPUT_KATEGORIA = new System.Windows.Forms.ComboBox();
            this.BUT_WYPOZYCZ = new System.Windows.Forms.Button();
            this.BUT_DODAJ_KSIAZKE = new System.Windows.Forms.Button();
            this.BUT_DODAJ_EGZ = new System.Windows.Forms.Button();
            this.BUT_WYBIERZ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_KSIAZKI)).BeginInit();
            this.SuspendLayout();
            // 
            // KATEGORIA
            // 
            this.KATEGORIA.AutoSize = true;
            this.KATEGORIA.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.KATEGORIA.Location = new System.Drawing.Point(551, 66);
            this.KATEGORIA.Name = "KATEGORIA";
            this.KATEGORIA.Size = new System.Drawing.Size(130, 24);
            this.KATEGORIA.TabIndex = 32;
            this.KATEGORIA.Text = "Kategoria:";
            this.KATEGORIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INPUT_NAZWISKO
            // 
            this.INPUT_NAZWISKO.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_NAZWISKO.Location = new System.Drawing.Point(378, 64);
            this.INPUT_NAZWISKO.Name = "INPUT_NAZWISKO";
            this.INPUT_NAZWISKO.Size = new System.Drawing.Size(167, 28);
            this.INPUT_NAZWISKO.TabIndex = 31;
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.AutoSize = true;
            this.NAZWISKO.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.NAZWISKO.Location = new System.Drawing.Point(266, 53);
            this.NAZWISKO.Name = "NAZWISKO";
            this.NAZWISKO.Size = new System.Drawing.Size(106, 48);
            this.NAZWISKO.TabIndex = 30;
            this.NAZWISKO.Text = "Nazwisko\r\nAutora:";
            this.NAZWISKO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INPUT_TYTUL
            // 
            this.INPUT_TYTUL.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_TYTUL.Location = new System.Drawing.Point(93, 64);
            this.INPUT_TYTUL.Name = "INPUT_TYTUL";
            this.INPUT_TYTUL.Size = new System.Drawing.Size(167, 28);
            this.INPUT_TYTUL.TabIndex = 29;
            // 
            // TUTUL
            // 
            this.TUTUL.AutoSize = true;
            this.TUTUL.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.TUTUL.Location = new System.Drawing.Point(5, 66);
            this.TUTUL.Name = "TUTUL";
            this.TUTUL.Size = new System.Drawing.Size(82, 24);
            this.TUTUL.TabIndex = 28;
            this.TUTUL.Text = "Tytuł:";
            this.TUTUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INSTRUKCJA
            // 
            this.INSTRUKCJA.AutoSize = true;
            this.INSTRUKCJA.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.INSTRUKCJA.Location = new System.Drawing.Point(352, 9);
            this.INSTRUKCJA.Name = "INSTRUKCJA";
            this.INSTRUKCJA.Size = new System.Drawing.Size(268, 29);
            this.INSTRUKCJA.TabIndex = 27;
            this.INSTRUKCJA.Text = "Wyszukaj książkę:";
            this.INSTRUKCJA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUT_SZUKAJ
            // 
            this.BUT_SZUKAJ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_SZUKAJ.Location = new System.Drawing.Point(858, 61);
            this.BUT_SZUKAJ.Name = "BUT_SZUKAJ";
            this.BUT_SZUKAJ.Size = new System.Drawing.Size(105, 35);
            this.BUT_SZUKAJ.TabIndex = 26;
            this.BUT_SZUKAJ.Text = "Szukaj";
            this.BUT_SZUKAJ.UseVisualStyleBackColor = true;
            this.BUT_SZUKAJ.Click += new System.EventHandler(this.BUT_SZUKAJ_Click);
            // 
            // DATA_KSIAZKI
            // 
            this.DATA_KSIAZKI.AllowUserToAddRows = false;
            this.DATA_KSIAZKI.AllowUserToDeleteRows = false;
            this.DATA_KSIAZKI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA_KSIAZKI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_KSIAZKI.Location = new System.Drawing.Point(12, 106);
            this.DATA_KSIAZKI.MultiSelect = false;
            this.DATA_KSIAZKI.Name = "DATA_KSIAZKI";
            this.DATA_KSIAZKI.ReadOnly = true;
            this.DATA_KSIAZKI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATA_KSIAZKI.Size = new System.Drawing.Size(951, 309);
            this.DATA_KSIAZKI.TabIndex = 25;
            this.DATA_KSIAZKI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_KSIAZKI_CellClick);
            // 
            // INPUT_KATEGORIA
            // 
            this.INPUT_KATEGORIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.INPUT_KATEGORIA.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_KATEGORIA.FormattingEnabled = true;
            this.INPUT_KATEGORIA.Items.AddRange(new object[] {
            "dramat",
            "dziecęca",
            "fantastyka",
            "horror",
            "komedia",
            "kryminał",
            "młodzieżowa",
            "obyczajowa",
            "poezja",
            "popularnonaukowa",
            "publicystyka",
            "romans",
            "inne"});
            this.INPUT_KATEGORIA.Location = new System.Drawing.Point(687, 61);
            this.INPUT_KATEGORIA.Name = "INPUT_KATEGORIA";
            this.INPUT_KATEGORIA.Size = new System.Drawing.Size(167, 31);
            this.INPUT_KATEGORIA.TabIndex = 35;
            // 
            // BUT_WYPOZYCZ
            // 
            this.BUT_WYPOZYCZ.Enabled = false;
            this.BUT_WYPOZYCZ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WYPOZYCZ.Location = new System.Drawing.Point(723, 426);
            this.BUT_WYPOZYCZ.Name = "BUT_WYPOZYCZ";
            this.BUT_WYPOZYCZ.Size = new System.Drawing.Size(239, 53);
            this.BUT_WYPOZYCZ.TabIndex = 36;
            this.BUT_WYPOZYCZ.Text = "Wypożycz wybraną książkę";
            this.BUT_WYPOZYCZ.UseVisualStyleBackColor = true;
            this.BUT_WYPOZYCZ.Click += new System.EventHandler(this.BUT_WYPOZYCZ_Click);
            // 
            // BUT_DODAJ_KSIAZKE
            // 
            this.BUT_DODAJ_KSIAZKE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_DODAJ_KSIAZKE.Location = new System.Drawing.Point(12, 426);
            this.BUT_DODAJ_KSIAZKE.Name = "BUT_DODAJ_KSIAZKE";
            this.BUT_DODAJ_KSIAZKE.Size = new System.Drawing.Size(156, 53);
            this.BUT_DODAJ_KSIAZKE.TabIndex = 37;
            this.BUT_DODAJ_KSIAZKE.Text = "Dodaj książkę";
            this.BUT_DODAJ_KSIAZKE.UseVisualStyleBackColor = true;
            this.BUT_DODAJ_KSIAZKE.Click += new System.EventHandler(this.BUT_DODAJ_Click);
            // 
            // BUT_DODAJ_EGZ
            // 
            this.BUT_DODAJ_EGZ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_DODAJ_EGZ.Location = new System.Drawing.Point(174, 426);
            this.BUT_DODAJ_EGZ.Name = "BUT_DODAJ_EGZ";
            this.BUT_DODAJ_EGZ.Size = new System.Drawing.Size(156, 53);
            this.BUT_DODAJ_EGZ.TabIndex = 38;
            this.BUT_DODAJ_EGZ.Text = "Dodaj egzemplarz";
            this.BUT_DODAJ_EGZ.UseVisualStyleBackColor = true;
            this.BUT_DODAJ_EGZ.Click += new System.EventHandler(this.BUT_DODAJ_EGZ_Click);
            // 
            // BUT_WYBIERZ
            // 
            this.BUT_WYBIERZ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WYBIERZ.Location = new System.Drawing.Point(837, 426);
            this.BUT_WYBIERZ.Name = "BUT_WYBIERZ";
            this.BUT_WYBIERZ.Size = new System.Drawing.Size(125, 53);
            this.BUT_WYBIERZ.TabIndex = 39;
            this.BUT_WYBIERZ.Text = "Wybierz";
            this.BUT_WYBIERZ.UseVisualStyleBackColor = true;
            this.BUT_WYBIERZ.Click += new System.EventHandler(this.BUT_WYBIERZ_Click);
            // 
            // Wyszukaj_ksiazke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 491);
            this.Controls.Add(this.BUT_WYBIERZ);
            this.Controls.Add(this.BUT_DODAJ_EGZ);
            this.Controls.Add(this.BUT_DODAJ_KSIAZKE);
            this.Controls.Add(this.BUT_WYPOZYCZ);
            this.Controls.Add(this.INPUT_KATEGORIA);
            this.Controls.Add(this.KATEGORIA);
            this.Controls.Add(this.INPUT_NAZWISKO);
            this.Controls.Add(this.NAZWISKO);
            this.Controls.Add(this.INPUT_TYTUL);
            this.Controls.Add(this.TUTUL);
            this.Controls.Add(this.INSTRUKCJA);
            this.Controls.Add(this.BUT_SZUKAJ);
            this.Controls.Add(this.DATA_KSIAZKI);
            this.Name = "Wyszukaj_ksiazke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wyszukaj_ksiazke";
            this.Load += new System.EventHandler(this.Wyszukaj_ksiazke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA_KSIAZKI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KATEGORIA;
        private System.Windows.Forms.TextBox INPUT_NAZWISKO;
        private System.Windows.Forms.Label NAZWISKO;
        private System.Windows.Forms.TextBox INPUT_TYTUL;
        private System.Windows.Forms.Label TUTUL;
        private System.Windows.Forms.Label INSTRUKCJA;
        private System.Windows.Forms.Button BUT_SZUKAJ;
        private System.Windows.Forms.DataGridView DATA_KSIAZKI;
        private System.Windows.Forms.ComboBox INPUT_KATEGORIA;
        private System.Windows.Forms.Button BUT_WYPOZYCZ;
        private System.Windows.Forms.Button BUT_DODAJ_KSIAZKE;
        private System.Windows.Forms.Button BUT_DODAJ_EGZ;
        private System.Windows.Forms.Button BUT_WYBIERZ;
    }
}