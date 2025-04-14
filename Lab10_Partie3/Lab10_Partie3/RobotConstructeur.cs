using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie3
{
    public class RobotConstructeur : Robot
    {

        public RobotConstructeur(Piece[] tabPiece) : base(TypeRobot.constructeur,tabPiece)
        {
        }
        public override void Specialite(RobotReparateur robot)
        {
            int quantiteRessource = 5;
            Console.WriteLine("le robot constructeur envoie le materiel au robot reparateur");
            robot.QuantiteRessource = quantiteRessource;
        }

    }
}
