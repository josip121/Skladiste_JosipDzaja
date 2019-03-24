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
    public partial class FormObrisi : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\skladiste_baza.mdb");

        int idZaBrisanje = 0;
        int kolicina = 0;
        int razlika = 0;

        public FormObrisi(int idZaBrisanje, int kolicina)
        {
            this.idZaBrisanje = idZaBrisanje;
            this.kolicina = kolicina;
            InitializeComponent();
        }

    

        private void obrisiUnesenuKolicinuBtn_Click(object sender, EventArgs e)
        {
            razlika = this.kolicina - int.Parse(textBox1.Text);

            if(razlika < 0)
            {
                MessageBox.Show("Nedopušteno");
                razlika = 0;
            }
            else
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE proizvodi SET kolicina = @1 WHERE id = @2", con);
                cmd.Parameters.AddWithValue("@1", razlika);
                cmd.Parameters.AddWithValue("@2", this.idZaBrisanje);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Uspješno obrisana količina proizvoda");
                this.Close();
            }
            
        }

        private void obrisiCijeliProizvodBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM proizvodi WHERE id = @1", con);
            cmd.Parameters.AddWithValue("@1", this.idZaBrisanje);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Uspješno obrisan proizvod");
            this.Close();

        }
    }
}
