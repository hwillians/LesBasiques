using System;

namespace MesClasses.Personnes

{
    public class Personne : ITravailleur, IEquatable<Personne>, IComparable<Personne>
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public static string Test { get; } = "Ceci est un test";

        public Personne() { }

        public Personne(string prenom, string nom, DateTime dateNaissance)
        {
            Prenom = prenom;
            Nom = nom;
            DateNaissance = dateNaissance;
        }

        public void MajPrenom() => Prenom = Prenom.ToUpper();

        public override string ToString() => $"{Prenom} {Nom} ({DateNaissance.ToString("dd/MM/yyyy")})";

        public virtual string Afficher() => $"Prenom : {Prenom}, Nom : {Nom}, Date de Naissance : {DateNaissance.ToString("dd/MM/yyyy")}";

        public bool Equals(Personne other) => other.Nom == Nom && other.Prenom == Prenom;

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (!(obj is Personne)) return false;
            if (Prenom == ((Personne)obj).Prenom
                && Nom == ((Personne)obj).Nom
                && DateNaissance.ToShortDateString() == ((Personne)obj).DateNaissance.ToShortDateString())
                return true;
            else return false;
        }

        public int CompareTo(Personne p) => Nom.CompareTo(p.Nom);

    }
}
