using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_RegisterLoginWelcome
{
    public class Korisnik //Po default-u je interni accessibility klase, pa moramo naznaciti da bude public kako bi mogli pristupiti samoj klasi i listi objekata te klase
    {
        public int IDKorisnika { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }

        public string MailKorisnika { get; set; }
        public string UsernameKorisnika { get; set; }

        public string PasswordKorisnika { get; set; }

        // ****redosled parametara koji se prosledjuje konstruktoru mora biti isti kao i kada se poziva taj konstruktor negde****
        public Korisnik(int id, string ime, string prezime, string username, string mail, string password)
        {
            IDKorisnika = id;
            ImeKorisnika = ime;
            PrezimeKorisnika = prezime;
            UsernameKorisnika = username;
            PasswordKorisnika = password;
            MailKorisnika = mail;
        }

    }
}
