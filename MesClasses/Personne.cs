using System;
using static MesClasses.LesBasiques.outils;

namespace MesClasses
{
    public class Personne : ITravailleur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public static string Test { get; } = "Ceci est un test";

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            Prenom = prenom;
            Nom = nom;
            DateNaissance = dateNaissance;
        }

        public void MajPrenom() => Prenom = Prenom.ToUpper();

        public override string ToString()
        {
            return $"{Prenom} {Nom.ToUpper()} ({DateNaissance.ToString("dd/MM/yyyy")})";
        }

        public virtual string Afficher()
        {
            return $"Prenom : {Prenom}, Nom : {Nom}, Date de Naissance : {DateNaissance.ToString("dd/MM/yyyy")}";
        }
    }
}
