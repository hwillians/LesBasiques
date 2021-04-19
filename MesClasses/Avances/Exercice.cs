using System;

namespace MesClasses.Avances
{

    class Exercice
    {
        public delegate void TypeDelegueString();

        public delegate double TypeDelegueDoubles(double d1, double d2);
        public static void Welcome() => Console.WriteLine("Un texte sur la console");

        public static double Add(double d1, double d2) => d1 + d2;
        //  public static void Add(double d1, double d2) => Console.WriteLine(d1 + d2);
    }
}
