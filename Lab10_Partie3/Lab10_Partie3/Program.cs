namespace Lab10_Partie3
{
    //NOM : FREDERIK TREMBLAY
    //CODE REVIEW : MATIHEU POISSANT
    //DESCRIPTION: tentative de gestion de robot .
    public class Program
    {
        static void Main(string[] args)
        {

            GenererJeu();
        }
        static void GenererJeu()
        {
            Montreal montreal = GenererVille();
            while ( AfficherNombreTours(montreal) != true) 
            {
                int numeroBatiment = CalculerPrioriteBatiment(montreal.Batiments);
                ChoisirAction(montreal.Batiments[numeroBatiment], montreal);
                AfficherNombreTours(montreal);
            }

        }
        //genere la ville et ajoute les robots a la ville
        static Montreal GenererVille( )
        {
            Montreal montreal = new Montreal();
            List<Batiment> batiments= new List<Batiment>();
            batiments.Add(new Batiment(1,1,Statut.necessiteReparation,5,3));
            batiments.Add(new Batiment(1, 2, Statut.necessiteReparation, 5, 2));
            batiments.Add(new Batiment(1, 3, Statut.aDemolir, 5, 5));
            batiments.Add(new Batiment(1, 4, Statut.parfait, 5, 1));
            batiments.Add(new Batiment(1, 1, Statut.necessiteReparation, 5, 4));
            foreach (Batiment batiment in batiments)
            {
                montreal.AjouterBatiment(batiment);
            }
            montreal.AjouterRobot(montreal.usine.CreerRobot(TypeRobot.destructeur));
            montreal.AjouterRobot(montreal.usine.CreerRobot(TypeRobot.constructeur));
            montreal.AjouterRobot(montreal.usine.CreerRobot(TypeRobot.repareur));
            return montreal;
        }
        //calcule la priorite des batiments et renvoie le numero du batiment dans la liste
        static int CalculerPrioriteBatiment(List<Batiment> batiments)
        {
            int numeroBatimentPrioritaire = 0;
            int dernierBatiment = 0;
            int numeroBatiment = 0 ;
            foreach(Batiment batiment in batiments)
            {
                if(batiment.Priorite > dernierBatiment)
                {
                    numeroBatimentPrioritaire = numeroBatiment;
                    dernierBatiment = batiment.Priorite;
                }
                numeroBatiment++;
            }
            return numeroBatimentPrioritaire;
        }

        //choisit l'action en fonction du statut du batiment prioritaire
        static void ChoisirAction(Batiment batiment, Montreal montreal)
        {
            if(batiment.StatutBatiment == Statut.aDemolir)
            {
                montreal.Robots[0].Specialite(batiment);
            }
            else if (batiment.StatutBatiment == Statut.necessiteReparation)
            {
                montreal.Robots[1].Specialite((RobotReparateur)montreal.Robots[2]);
                montreal.Robots[2].Specialite(batiment);
            }
            else
            {
                montreal.Robots[2].Specialite(batiment);
            }
        }
        static bool AfficherNombreTours(Montreal montreal)
        {
            //suppose afficher le nombre de tours et renvoyer true(la ville est detruite ou construite) ou false
            int nombreDeTours = 0;
            bool detruitOuConstruit = true;
            foreach (Batiment batiment in montreal.Batiments)
            {
                if (batiment.StatutBatiment != Statut.parfait)
                {
                    detruitOuConstruit = false;
                    nombreDeTours ++;
                }

            }
            if (detruitOuConstruit == true)
            {
                Console.WriteLine(nombreDeTours);
            }
            return detruitOuConstruit;
        }
    }
}
