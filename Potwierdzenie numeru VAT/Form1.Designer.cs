namespace Potwierdzenie_numeru_VAT
{
    partial class Potwierdzenie
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
            this.PanstwoCzlonkowskie = new System.Windows.Forms.Label();
            this.NumerVAT = new System.Windows.Forms.Label();
            this.WybierzKraj = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.WybierzKraj2 = new System.Windows.Forms.ComboBox();
            this.NumerVAT2 = new System.Windows.Forms.Label();
            this.PanstwoCzlonkowskiePytajacego = new System.Windows.Forms.Label();
            this.WeryfikujButton = new System.Windows.Forms.Button();
            this.krajSkrot = new System.Windows.Forms.Label();
            this.krajSkrot2 = new System.Windows.Forms.Label();
            this.labelValid = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ZapiszButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelPanstwoCzlonkowskie = new System.Windows.Forms.Label();
            this.labelNumer = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanstwoCzlonkowskie
            // 
            this.PanstwoCzlonkowskie.AutoSize = true;
            this.PanstwoCzlonkowskie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanstwoCzlonkowskie.Location = new System.Drawing.Point(39, 77);
            this.PanstwoCzlonkowskie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PanstwoCzlonkowskie.Name = "PanstwoCzlonkowskie";
            this.PanstwoCzlonkowskie.Size = new System.Drawing.Size(168, 20);
            this.PanstwoCzlonkowskie.TabIndex = 0;
            this.PanstwoCzlonkowskie.Text = "Państwo członkowskie";
            // 
            // NumerVAT
            // 
            this.NumerVAT.AutoSize = true;
            this.NumerVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerVAT.Location = new System.Drawing.Point(39, 148);
            this.NumerVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumerVAT.Name = "NumerVAT";
            this.NumerVAT.Size = new System.Drawing.Size(91, 20);
            this.NumerVAT.TabIndex = 1;
            this.NumerVAT.Text = "Numer VAT";
            // 
            // WybierzKraj
            // 
            this.WybierzKraj.FormattingEnabled = true;
            this.WybierzKraj.Items.AddRange(new object[] {
            "AT-Austria",
            "BE-Belgia",
            "BG-Bułgaria",
            "CY-Cypr",
            "CZ-Czechy",
            "DE-Niemcy",
            "DK-Dania",
            "EE-Estonia",
            "EL-Grecja",
            "ES-Hiszpania",
            "FI-Finlandia",
            "FR - Francja",
            "GB-Wielka Brytania",
            "HR-Chorwacja",
            "HU-Węgry",
            "IE-Irlandia",
            "IT-Włochy",
            "LT-Litwa",
            "LU-Luksemburg",
            "LV-Łotwa",
            "MT-Malta",
            "NL-Holandia",
            "PL-Polska",
            "PT-Portugalia",
            "RO-Rumunia",
            "SE-Szwecja",
            "SI-Słowenia",
            "SK-Słowacja"});
            this.WybierzKraj.Location = new System.Drawing.Point(300, 80);
            this.WybierzKraj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WybierzKraj.Name = "WybierzKraj";
            this.WybierzKraj.Size = new System.Drawing.Size(180, 28);
            this.WybierzKraj.TabIndex = 2;
            this.WybierzKraj.Text = "PL-Polska";
            this.WybierzKraj.SelectedIndexChanged += new System.EventHandler(this.WybierzKraj_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 148);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "6342709934";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(300, 394);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "6342709934";
            // 
            // WybierzKraj2
            // 
            this.WybierzKraj2.FormattingEnabled = true;
            this.WybierzKraj2.Items.AddRange(new object[] {
            "AT-Austria",
            "BE-Belgia",
            "BG-Bułgaria",
            "CY-Cypr",
            "CZ-Czechy",
            "DE-Niemcy",
            "DK-Dania",
            "EE-Estonia",
            "EL-Grecja",
            "ES-Hiszpania",
            "FI-Finlandia",
            "FR - Francja",
            "GB-Wielka Brytania",
            "HR-Chorwacja",
            "HU-Węgry",
            "IE-Irlandia",
            "IT-Włochy",
            "LT-Litwa",
            "LU-Luksemburg",
            "LV-Łotwa",
            "MT-Malta",
            "NL-Holandia",
            "PL-Polska",
            "PT-Portugalia",
            "RO-Rumunia",
            "SE-Szwecja",
            "SI-Słowenia",
            "SK-Słowacja"});
            this.WybierzKraj2.Location = new System.Drawing.Point(300, 306);
            this.WybierzKraj2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WybierzKraj2.Name = "WybierzKraj2";
            this.WybierzKraj2.Size = new System.Drawing.Size(180, 28);
            this.WybierzKraj2.TabIndex = 6;
            this.WybierzKraj2.Text = "PL-Polska";
            this.WybierzKraj2.SelectedIndexChanged += new System.EventHandler(this.WybierzKraj2_SelectedIndexChanged);
            // 
            // NumerVAT2
            // 
            this.NumerVAT2.AutoSize = true;
            this.NumerVAT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerVAT2.Location = new System.Drawing.Point(39, 394);
            this.NumerVAT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumerVAT2.Name = "NumerVAT2";
            this.NumerVAT2.Size = new System.Drawing.Size(91, 20);
            this.NumerVAT2.TabIndex = 5;
            this.NumerVAT2.Text = "Numer VAT";
            // 
            // PanstwoCzlonkowskiePytajacego
            // 
            this.PanstwoCzlonkowskiePytajacego.AutoSize = true;
            this.PanstwoCzlonkowskiePytajacego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanstwoCzlonkowskiePytajacego.Location = new System.Drawing.Point(39, 308);
            this.PanstwoCzlonkowskiePytajacego.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PanstwoCzlonkowskiePytajacego.Name = "PanstwoCzlonkowskiePytajacego";
            this.PanstwoCzlonkowskiePytajacego.Size = new System.Drawing.Size(168, 40);
            this.PanstwoCzlonkowskiePytajacego.TabIndex = 4;
            this.PanstwoCzlonkowskiePytajacego.Text = "Państwo członkowskie\r\npytającego";
            // 
            // WeryfikujButton
            // 
            this.WeryfikujButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeryfikujButton.Location = new System.Drawing.Point(313, 525);
            this.WeryfikujButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeryfikujButton.Name = "WeryfikujButton";
            this.WeryfikujButton.Size = new System.Drawing.Size(178, 62);
            this.WeryfikujButton.TabIndex = 8;
            this.WeryfikujButton.Text = "Weryfikuj";
            this.WeryfikujButton.UseVisualStyleBackColor = true;
            this.WeryfikujButton.Click += new System.EventHandler(this.WeryfikujButton_Click);
            // 
            // krajSkrot
            // 
            this.krajSkrot.AutoSize = true;
            this.krajSkrot.Location = new System.Drawing.Point(300, 127);
            this.krajSkrot.Name = "krajSkrot";
            this.krajSkrot.Size = new System.Drawing.Size(28, 20);
            this.krajSkrot.TabIndex = 9;
            this.krajSkrot.Text = "PL";
            // 
            // krajSkrot2
            // 
            this.krajSkrot2.AutoSize = true;
            this.krajSkrot2.Location = new System.Drawing.Point(300, 369);
            this.krajSkrot2.Name = "krajSkrot2";
            this.krajSkrot2.Size = new System.Drawing.Size(28, 20);
            this.krajSkrot2.TabIndex = 10;
            this.krajSkrot2.Text = "PL";
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Location = new System.Drawing.Point(843, 72);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(0, 20);
            this.labelValid.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(847, 298);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 12;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(850, 344);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(0, 20);
            this.labelAdress.TabIndex = 13;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(850, 405);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 20);
            this.labelID.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(641, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Walidacja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nazwa:";
            // 
            // ZapiszButton
            // 
            this.ZapiszButton.Location = new System.Drawing.Point(675, 525);
            this.ZapiszButton.Name = "ZapiszButton";
            this.ZapiszButton.Size = new System.Drawing.Size(178, 62);
            this.ZapiszButton.TabIndex = 17;
            this.ZapiszButton.Text = "Zapisz";
            this.ZapiszButton.UseVisualStyleBackColor = true;
            this.ZapiszButton.Click += new System.EventHandler(this.ZapiszButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Adres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Identyfikator zapytania:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(639, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Państwo członkowskie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Numer VAT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(641, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Data:";
            // 
            // labelPanstwoCzlonkowskie
            // 
            this.labelPanstwoCzlonkowskie.AutoSize = true;
            this.labelPanstwoCzlonkowskie.Location = new System.Drawing.Point(843, 137);
            this.labelPanstwoCzlonkowskie.Name = "labelPanstwoCzlonkowskie";
            this.labelPanstwoCzlonkowskie.Size = new System.Drawing.Size(0, 20);
            this.labelPanstwoCzlonkowskie.TabIndex = 23;
            // 
            // labelNumer
            // 
            this.labelNumer.AutoSize = true;
            this.labelNumer.Location = new System.Drawing.Point(847, 191);
            this.labelNumer.Name = "labelNumer";
            this.labelNumer.Size = new System.Drawing.Size(0, 20);
            this.labelNumer.TabIndex = 24;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(847, 248);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 20);
            this.labelData.TabIndex = 25;
            // 
            // Potwierdzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelNumer);
            this.Controls.Add(this.labelPanstwoCzlonkowskie);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ZapiszButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.krajSkrot2);
            this.Controls.Add(this.krajSkrot);
            this.Controls.Add(this.WeryfikujButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.WybierzKraj2);
            this.Controls.Add(this.NumerVAT2);
            this.Controls.Add(this.PanstwoCzlonkowskiePytajacego);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.WybierzKraj);
            this.Controls.Add(this.NumerVAT);
            this.Controls.Add(this.PanstwoCzlonkowskie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Potwierdzenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Potwierdzenie numeru VAT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PanstwoCzlonkowskie;
        private System.Windows.Forms.Label NumerVAT;
        private System.Windows.Forms.ComboBox WybierzKraj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox WybierzKraj2;
        private System.Windows.Forms.Label NumerVAT2;
        private System.Windows.Forms.Label PanstwoCzlonkowskiePytajacego;
        private System.Windows.Forms.Button WeryfikujButton;
        private System.Windows.Forms.Label krajSkrot;
        private System.Windows.Forms.Label krajSkrot2;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ZapiszButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelPanstwoCzlonkowskie;
        private System.Windows.Forms.Label labelNumer;
        private System.Windows.Forms.Label labelData;
    }
}

