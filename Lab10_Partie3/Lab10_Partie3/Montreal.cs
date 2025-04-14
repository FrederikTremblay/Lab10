using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie3
{
    public class Montreal
    {
        public List<Batiment> Batiments { get; set; }
        public List<Robot> Robots { get; set; }
        public Usine usine { get; set; }
        public Montreal()
        {
            Batiments = new List<Batiment>();
            usine = new Usine();
            Robots = new List<Robot>();
        }

        public void AjouterBatiment(Batiment batiment)
        {
            Batiments.Add(batiment);
        }
        public void AjouterRobot(Robot robot)
        {
            Robots.Add(robot);
        }
    }
}
