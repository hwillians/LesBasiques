using MesClasses;
using static MesClasses.LesBasiques.outils;
using System;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Menu.Liste();
            Personne personne1 = new Personne
            {
                Prenom = GetString("Tapez le prenom : "),
                Nom = GetString("Tapez le nom : "),
                DateNaissance = StringToDate()
            };

            Personne personne2 = personne1;
            Console.WriteLine(personne1);
            Console.WriteLine(personne2);


            personne1.MajPrenom();

            Console.WriteLine(personne1);
            Console.WriteLine(personne2);

            Console.WriteLine(Personne.Test);
        }




    }
}

