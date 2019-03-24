using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladiste.Model
{
    public class Proizvodi
    {
        private int id;
        private int id_kategorije;
        private string naziv_p;
        private int kolicina;
        private float cijena;

        public Proizvodi(int id, int id_kategorije, string naziv_p, int kolicina, float cijena)
        {
            Id = id;
            Id_kategorije = id_kategorije;
            Naziv_p = naziv_p;
            Kolicina = kolicina;
            Cijena = cijena;
        }

        public int Id { get; set; }
        public int Id_kategorije { get; set; }
        public string Naziv_p { get; set; }
        public int Kolicina { get; set; }
        public float Cijena { get; set; }
    }
}
