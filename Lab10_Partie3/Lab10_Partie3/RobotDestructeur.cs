using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie3
{
    public class RobotDestructeur :Robot
    {

        public RobotDestructeur(Piece[] tabPiece) : base(TypeRobot.destructeur, tabPiece) 
        {         
        }
        public override void Specialite(Batiment batiment)
        {
            batiment.Priorite = 5;
            batiment.QuantiteRessource = 5;
            batiment.StatutBatiment = Statut.necessiteReparation;
            Console.WriteLine("BOOM");
        }
    }
}
