using MesClasses.Personnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MesClasses.Autres.Outils;

namespace MesClasses.Exos
{
    class ExosClasses
    {
        //31. Créez une classe Personne qui comporte trois propriétés, nom, prénom et date de naissance
        static public void Exo31() => Console.WriteLine("Classe Personne comporte trois propriétés, nom, prénom et date de naissance");
        

        //32. Ecrivez une méthode « MajPrenom » dans la classe Personne qui écrase l’ancien prénom par le prénom en majuscule
        static public void Exo32() => Console.WriteLine(" Méthode « MajPrenom » ceéée dans la classe Personne, elle écrase l’ancien prénom par le prénom en majuscule");


        //33. Dans votre programme créez une personne avec des valeurs rentrées par l’utilisateur, appelez la méthode créée précédemment et afficher la personne en console
        static public void Exo33()
        {
            Personne personne1 = new Personne(GetString("Tapez le Prenom : "), GetString("Tapez le nom : "), StringToDate());
            Console.WriteLine(personne1);

            personne1.MajPrenom();
            Console.WriteLine("\n-.-.-.-.-.-.-.-.-.-\n");
            Console.WriteLine(personne1);
        }
        //34. Créez 1 Personne, l’affecter à une autre variable Personne, les afficher, appeler la méthode MajPrenom sur la première personne et les réafficher.Que ce passe-t-il au niveau des prénoms?
        static public void Exo34()
        {
            Personne personne1 = new Personne(GetString("Tapez le Prenom : "), GetString("Tapez le nom : "), StringToDate());
            Personne personne2 = personne1;

            Console.WriteLine(personne1);
            Console.WriteLine(personne2);

            personne1.MajPrenom();

            Console.WriteLine("\n-.-.-.-.-.-.-.-.-.-\n");
            Console.WriteLine(personne1);
            Console.WriteLine(personne2);

        }
        //35. Créez une propriété statique Test dans la classe Personne avec une valeur par défaut et l’afficher
        static public void Exo35() => Console.WriteLine(Personne.Test);

        // 36 L’héritage, le polymorphisme et les interfaces
        static public void Exo36()
        {
            Personne[] tabPersonnes = new Personne[4];
            tabPersonnes[0] = new Personne("Fulano", "Detal", new DateTime(1900, 04, 14));
            tabPersonnes[1] = new Personne("Zutano", "Rodriguez", new DateTime(1800, 04, 14));
            tabPersonnes[2] = new Employe("Perensejo", "Gonzales", new DateTime(1900, 04, 14), 2000);
            tabPersonnes[3] = new Employe("Pedro", "Perez", new DateTime(1800, 04, 14), 5000);

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
