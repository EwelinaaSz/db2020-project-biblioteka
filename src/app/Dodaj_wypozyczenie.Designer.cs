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
            this.INSTRUKCJA = new System.Windows.Forms.Label();
            this.WYBOR_CZYTELNIKA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.INPUT_CZYTELNIK = new System.Windows.Forms.ComboBox();
            this.INPUT_KSIAZKA = new System.Windows.Forms.ComboBox();
            this.BUT_WYPOZYCZ = new System.Windows.Forms.Button();
            this.OKRES = new System.Windows.Forms.Label();
            this.INPUT_OKRES = new System.Windows.Forms.ComboBox();
            this.DNI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // INSTRUKCJA
            // 
            this.INSTRUKCJA.AutoSize = true;
            this.INSTRUKCJA.Font = new System.Drawing.Font("Unispace", 18.25F, System.Drawing.FontStyle.Bold);
            this.INSTRUKCJA.Location = new System.Drawing.Point(58, 18);
            this.INSTRUKCJA.Name = "INSTRUKCJA";
            this.INSTRUKCJA.Size = new System.Drawing.Size(253, 30);
            this.INSTRUKCJA.TabIndex = 3;
            this.INSTRUKCJA.Text = "Wypożycz książkę";
            // 
            // WYBOR_CZYTELNIKA
            // 
            this.WYBOR_CZYTELNIKA.AutoSize = true;
            this.WYBOR_CZYTELNIKA.Font = new System.Drawing.Font("Unispace", 15.25F, System.Drawing.FontStyle.Bold);
            this.WYBOR_CZYTELNIKA.Location = new System.Drawing.Point(12, 92);
            this.WYBOR_CZYTELNIKA.Name = "WYBOR_CZYTELNIKA";
            this.WYBOR_CZYTELNIKA.Size = new System.Drawing.Size(363, 25);
            this.WYBOR_CZYTELNIKA.TabIndex = 4;
            this.WYBOR_CZYTELNIKA.Text = "Nazwisko i imie czytelnika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(97, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tytuł książki:";
            // 
            // INPUT_CZYTELNIK
            // 
            this.INPUT_CZYTELNIK.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.INPUT_CZYTELNIK.FormattingEnabled = true;
            this.INPUT_CZYTELNIK.Location = new System.Drawing.Point(17, 138);
            this.INPUT_CZYTELNIK.Name = "INPUT_CZYTELNIK";
            this.INPUT_CZYTELNIK.Size = new System.Drawing.Size(358, 34);
            this.INPUT_CZYTELNIK.TabIndex = 32;
            // 
            // INPUT_KSIAZKA
            // 
            this.INPUT_KSIAZKA.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.INPUT_KSIAZKA.FormattingEnabled = true;
            this.INPUT_KSIAZKA.Location = new System.Drawing.Point(17, 243);
            this.INPUT_KSIAZKA.Name = "INPUT_KSIAZKA";
            this.INPUT_KSIAZKA.Size = new System.Drawing.Size(358, 34);
            this.INPUT_KSIAZKA.TabIndex = 33;
            // 
            // BUT_WYPOZYCZ
            // 
            this.BUT_WYPOZYCZ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BUT_WYPOZYCZ.Location = new System.Drawing.Point(17, 401);
            this.BUT_WYPOZYCZ.Name = "BUT_WYPOZYCZ";
            this.BUT_WYPOZYCZ.Size = new System.Drawing.Size(358, 63);
            this.BUT_WYPOZYCZ.TabIndex = 34;
            this.BUT_WYPOZYCZ.Text = "Wypożycz";
            this.BUT_WYPOZYCZ.UseVisualStyleBackColor = true;
            // 
            // OKRES
            // 
            this.OKRES.AutoSize = true;
            this.OKRES.Font = new System.Drawing.Font("Unispace", 15.25F, System.Drawing.FontStyle.Bold);
            this.OKRES.Location = new System.Drawing.Point(12, 330);
            this.OKRES.Name = "OKRES";
            this.OKRES.Size = new System.Drawing.Size(259, 25);
            this.OKRES.TabIndex = 35;
            this.OKRES.Text = "Okres wypożyczenia:";
            // 
            // INPUT_OKRES
            // 
            this.INPUT_OKRES.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.INPUT_OKRES.FormattingEnabled = true;
            this.INPUT_OKRES.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.INPUT_OKRES.Location = new System.Drawing.Point(267, 326);
            this.INPUT_OKRES.Name = "INPUT_OKRES";
            this.INPUT_OKRES.Size = new System.Drawing.Size(63, 34);
            this.INPUT_OKRES.TabIndex = 36;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Font = new System.Drawing.Font("Unispace", 15.25F, System.Drawing.FontStyle.Bold);
            this.DNI.Location = new System.Drawing.Point(336, 330);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(51, 25);
            this.DNI.TabIndex = 37;
            this.DNI.Text = "dni";
            // 
            // Dodaj_wypozyczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(391, 475);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.INPUT_OKRES);
            this.Controls.Add(this.OKRES);
            this.Controls.Add(this.BUT_WYPOZYCZ);
            this.Controls.Add(this.INPUT_KSIAZKA);
            this.Controls.Add(this.INPUT_CZYTELNIK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WYBOR_CZYTELNIKA);
            this.Controls.Add(this.INSTRUKCJA);
            this.Name = "Dodaj_wypozyczenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj_wypożyczenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label INSTRUKCJA;
        private System.Windows.Forms.Label WYBOR_CZYTELNIKA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox INPUT_CZYTELNIK;
        private System.Windows.Forms.ComboBox INPUT_KSIAZKA;
        private System.Windows.Forms.Button BUT_WYPOZYCZ;
        private System.Windows.Forms.Label OKRES;
        private System.Windows.Forms.ComboBox INPUT_OKRES;
        private System.Windows.Forms.Label DNI;
    }
}