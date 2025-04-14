using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Lab10_Partie1
{
    public class Cours
    {
        string nom;
        List<Etudiant> etudiants;
        public Cours(string nom)
        {
            this.nom = nom;
            etudiants = new List<Etudiant>();
        }


        public double CalculerMoyenne()
        {
            double resultat = 0;
            double nombreEtudiants = 0;
            foreach(Etudiant etudiant in etudiants)
            {
                nombreEtudiants++;
                resultat += etudiant.CalculerMoyenne();
            }
            resultat = resultat / nombreEtudiants;
            return resultat;
        }


        public void AjouterEtudiant(Etudiant etudiant)
        {
            etudiants.Add(etudiant);
        }


        public bool ValiderPresenceEtudiant(string nom)
        {
            bool valid = false;
            foreach (Etudiant etudiant in etudiants)
            {
                if(etudiant.Nom == nom)
                {
                    valid = true;
                }               
            }
            return valid;
        }
    }
}
