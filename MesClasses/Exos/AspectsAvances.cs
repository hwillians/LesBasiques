using MesClasses.Avances;
using System;
using static MesClasses.Avances.Exercice;
using static System.Console;
using static MesClasses.Autres.Outils;


namespace MesClasses.Exos
{
    class AspectsAvances
    {
        public static void ExoA01() => WriteLine(new MyPair<string, int>("string", 10)); //Généricité

        public static void ExoA02()
        {
            TypeDelegueString stringDel;
            Welcome();
            stringDel = new TypeDelegueString(Welcome);
            stringDel();

            TypeDelegueDoubles doubleDel;
            doubleDel = Add;
            WriteLine(doubleDel(12.5, 5.12));
        }

        #region ActionRegion
        public static void ExoA03() => DoSomething(s => WriteLine(s));

        public static void DoSomething(Action<string> callBack) => callBack(GetString("Tapez un text : ")); 
        #endregion

        [Obsolete("use ExoA01", false)]
        public static void ExoA04() => WriteLine("Test de l’attribut : [System.Obsolete(\"use NewMethod\", true)]");
    }
}
