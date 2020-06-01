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
            this.INPUT_IMIE = new System.Windows.Forms.TextBox();
            this.TUTUL = new System.Windows.Forms.Label();
            this.INSTRUKCJA = new System.Windows.Forms.Label();
            this.BUT_SZUKAJ = new System.Windows.Forms.Button();
            this.DATA_KSIAZKI = new System.Windows.Forms.DataGridView();
            this.INPUT_KATEGORIA = new System.Windows.Forms.ComboBox();
            this.INFORMACJA_2 = new System.Windows.Forms.Label();
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
            // INPUT_IMIE
            // 
            this.INPUT_IMIE.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_IMIE.Location = new System.Drawing.Point(93, 64);
            this.INPUT_IMIE.Name = "INPUT_IMIE";
            this.INPUT_IMIE.Size = new System.Drawing.Size(167, 28);
            this.INPUT_IMIE.TabIndex = 29;
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
            this.INSTRUKCJA.Location = new System.Drawing.Point(409, 9);
            this.INSTRUKCJA.Name = "INSTRUKCJA";
            this.INSTRUKCJA.Size = new System.Drawing.Size(148, 29);
            this.INSTRUKCJA.TabIndex = 27;
            this.INSTRUKCJA.Text = "Wyszukaj:";
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
            // 
            // INPUT_KATEGORIA
            // 
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
            // INFORMACJA_2
            // 
            this.INFORMACJA_2.AutoSize = true;
            this.INFORMACJA_2.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.INFORMACJA_2.Location = new System.Drawing.Point(232, 427);
            this.INFORMACJA_2.Name = "INFORMACJA_2";
            this.INFORMACJA_2.Size = new System.Drawing.Size(508, 29);
            this.INFORMACJA_2.TabIndex = 34;
            this.INFORMACJA_2.Text = "Kilknij dwukrotnie aby wypożyczyć";
            this.INFORMACJA_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wyszukaj_ksiazke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 472);
            this.Controls.Add(this.INPUT_KATEGORIA);
            this.Controls.Add(this.INFORMACJA_2);
            this.Controls.Add(this.KATEGORIA);
            this.Controls.Add(this.INPUT_NAZWISKO);
            this.Controls.Add(this.NAZWISKO);
            this.Controls.Add(this.INPUT_IMIE);
            this.Controls.Add(this.TUTUL);
            this.Controls.Add(this.INSTRUKCJA);
            this.Controls.Add(this.BUT_SZUKAJ);
            this.Controls.Add(this.DATA_KSIAZKI);
            this.Name = "Wyszukaj_ksiazke";
            this.Text = "Wyszukaj_ksiazke";
            ((System.ComponentModel.ISupportInitialize)(this.DATA_KSIAZKI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KATEGORIA;
        private System.Windows.Forms.TextBox INPUT_NAZWISKO;
        private System.Windows.Forms.Label NAZWISKO;
        private System.Windows.Forms.TextBox INPUT_IMIE;
        private System.Windows.Forms.Label TUTUL;
        private System.Windows.Forms.Label INSTRUKCJA;
        private System.Windows.Forms.Button BUT_SZUKAJ;
        private System.Windows.Forms.DataGridView DATA_KSIAZKI;
        private System.Windows.Forms.ComboBox INPUT_KATEGORIA;
        private System.Windows.Forms.Label INFORMACJA_2;
    }
}