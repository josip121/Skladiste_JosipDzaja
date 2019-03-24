namespace Skladiste
{
    partial class FormStanjeSkladista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStanjeSkladista));
            this.labelPretrazivanje = new System.Windows.Forms.Label();
            this.labelKategorija = new System.Windows.Forms.Label();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.kategorijeproizvodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladiste_bazaDataSet2 = new Skladiste.skladiste_bazaDataSet2();
            this.skladiste_bazaDataSet = new Skladiste.skladiste_bazaDataSet();
            this.skladistebazaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorije_proizvodaTableAdapter = new Skladiste.skladiste_bazaDataSet2TableAdapters.kategorije_proizvodaTableAdapter();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodiTableAdapter = new Skladiste.skladiste_bazaDataSetTableAdapters.proizvodiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonIzlaz = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeproizvodaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiste_bazaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiste_bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladistebazaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPretrazivanje
            // 
            this.labelPretrazivanje.AutoSize = true;
            this.labelPretrazivanje.Location = new System.Drawing.Point(309, 56);
            this.labelPretrazivanje.Name = "labelPretrazivanje";
            this.labelPretrazivanje.Size = new System.Drawing.Size(65, 17);
            this.labelPretrazivanje.TabIndex = 3;
            this.labelPretrazivanje.Text = "Skladište";
            // 
            // labelKategorija
            // 
            this.labelKategorija.AutoSize = true;
            this.labelKategorija.Location = new System.Drawing.Point(49, 196);
            this.labelKategorija.Name = "labelKategorija";
            this.labelKategorija.Size = new System.Drawing.Size(76, 17);
            this.labelKategorija.TabIndex = 4;
            this.labelKategorija.Text = "Kategorija:";
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.DataSource = this.kategorijeproizvodaBindingSource;
            this.comboBoxKategorija.DisplayMember = "naziv";
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(52, 215);
            this.comboBoxKategorija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(176, 24);
            this.comboBoxKategorija.TabIndex = 5;
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
            // skladiste_bazaDataSet
            // 
            this.skladiste_bazaDataSet.DataSetName = "skladiste_bazaDataSet";
            this.skladiste_bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladistebazaDataSetBindingSource
            // 
            this.skladistebazaDataSetBindingSource.DataSource = this.skladiste_bazaDataSet;
            this.skladistebazaDataSetBindingSource.Position = 0;
            // 
            // kategorije_proizvodaTableAdapter
            // 
            this.kategorije_proizvodaTableAdapter.ClearBeforeFill = true;
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(82, 243);
            this.buttonPretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(104, 46);
            this.buttonPretrazi.TabIndex = 6;
            this.buttonPretrazi.Text = "Pretraži";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataMember = "proizvodi";
            this.proizvodiBindingSource.DataSource = this.skladistebazaDataSetBindingSource;
            // 
            // proizvodiTableAdapter
            // 
            this.proizvodiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proizvodiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(312, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 539);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 140;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena ( kn )";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Width = 120;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(50, 461);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(178, 46);
            this.buttonDodaj.TabIndex = 8;
            this.buttonDodaj.Text = "DODAJ PROIZVOD";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(50, 511);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(178, 46);
            this.buttonObrisi.TabIndex = 9;
            this.buttonObrisi.Text = "OBRIŠI PROIZVOD";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonIzlaz
            // 
            this.buttonIzlaz.Location = new System.Drawing.Point(48, 580);
            this.buttonIzlaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIzlaz.Name = "buttonIzlaz";
            this.buttonIzlaz.Size = new System.Drawing.Size(178, 46);
            this.buttonIzlaz.TabIndex = 10;
            this.buttonIzlaz.Text = "IZLAZ";
            this.buttonIzlaz.UseVisualStyleBackColor = true;
            this.buttonIzlaz.Click += new System.EventHandler(this.buttonIzlaz_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(951, 87);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(104, 46);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Osvježi";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 138);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormStanjeSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 718);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonIzlaz);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.labelKategorija);
            this.Controls.Add(this.labelPretrazivanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStanjeSkladista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stanje skladišta";
            this.Load += new System.EventHandler(this.FormStanjeSkladista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeproizvodaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiste_bazaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiste_bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladistebazaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPretrazivanje;
        private System.Windows.Forms.Label labelKategorija;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private skladiste_bazaDataSet skladiste_bazaDataSet;
        private System.Windows.Forms.BindingSource skladistebazaDataSetBindingSource;
        private skladiste_bazaDataSet2 skladiste_bazaDataSet2;
        private System.Windows.Forms.BindingSource kategorijeproizvodaBindingSource;
        private skladiste_bazaDataSet2TableAdapters.kategorije_proizvodaTableAdapter kategorije_proizvodaTableAdapter;
        private System.Windows.Forms.Button buttonPretrazi;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
        private skladiste_bazaDataSetTableAdapters.proizvodiTableAdapter proizvodiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonIzlaz;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
    }
}

