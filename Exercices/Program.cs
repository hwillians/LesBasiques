using MesClasses;
using static MesClasses.LesBasiques.outils;
using System;
using MesClasses.LesBasiques;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {

              Menu.Liste();

            /*     Personne personne1 = new Personne(
                      GetString("Tapez le nom : "),
                      GetString("Tapez le Prenom : "),
                      StringToDate());
                 Personne personne2 = personne1;
                 Console.WriteLine(personne1);
                 Console.WriteLine(personne2);

                 personne1.MajPrenom();

                 Console.WriteLine(personne1);
                 Console.WriteLine(personne2);
                 Console.WriteLine(Personne.Test);*/

            Personne[] tabPersonnes = new Personne[4];
            tabPersonnes[0] = new Personne("Detal", "Fulano", new DateTime(1900, 04, 14));
            tabPersonnes[1] = new Personne("Rodriguez", "Zutano", new DateTime(1800, 04, 14));
            tabPersonnes[2] = new Employe("Gonzales", "Perensejo", new DateTime(1900, 04, 14), 2000);
            tabPersonnes[3] = new Employe("Perez", "Pedro", new DateTime(1800, 04, 14), 5000);

            foreach (var personne in tabPersonnes) Console.WriteLine(personne.Afficher());

            ITravailleur[] tabTravailleurs = new ITravailleur[4];
            tabTravailleurs[0] = tabPersonnes[0];
            tabTravailleurs[1] = tabPersonnes[1];
            tabTravailleurs[2] = tabPersonnes[2];
            tabTravailleurs[3] = tabPersonnes[3];

            foreach (var travailleur in tabTravailleurs) Console.WriteLine(travailleur.Afficher());
        }
    }
}

