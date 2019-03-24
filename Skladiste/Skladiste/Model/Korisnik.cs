using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladiste.Model
{
    public class Korisnik
        {
        private string username;
        private string password;

        public Korisnik (string username, string password)
        {
            Username = username;
            Password = password; 
        }

        public string Username { get; set; }
        public string Password { get; set; }

        }
}
