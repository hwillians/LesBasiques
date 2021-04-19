using MesClasses.Eleves;
using MesClasses.Exceptions;
using System;
using static MesClasses.Autres.Outils;
using static System.Console;

namespace MesClasses.Exos
{
    public static class ExosExceptions
    {
        #region DivisionPar0
        public static double Diviser(int n1, int n2) => n1 / n2;


        public static void ExoE01()
        {
            DeuxNombres(out int n1, out int n2);
            try
            {
                WriteLine(n1 / n2);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
        #endregion

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
