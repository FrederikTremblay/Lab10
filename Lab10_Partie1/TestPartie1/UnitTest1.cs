namespace TestPartie1
{
    using Lab10_Partie1;
    public class UnitTest1
    {
        [Fact]
        public void TestCalculMoyenneEtudiant()
        {
            Etudiant etudiant = new Etudiant("carl",59,87,12,22);
            double resultatAttendu = 45;

            double resultatObtenu = etudiant.CalculerMoyenne();

            Assert.Equal(resultatAttendu, resultatObtenu);
        }

        [Fact]
        public void TestEstEnVoieDeReussite()
        {
            Etudiant etudiant = new Etudiant("carl", 59, 87, 12, 22);
            bool resultatAttendu = false;

            bool resultatObtenu = etudiant.EstEnVoieDeReussite();

            Assert.Equal(resultatAttendu, resultatObtenu);
        }

        [Fact]
        public void TestMoyenneCours()
        {
           Cours monCours =  GenererCours();

            double resultatAttendu = 65.35;

            double ResultatObtenu = monCours.CalculerMoyenne();

            Assert.Equal(resultatAttendu, ResultatObtenu);

        }

        [Fact]
        public void TestPresenceEtudiant()
        {
            Cours monCours = GenererCours();

            bool resultatAttendu = true;

            bool resultatObtenu = monCours.ValiderPresenceEtudiant("Carlos");

            Assert.Equal(resultatAttendu, resultatObtenu);
        }
        public List<Etudiant> GenererEtudiants()
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            etudiants.Add(new Etudiant("Carlos", 100, 75, 60, 35));
            etudiants.Add(new Etudiant("Papi", 100, 54, 83, 76));
            etudiants.Add(new Etudiant("Chantale", 84, 55, 78, 78));
            etudiants.Add(new Etudiant("Brock", 48, 76, 60, 65));
            etudiants.Add(new Etudiant("Martin", 59, 87, 12, 22));
            return etudiants;
        }
        public Cours GenererCours()
        {
            Cours monCours = new Cours("cours1");
            List<Etudiant> etudiants = GenererEtudiants();
            foreach (Etudiant etudiant in etudiants)
            {
                monCours.AjouterEtudiant(etudiant);
            }

            return monCours;
        }
    }
}