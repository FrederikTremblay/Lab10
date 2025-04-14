using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie3
{
    public class Robot
    {
        Piece[] tabPiece;
        TypeRobot Type {get; set;}

        public Robot(TypeRobot type,Piece[] tabPiece)
        {
            this.tabPiece = tabPiece;
            Type = type;
            
        }
        public Robot()
        {
            tabPiece = new Piece[3];
            Type = TypeRobot.constructeur;
        }

        public virtual void Specialite(Batiment batiment)
        {

        }
        public virtual void Specialite(RobotReparateur robot)
        {

        }
    }
    public enum TypeRobot
    {
        constructeur = 0,
        repareur = 1,
        destructeur = 2
    };
}
