using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie1
{
    public class Etudiant
    {
        public string Nom { get; set; }
        double noteMath;
        double noteGeo;
        double noteFrancais;
        double noteAnglais;
        public Etudiant(string nom, double noteMath, double noteGeo, double noteFrancais, double noteAnglais)
        {
            Nom = nom;
            this.noteMath = noteMath;
            this.noteGeo = noteGeo;
            this.noteFrancais = noteFrancais;
            this.noteAnglais = noteAnglais;
        }

        public double CalculerMoyenne()
        {
            double moyenne = (noteMath  + noteGeo + noteFrancais + noteAnglais)/4;
            return moyenne;
        }

        public bool EstEnVoieDeReussite()
        {
            bool reussite = false;
            double moyenne = CalculerMoyenne();
            if (moyenne >= 60)
            {
                reussite = true;
            }
            else
                reussite = false;
            return reussite;
        }
    }
}
