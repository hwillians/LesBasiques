using System;
using static MesClasses.LesBasiques.Exos;
using static MesClasses.LesBasiques.outils;


namespace MesClasses.LesBasiques
{
   public static class Menu
    {
               public static void Liste()
        {
            var exercices = "";
            while (exercices != "00")
            {
                exercices = GetString("Choisisez le numéro de l'exercices : (00 por sortir) : ");
                switch (exercices)
                {
                    case "1": Exo1(); break;
                    case "3": Exo3(); break;
                    case "4": Exo4(); break;
                    case "5": Exo5(); break;
                    case "6": Exo6(); break;
                    case "7": Exo7(); break;
                    case "8": Exo8(); break;
                    case "9": Exo9(); break;
                    case "10": Exo10(); break;
                    case "11": Exo11(); break;
                    case "12": Exo12(); break;
                    case "13": Exo13(); break;
                    case "14": Exo14(); break;
                    case "15": Exo15(); break;
                    case "16": Exo16(); break;
                    case "17": Exo17(); break;
                    case "18": Exo18(); break;
                    case "19": Exo19(); break;
                    case "20": Exo20(); break;
                    case "21": Exo21(); break;
                    case "22": Exo22(); break;
                    case "23": Exo23(); break;
                    case "24": Exo24(); break;
                    case "25": Exo25(); break;
                    case "26": Exo26(); break;
                    case "27": Exo27(); break;
                    case "28": Exo28(); break;
                    case "29": Exo29(); break;
                    case "30": Exo30(); break;
                    case "300": Morpion(); break;
                    case "00": Console.WriteLine("à bientôt..."); break;
                    default: Console.WriteLine("Esseyez un autre exercices"); break;
                }
            }
        }
    }
}