using System.Reflection.Metadata;
using Lab10_Partie3;
namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void TestEnvoieRessource()
        {
            Montreal montreal = new Montreal();
            Robot robotEnvoie = montreal.usine.CreerRobot(TypeRobot.constructeur);
            Piece[] tabPiece = new Piece[3] { new Piece(),new Piece(), new Piece()};
            RobotReparateur robotRecoit = new RobotReparateur(tabPiece);
            robotEnvoie.Specialite((RobotReparateur)robotRecoit);
            int reponseVoulu = 5;
            int reponseObtenue = robotRecoit.QuantiteRessource;
            Assert.Equal(reponseVoulu, reponseObtenue);
        }
    }
}