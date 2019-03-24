using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste
{
    public partial class FormLogin : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\skladiste_baza.mdb");
        Thread th;

        public FormLogin()
        { 

            InitializeComponent();
        }

        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT username, password FROM korisnik WHERE id = 1", con);

            OleDbDataReader reader = null;
            reader = cmd.ExecuteReader();

            String username = null;
            String password = null;

            while (reader.Read())
            {
                username = reader["username"].ToString();
                password = reader["password"].ToString();
            }

            con.Close();

            if (textBox1.Text == username && textBoxUser.Text == password)
            {
                this.Close();
                th = new Thread(openNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Neispravno ime ili lozinka!");
            }
        }

        private void openNewForm()
        {
            Application.Run(new FormStanjeSkladista());
        }
    }
}
