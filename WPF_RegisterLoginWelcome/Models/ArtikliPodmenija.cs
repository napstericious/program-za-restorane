using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_RegisterLoginWelcome.Models
{
    class ArtikliPodmenija
    {
        public int IDArtiklaPodmenija { get; set; }
        public int IDKategorije { get; set; }
        public string ImeArtiklaPodmenija { get; set; }
        public string PutanjaSlikeArtiklaPodmenija { get; set; }

        public override string ToString()
        {
            return $"{ImeArtiklaPodmenija}";
        }
    }
}
