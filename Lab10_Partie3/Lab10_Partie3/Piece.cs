using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie3
{
    public class Piece
    {
        string Nom { get; set; }
        public Piece(string nom, int puissance)
        {
            Nom = nom;
        }
        public Piece() 
        {
            Nom = "piece";
        }

        public override string ToString()
        {
            return $"{Nom}";
        }
    }
}
