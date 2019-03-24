using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladiste.Model
{
    public class KategorijaProizvoda
    {
        private int id;
        private string naziv;

        public KategorijaProizvoda(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
