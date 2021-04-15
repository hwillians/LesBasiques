using MesClasses.Exceptions;

namespace MesClasses.Eleves
{
    class Eleve
    {               
        public string Nom { get; set; }
        private int age;
        private double moyenne;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 26) age = value;
                else throw new InvalidAgeException("L'age doit etre entre 18 et 26");
            }
        }

        public double Moyenne
        {
            get { return moyenne; }
            set
            {
                if (value >= 0 && value <= 20) moyenne = value;
                else throw new InvalidNoteException("La moyenne doit être entre 0 y 20");
            }
        }

        public Eleve(string nom, int age, double moyenne)
        {
            Nom = nom;
            Age = age;
            Moyenne = moyenne;
        }

        public override string ToString()
        {
            return $"{Nom}, age : {Age}, moyenne : {Moyenne}";
        }
    }
}
