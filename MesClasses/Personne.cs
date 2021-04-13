using System;

namespace MesClasses
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public static string Test { get; set; } = "Ceci est un test";

        public void MajPrenom()
        {
            Prenom = Prenom.ToUpper();
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom} {DateNaissance.ToString("dd/MM/yyyy")}";
        }
    }
}
