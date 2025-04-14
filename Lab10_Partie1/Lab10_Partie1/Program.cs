using Colorful;
using Humanizer;
using System.ComponentModel;
using System.Drawing;
using System.Text;
namespace Lab10_Partie1
{
    // NOM : FREDERIK TREMBLAY
    // CODE REVIEW: MATHIEU POISSANT
    //DESCRIPTION : TEST DES NUGETS ET 
    public class Program
    {
        static void Main(string[] args)
        {
            TestHumain();
            TestConsole();
        }

        static void TestHumain()
        {
            System.Console.WriteLine("voiture".Pluralize());
            int nombreFou = 123124;
            string motFou = nombreFou.ToWords();
            System.Console.WriteLine(motFou);
            string date = DateTime.Now.Humanize();
            System.Console.WriteLine(date);
            string phraseHumanize = "Je suis un jeunehomme".Transform(To.TitleCase);
            string phraseFolle = "Je Suis UN jeunehomme".Transform(To.LowerCase);
            System.Console.WriteLine(phraseHumanize);
            System.Console.WriteLine(phraseFolle);
        }
        static void TestConsole()
        {

            ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
            ColorAlternator alternator = alternatorFactory.GetAlternator(2, Color.Plum, Color.PaleVioletRed);

            for (int i = 0; i < 15; i++)
            {
                Colorful.Console.WriteLineAlternating("cats", alternator);
            }
        }
    }
}
