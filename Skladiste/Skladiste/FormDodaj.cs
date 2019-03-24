using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste
{
    public partial class FormDodaj : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\skladiste_baza.mdb");

       
        public FormDodaj()
        {
            InitializeComponent();
        }

        private void FormDodaj_Load(object sender, EventArgs e)
        {
            this.proizvodiTableAdapter.Fill(this.skladiste_bazaDataSet.proizvodi);
            this.kategorije_proizvodaTableAdapter.Fill(this.skladiste_bazaDataSet2.kategorije_proizvoda);
            comboBoxKategorija.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void buttonDodajProizvod_Click(object sender, EventArgs e)
        {
            String kategorija = "nema kategorije";
            String proizvod = "nema proizvoda";
            int kolicina = 0;
            float cijena = 0;

            kategorija = comboBoxKategorija.Text.ToString();
            proizvod = textBoxNazivProizvoda.Text.ToString();
            kolicina = int.Parse(textBoxKolicina.Text);
            cijena = float.Parse(textBoxCijena.Text);
            
            con.Open();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO proizvodi (naziv, kolicina, cijena, id_kategorije) SELECT @1, @2, @3, id FROM kategorije_proizvoda WHERE naziv = @4", con);
            cmd.Parameters.AddWithValue("@1", proizvod);
            cmd.Parameters.AddWithValue("@2", kolicina);
            cmd.Parameters.AddWithValue("@3", cijena);
            cmd.Parameters.AddWithValue("@4", kategorija);
            cmd.ExecuteNonQuery();

            con.Close();
            
            MessageBox.Show("Uspješno dodan proizvod!");

            this.Close();
        }
    }
}
