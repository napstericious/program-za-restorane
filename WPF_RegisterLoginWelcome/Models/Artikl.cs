using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_RegisterLoginWelcome.Models
{
    public class Artikl
    {
        public int IDArtikla { get; set; }
        public int IDArtiklaPodmenija { get; set; }
        public string ImeArtikla { get; set; }
        public double CenaArtikla { get; set; }
        public string PutanjaSlikeArtikla { get; set; }
        public string KategorijaArtikla { get; set; }

    }
}
