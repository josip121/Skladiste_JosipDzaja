namespace Skladiste
{
    partial class FormDodaj
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodaj));
            this.labelPretrazivanje = new System.Windows.Forms.Label();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.kategorijeproizvodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladiste_bazaDataSet2 = new Skladiste.skladiste_bazaDataSet2();
            this.labelKategorija = new System.Windows.Forms.Label();
            this.kategorije_proizvodaTableAdapter = new Skladiste.skladiste_bazaDataSet2TableAdapters.kategorije_proizvodaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivProizvoda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDodajProizvod = new System.Windows.Forms.Button();
            this.skladiste_bazaDataSet = new Skladiste.skladiste_bazaDataSet();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodiTableAdapter = new Skladiste.skladiste_bazaDataSetTableAdapters.proizvodiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeproizvodaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiste_bazaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiste_bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPretrazivanje
            // 
            this.labelPretrazivanje.AutoSize = true;
            this.labelPretrazivanje.Location = new System.Drawing.Point(105, 69);
            this.labelPretrazivanje.Name = "labelPretrazivanje";
            this.labelPretrazivanje.Size = new System.Drawing.Size(142, 17);
            this.labelPretrazivanje.TabIndex = 4;
            this.labelPretrazivanje.Text = "Dodavanje proizvoda";
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.DataSource = this.kategorijeproizvodaBindingSource;
            this.comboBoxKategorija.DisplayMember = "naziv";
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(92, 139);
            this.comboBoxKategorija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(176, 24);
            this.comboBoxKategorija.TabIndex = 7;
            this.comboBoxKategorija.ValueMember = "naziv";
            // 
            // kategorijeproizvodaBindingSource
            // 
            this.kategorijeproizvodaBindingSource.DataMember = "kategorije_proizvoda";
            this.kategorijeproizvodaBindingSource.DataSource = this.skladiste_bazaDataSet2;
            // 
            // skladiste_bazaDataSet2
            // 
            this.skladiste_bazaDataSet2.DataSetName = "skladiste_bazaDataSet2";
            this.skladiste_bazaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelKategorija
            // 
            this.labelKategorija.AutoSize = true;
            this.labelKategorija.Location = new System.Drawing.Point(90, 120);
            this.labelKategorija.Name = "labelKategorija";
            this.labelKategorija.Size = new System.Drawing.Size(142, 17);
            this.labelKategorija.TabIndex = 6;
            this.labelKategorija.Text = "Kategorija proizvoda:";
            // 
            // kategorije_proizvodaTableAdapter
            // 
            this.kategorije_proizvodaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv proizvoda:";
            // 
            // textBoxNazivProizvoda
            // 
            this.textBoxNazivProizvoda.Location = new System.Drawing.Point(92, 215);
            this.textBoxNazivProizvoda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNazivProizvoda.Name = "textBoxNazivProizvoda";
            this.textBoxNazivProizvoda.Size = new System.Drawing.Size(176, 22);
            this.textBoxNazivProizvoda.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Količina:";
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(154, 262);
            this.textBoxKolicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(114, 22);
            this.textBoxKolicina.TabIndex = 11;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(154, 292);
            this.textBoxCijena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(114, 22);
            this.textBoxCijena.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cijena:";
            // 
            // buttonDodajProizvod
            // 
            this.buttonDodajProizvod.Location = new System.Drawing.Point(90, 359);
            this.buttonDodajProizvod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodajProizvod.Name = "buttonDodajProizvod";
            this.buttonDodajProizvod.Size = new System.Drawing.Size(178, 46);
            this.buttonDodajProizvod.TabIndex = 14;
            this.buttonDodajProizvod.Text = "DODAJ PROIZVOD";
            this.buttonDodajProizvod.UseVisualStyleBackColor = true;
            this.buttonDodajProizvod.Click += new System.EventHandler(this.buttonDodajProizvod_Click);
            // 
            // skladiste_bazaDataSet
            // 
            this.skladiste_bazaDataSet.DataSetName = "skladiste_bazaDataSet";
            this.skladiste_bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataMember = "proizvodi";
            this.proizvodiBindingSource.DataSource = this.skladiste_bazaDataSet;
            // 
            // proizvodiTableAdapter
            // 
            this.proizvodiTableAdapter.ClearBeforeFill = true;
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 471);
            this.Controls.Add(this.buttonDodajProizvod);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazivProizvoda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.labelKategorija);
            this.Controls.Add(this.labelPretrazivanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj proizvod";
            this.Load += new System.EventHandler(this.FormDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeproizvodaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiste_bazaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiste_bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPretrazivanje;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.Label labelKategorija;
        private skladiste_bazaDataSet2 skladiste_bazaDataSet2;
        private System.Windows.Forms.BindingSource kategorijeproizvodaBindingSource;
        private skladiste_bazaDataSet2TableAdapters.kategorije_proizvodaTableAdapter kategorije_proizvodaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivProizvoda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDodajProizvod;
        private skladiste_bazaDataSet skladiste_bazaDataSet;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
        private skladiste_bazaDataSetTableAdapters.proizvodiTableAdapter proizvodiTableAdapter;
    }
}