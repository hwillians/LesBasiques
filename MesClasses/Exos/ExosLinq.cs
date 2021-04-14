using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static MyClasses.Autres.SampleDatas;

namespace MesClasses.Exos
{
    static class ExosLinq
    {
        //        Sur une liste d’entier :
        static List<int> liste = new List<int> { 8, 25, 2, 6, 3, 0, 10, 15, -5 };

        //1. Afficher la somme
        public static void ExoL01()
        {
            WriteLine(liste.Sum());
        }

        //2. Afficher la moyenne
        public static void ExoL02()
        {
            WriteLine(liste.Average());
        }
        //3. Sélectionner que les nombres qui sont > 6
        public static void ExoL03()
        {
            WriteLine(string.Join("\n", liste.Where(i => i > 6)));
        }

        //4. Compter le nombre d’élément
        public static void ExoL04()
        {
            WriteLine(liste.Count());
        }
        //5. Les trier avec la méthode OrderBy par le nom puis le prénom
        public static void ExoL05()
        {
            WriteLine(String.Join("\n", GetSamplePersonnes().OrderBy(p => p.Nom).ThenBy(p => p.Prenom)));
        }
        //6. Afficher que les personnes qui ont leurs noms qui commence par D
        public static void ExoL06() => WriteLine(String.Join("\n", GetSamplePersonnes().Where(p => p.Nom[0] == 'D')));

        //7. Afficher que les noms des personnes
        public static void ExoL07() => WriteLine(String.Join("\n", GetSamplePersonnes().Select(p => p.Nom)));

        //8. Afficher le nom en majuscule et le prénom des personnes trié par ordre descendant sur le prénom dont leurs noms commence par D
        public static void ExoL08()
        {
            var list = GetSamplePersonnes().Where(p => p.Nom[0] == 'D')
                  .OrderByDescending(p => p.Prenom)
                  .Select(p => new { Nom = p.Nom.ToUpper(), Prenom = p.Prenom });

            foreach (var item in list)
            {
                WriteLine(item.Nom + " " + item.Prenom);

            }
        }

        //9. Récupérer que les 2 première personne

        //10. Récupérer les personnes rentrées en 7ème 8ème et 9ème position

        //11. Récupérer la personne qui a le nom Dupont

        //12. Savoir si notre liste contient une personne dont le nom commence par D

        //13. Regrouper les personnes par leurs prénoms

    }

}
