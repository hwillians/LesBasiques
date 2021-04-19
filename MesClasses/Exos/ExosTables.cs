using MesClasses.Personnes;
using System;
using System.Collections.Generic;
using static MyClasses.Autres.SampleDatas;
using static System.Console;

namespace MesClasses.Exos
{
    class ExosTables
    {
        public static void ExoT01()
        {
            int[] tabInt = new int[] { 8, 25, 2, 6, 3, 0, 10, 15, -5 };
            foreach (var item in tabInt) Write(item + " ");
            WriteLine();

            Array.Sort(tabInt);
            foreach (var item in tabInt) Write(item + " ");
            WriteLine();
        }

        public static void ExoT02()
        {
            List<string> liste = new List<string> { "casa", "arbol", "rio", "lago", "cielo", "avion", "terreno" };
            foreach (var item in liste) Write(item + ", ");
            WriteLine();

            liste.Sort();
            foreach (var item in liste) Write(item + ", ");
            WriteLine();
        }

        public static void ExoT03()
        {

            foreach (var p in GetSamplePersonnes()) WriteLine(p.ToString());
            WriteLine();

            GetSamplePersonnes().Sort();
            foreach (var item in GetSamplePersonnes()) Write(item + ", ");
            WriteLine();
        }

        public static void ExoT04()
        {
            Dictionary<int, Personne> personnes = new Dictionary<int, Personne> {
                {1, new Personne("Detal", "Fulano", new DateTime(1900, 04, 14)) },
                {2, new Personne("Rodriguez", "Zutano", new DateTime(1800, 04, 14)) },
                {3, new Employe("Gonzales", "Perensejo", new DateTime(1900, 04, 14), 2000) },
                {4,  new Employe("Perez", "Pedro", new DateTime(1800, 04, 14), 5000) },
            };
            foreach (var p in personnes) WriteLine(p.ToString());
        }

        public static void ExoT05()
        {
            if (GetSamplePersonnes().Contains(new Personne("Rodriguez", "Zutano", new DateTime(1800, 04, 14))))
            {
                WriteLine("La liste contiene cette personne");
            }
            else WriteLine("La liste ne contiene pas cette personne");
        }

        public static void ExoT06()
        {
            GetSamplePersonnes().Sort();
            foreach (var p in GetSamplePersonnes()) WriteLine(p);
            WriteLine();

            GetSamplePersonnes().Sort(new ComparatuerPersonnes());
            foreach (var p in GetSamplePersonnes()) WriteLine(p);
            WriteLine();
        }
    }
}
