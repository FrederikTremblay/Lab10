using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie3
{
    public class RobotReparateur : Robot
    {
        public int QuantiteRessource { get; set; }
        Piece[] tabPiece;
        public RobotReparateur(Piece[] tabPiece) : base(TypeRobot.repareur, tabPiece)
        {
            this.tabPiece = tabPiece;
        }
        public override void Specialite(Batiment batiment)
        {
            if(batiment.QuantiteRessource <= QuantiteRessource)
            {
                QuantiteRessource = QuantiteRessource - batiment.QuantiteRessource;
                batiment.Priorite = 1;
                batiment.QuantiteRessource = 0;
                batiment.StatutBatiment = Statut.parfait;
                Console.WriteLine($"Le batiment est repare");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas assez de materiaux");
            }

        }

    }
}
