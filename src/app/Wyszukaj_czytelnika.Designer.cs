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
            this.INFORMACJA_2 = new System.Windows.Forms.Label();
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
            this.DATA_CZYTELNICY.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CZYTELNICY_CellDoubleClick);
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
            // INFORMACJA_2
            // 
            this.INFORMACJA_2.AutoSize = true;
            this.INFORMACJA_2.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.INFORMACJA_2.Location = new System.Drawing.Point(88, 427);
            this.INFORMACJA_2.Name = "INFORMACJA_2";
            this.INFORMACJA_2.Size = new System.Drawing.Size(793, 29);
            this.INFORMACJA_2.TabIndex = 24;
            this.INFORMACJA_2.Text = "Aby edytować lub usunąć kliknij dwukrotnie na wiersz";
            this.INFORMACJA_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wyszukaj_czytelnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 475);
            this.Controls.Add(this.INFORMACJA_2);
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
        private System.Windows.Forms.Label INFORMACJA_2;
    }
}