using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

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
    }

}
