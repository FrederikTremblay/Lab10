using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie3
{

    public class Usine
    {
        public string Nom {  get; set; }
        public Usine() 
        {
            Nom = "usine";
        }

        public Robot CreerRobot(TypeRobot type)
        {
            if (type == TypeRobot.constructeur) 
            {
                Robot robot = new RobotConstructeur(AjouterPiece());
                return robot;
            }
            else if (type == TypeRobot.repareur)
            {
                Robot robot = new RobotReparateur(AjouterPiece());
                return robot;
            }
            else
            {
                Robot robot = new RobotDestructeur(AjouterPiece());
                return robot;
            }

        }
        public Piece[] AjouterPiece()
        {
            Piece[] tabPieces = new Piece[3] { new Piece(), new Piece(), new Piece()};

            return tabPieces;
        }


        public override string ToString()
        {
            return $"{Nom} ";
        }
    }
}
