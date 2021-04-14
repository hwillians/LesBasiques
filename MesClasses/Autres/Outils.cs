using System;


namespace MesClasses.Autres
{
    public static class Outils
    {
        public static void DeuxNombres(out int nombre1, out int nombre2)
        {
            Console.WriteLine("Rentrez deux nombres SVP");
            nombre1 = GetInt("Première valeur : ");
            nombre2 = GetInt("Deuxième valeur : ");
        }

        public static DateTime StringToDate()
        {
            DateTime date;
            var saisi = GetString("Tapez une date : ");
            while (!DateTime.TryParse(saisi, out date)) saisi = GetString("La saisie n'est pas valide : ");
            return date;
        }

        public static int GetInt(string question = "valeur : ", int min = int.MinValue, int max = int.MaxValue)
        {
            int unEntier;
            var valeur = GetString(question);
            while (!int.TryParse(valeur, out unEntier) || !(unEntier >= min && unEntier <= max))
            {
                valeur = GetString("La saisie n'est pas valide.\n" + question);
            }
            return unEntier;
        }

        public static string GetString(string question = "Valeur : ")
        {
            Console.Write(question);
            string reponse = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(reponse))
            {
                Console.WriteLine("La saisie n'est pas valide");
                reponse = Console.ReadLine();
            }
            return reponse;
        }
    }
}