using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste
{
    public partial class FormStanjeSkladista : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\skladiste_baza.mdb");
        Thread th;
        int idZaBrisanje = 0;
        int kolicina = 0;

        public void refreshGrid()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM proizvodi", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error connection: " + e);
            }
            finally
            {
                con.Close();
            }
        }

        public FormStanjeSkladista()
        {
            InitializeComponent();
            comboBoxKategorija.DropDownStyle = ComboBoxStyle.DropDownList;
            refreshGrid();
        }

        private void FormStanjeSkladista_Load(object sender, EventArgs e)
        {
            this.proizvodiTableAdapter.Fill(this.skladiste_bazaDataSet.proizvodi);
            this.kategorije_proizvodaTableAdapter.Fill(this.skladiste_bazaDataSet2.kategorije_proizvoda);

        }

        private void comboBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            con.Open();
            String text = "svinjetina";
            
            text = comboBoxKategorija.Text.ToString();

            String query = String.Format("SELECT p.id, p.naziv, p.kolicina, cijena FROM proizvodi p INNER JOIN kategorije_proizvoda k on p.id_kategorije = k.id WHERE k.naziv = '{0}'", text);
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(query, con);
            DataSet dataSet2 = new DataSet();
            dataAdapter1.Fill(dataSet2);

            dataGridView1.DataSource = dataSet2.Tables[0];
            
            con.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm()
        {
            Application.Run(new FormDodaj());
        }

        private void buttonIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            th = new Thread(openDeleteForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openDeleteForm()
        {
            if (idZaBrisanje == 0)
            {
                MessageBox.Show("Odaberi proizvod za brisanje!");
            }
            else
            {
                Application.Run(new FormObrisi(idZaBrisanje, kolicina));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;

            if (indexRow >= 0)
            {
                idZaBrisanje = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                kolicina = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }
    }
}
