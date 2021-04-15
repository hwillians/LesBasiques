using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MesClasses.Autres.Outils;

namespace MesClasses.Exos
{
    public static class ExosExceptions
    {
        // 7. Gérer la division par 0 par un try catch
       public  static void ExoE01()
        {
            int n1, n2;
            DeuxNombres(out n1,out n2);

            try
            {
                Console.WriteLine(n1 / n2);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }



//8. Créer une classe Élèves caractérisée par nom, âge et moyenne.
    }
}
