using MesClasses.Eleves;
using MesClasses.Exceptions;
using System;
using static MesClasses.Autres.Outils;
using static System.Console;

namespace MesClasses.Exos
{
    public static class ExosExceptions
    {
        // 7. Gérer la division par 0 par un try catch
        public static void ExoE01()
        {
            int n1, n2;
            DeuxNombres(out n1, out n2);
            try
            {
                WriteLine(n1 / n2);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }

        public static void ExoE02()
        {
            try
            {
                WriteLine(new Eleve(GetString("Tapez le nom de l'élève : "), GetInt("Tapez son âge : "), GetInt("Tapez sa moyenne : ")));
            }
            catch (InvalidAgeException e)
            {
                WriteLine(e.Message);
            }
            catch (InvalidNoteException e)
            {
                WriteLine(e.Message);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
