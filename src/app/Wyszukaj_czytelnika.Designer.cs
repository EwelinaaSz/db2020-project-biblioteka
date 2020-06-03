namespace Bibioteka_Zieja_Błoniarz
{
    partial class Wyszukaj_czytelnika
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
            this.DATA_CZYTELNICY = new System.Windows.Forms.DataGridView();
            this.BUT_SZUKAJ = new System.Windows.Forms.Button();
            this.INSTRUKCJA = new System.Windows.Forms.Label();
            this.IMIE = new System.Windows.Forms.Label();
            this.INPUT_IMIE = new System.Windows.Forms.TextBox();
            this.INPUT_NAZWISKO = new System.Windows.Forms.TextBox();
            this.NAZWISKO = new System.Windows.Forms.Label();
            this.INPUT_KARTA = new System.Windows.Forms.TextBox();
            this.KARTA = new System.Windows.Forms.Label();
            this.BUT_EDYTUJ = new System.Windows.Forms.Button();
            this.BUT_USUN = new System.Windows.Forms.Button();
            this.BUT_WYPOZYCZ = new System.Windows.Forms.Button();
            this.BUT_DODAJ = new System.Windows.Forms.Button();
            this.BUT_WYBIERZ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_CZYTELNICY)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA_CZYTELNICY
            // 
            this.DATA_CZYTELNICY.AllowUserToAddRows = false;
            this.DATA_CZYTELNICY.AllowUserToDeleteRows = false;
            this.DATA_CZYTELNICY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA_CZYTELNICY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_CZYTELNICY.Location = new System.Drawing.Point(12, 106);
            this.DATA_CZYTELNICY.MultiSelect = false;
            this.DATA_CZYTELNICY.Name = "DATA_CZYTELNICY";
            this.DATA_CZYTELNICY.ReadOnly = true;
            this.DATA_CZYTELNICY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATA_CZYTELNICY.Size = new System.Drawing.Size(951, 309);
            this.DATA_CZYTELNICY.TabIndex = 0;
            this.DATA_CZYTELNICY.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CZYTELNICY_CellClick);
            // 
            // BUT_SZUKAJ
            // 
            this.BUT_SZUKAJ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_SZUKAJ.Location = new System.Drawing.Point(858, 61);
            this.BUT_SZUKAJ.Name = "BUT_SZUKAJ";
            this.BUT_SZUKAJ.Size = new System.Drawing.Size(105, 35);
            this.BUT_SZUKAJ.TabIndex = 6;
            this.BUT_SZUKAJ.Text = "Szukaj";
            this.BUT_SZUKAJ.UseVisualStyleBackColor = true;
            this.BUT_SZUKAJ.Click += new System.EventHandler(this.BUT_SZUKAJ_Click);
            // 
            // INSTRUKCJA
            // 
            this.INSTRUKCJA.AutoSize = true;
            this.INSTRUKCJA.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.INSTRUKCJA.Location = new System.Drawing.Point(301, 9);
            this.INSTRUKCJA.Name = "INSTRUKCJA";
            this.INSTRUKCJA.Size = new System.Drawing.Size(343, 29);
            this.INSTRUKCJA.TabIndex = 7;
            this.INSTRUKCJA.Text = "Podaj dane czytelnika:";
            this.INSTRUKCJA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IMIE
            // 
            this.IMIE.AutoSize = true;
            this.IMIE.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.IMIE.Location = new System.Drawing.Point(8, 65);
            this.IMIE.Name = "IMIE";
            this.IMIE.Size = new System.Drawing.Size(70, 24);
            this.IMIE.TabIndex = 8;
            this.IMIE.Text = "Imie:";
            this.IMIE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INPUT_IMIE
            // 
            this.INPUT_IMIE.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_IMIE.Location = new System.Drawing.Point(84, 64);
            this.INPUT_IMIE.Name = "INPUT_IMIE";
            this.INPUT_IMIE.Size = new System.Drawing.Size(167, 28);
            this.INPUT_IMIE.TabIndex = 17;
            // 
            // INPUT_NAZWISKO
            // 
            this.INPUT_NAZWISKO.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_NAZWISKO.Location = new System.Drawing.Point(381, 64);
            this.INPUT_NAZWISKO.Name = "INPUT_NAZWISKO";
            this.INPUT_NAZWISKO.Size = new System.Drawing.Size(167, 28);
            this.INPUT_NAZWISKO.TabIndex = 19;
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.AutoSize = true;
            this.NAZWISKO.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.NAZWISKO.Location = new System.Drawing.Point(257, 65);
            this.NAZWISKO.Name = "NAZWISKO";
            this.NAZWISKO.Size = new System.Drawing.Size(118, 24);
            this.NAZWISKO.TabIndex = 18;
            this.NAZWISKO.Text = "Nazwisko:";
            this.NAZWISKO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INPUT_KARTA
            // 
            this.INPUT_KARTA.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.75F);
            this.INPUT_KARTA.Location = new System.Drawing.Point(738, 65);
            this.INPUT_KARTA.Name = "INPUT_KARTA";
            this.INPUT_KARTA.Size = new System.Drawing.Size(114, 28);
            this.INPUT_KARTA.TabIndex = 23;
            // 
            // KARTA
            // 
            this.KARTA.AutoSize = true;
            this.KARTA.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.KARTA.Location = new System.Drawing.Point(554, 53);
            this.KARTA.Name = "KARTA";
            this.KARTA.Size = new System.Drawing.Size(178, 48);
            this.KARTA.TabIndex = 22;
            this.KARTA.Text = "Numer karty \r\nbibliotycznej:";
            this.KARTA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUT_EDYTUJ
            // 
            this.BUT_EDYTUJ.Enabled = false;
            this.BUT_EDYTUJ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_EDYTUJ.Location = new System.Drawing.Point(203, 428);
            this.BUT_EDYTUJ.Name = "BUT_EDYTUJ";
            this.BUT_EDYTUJ.Size = new System.Drawing.Size(185, 53);
            this.BUT_EDYTUJ.TabIndex = 25;
            this.BUT_EDYTUJ.Text = "Edytuj dane czytelnika";
            this.BUT_EDYTUJ.UseVisualStyleBackColor = true;
            this.BUT_EDYTUJ.Click += new System.EventHandler(this.BUT_EDYTUJ_Click);
            // 
            // BUT_USUN
            // 
            this.BUT_USUN.Enabled = false;
            this.BUT_USUN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_USUN.Location = new System.Drawing.Point(394, 428);
            this.BUT_USUN.Name = "BUT_USUN";
            this.BUT_USUN.Size = new System.Drawing.Size(185, 53);
            this.BUT_USUN.TabIndex = 26;
            this.BUT_USUN.Text = "Usuń czytelnika";
            this.BUT_USUN.UseVisualStyleBackColor = true;
            this.BUT_USUN.Click += new System.EventHandler(this.BUT_USUN_Click);
            // 
            // BUT_WYPOZYCZ
            // 
            this.BUT_WYPOZYCZ.Enabled = false;
            this.BUT_WYPOZYCZ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WYPOZYCZ.Location = new System.Drawing.Point(724, 428);
            this.BUT_WYPOZYCZ.Name = "BUT_WYPOZYCZ";
            this.BUT_WYPOZYCZ.Size = new System.Drawing.Size(239, 53);
            this.BUT_WYPOZYCZ.TabIndex = 27;
            this.BUT_WYPOZYCZ.Text = "Wypożycz książkę czytelnikowi";
            this.BUT_WYPOZYCZ.UseVisualStyleBackColor = true;
            this.BUT_WYPOZYCZ.Click += new System.EventHandler(this.BUT_WYPOZYCZ_Click);
            // 
            // BUT_DODAJ
            // 
            this.BUT_DODAJ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_DODAJ.Location = new System.Drawing.Point(12, 428);
            this.BUT_DODAJ.Name = "BUT_DODAJ";
            this.BUT_DODAJ.Size = new System.Drawing.Size(185, 53);
            this.BUT_DODAJ.TabIndex = 28;
            this.BUT_DODAJ.Text = "Dodaj czytelnika";
            this.BUT_DODAJ.UseVisualStyleBackColor = true;
            this.BUT_DODAJ.Click += new System.EventHandler(this.BUT_DODAJ_Click);
            // 
            // BUT_WYBIERZ
            // 
            this.BUT_WYBIERZ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WYBIERZ.Location = new System.Drawing.Point(837, 428);
            this.BUT_WYBIERZ.Name = "BUT_WYBIERZ";
            this.BUT_WYBIERZ.Size = new System.Drawing.Size(125, 53);
            this.BUT_WYBIERZ.TabIndex = 40;
            this.BUT_WYBIERZ.Text = "Wybierz";
            this.BUT_WYBIERZ.UseVisualStyleBackColor = true;
            this.BUT_WYBIERZ.Click += new System.EventHandler(this.BUT_WYBIERZ_Click);
            // 
            // Wyszukaj_czytelnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 491);
            this.Controls.Add(this.BUT_WYBIERZ);
            this.Controls.Add(this.BUT_DODAJ);
            this.Controls.Add(this.BUT_WYPOZYCZ);
            this.Controls.Add(this.BUT_USUN);
            this.Controls.Add(this.BUT_EDYTUJ);
            this.Controls.Add(this.INPUT_KARTA);
            this.Controls.Add(this.KARTA);
            this.Controls.Add(this.INPUT_NAZWISKO);
            this.Controls.Add(this.NAZWISKO);
            this.Controls.Add(this.INPUT_IMIE);
            this.Controls.Add(this.IMIE);
            this.Controls.Add(this.INSTRUKCJA);
            this.Controls.Add(this.BUT_SZUKAJ);
            this.Controls.Add(this.DATA_CZYTELNICY);
            this.Name = "Wyszukaj_czytelnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wyszukaj_czytelnika";
            this.Load += new System.EventHandler(this.Wyszukaj_czytelnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA_CZYTELNICY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DATA_CZYTELNICY;
        private System.Windows.Forms.Button BUT_SZUKAJ;
        private System.Windows.Forms.Label INSTRUKCJA;
        private System.Windows.Forms.Label IMIE;
        private System.Windows.Forms.TextBox INPUT_IMIE;
        private System.Windows.Forms.TextBox INPUT_NAZWISKO;
        private System.Windows.Forms.Label NAZWISKO;
        private System.Windows.Forms.TextBox INPUT_KARTA;
        private System.Windows.Forms.Label KARTA;
        private System.Windows.Forms.Button BUT_EDYTUJ;
        private System.Windows.Forms.Button BUT_USUN;
        private System.Windows.Forms.Button BUT_WYPOZYCZ;
        private System.Windows.Forms.Button BUT_DODAJ;
        private System.Windows.Forms.Button BUT_WYBIERZ;
    }
}