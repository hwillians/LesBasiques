using System;
using static MesClasses.Autres.Outils;
using static MesClasses.Exos.ExosBasiques;
using static MesClasses.Exos.ExosClasses;
using static MesClasses.Exos.ExosExceptions;
using static MesClasses.Exos.ExosIO;
using static MesClasses.Exos.ExosLinq;
using static MesClasses.Exos.ExosTables;
using static MesClasses.Exos.AspectsAvances;

namespace MesClasses
{
    public static class Menu
    {
        public static void Selection()
        {
            var exercices = "";
            while (exercices != "00")
            {
                exercices = GetString($"Choisisez le numéro de l'exercices : " +
                    $"\nde 1 à 36 pour les basiques et les calsses" +
                    $"\nDe t01 à t06 pour les tables" +
                    $"\nDe l01 à l13 pour linq" +
                    $"\nDe e01 à e02 pour les exceptions" +
                    $"\nDe io01 à io02 pour IO" +
                    $"\nDe a01 à a04 pour les aspects avancés" +
                    $"\n300 morpion" +
                    $"\n(00 por sortir) : ");
                switch (exercices.ToLower())
                {
                    case "1": Exo1(); break;
                    case "2": Exo2(); break;
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
                    case "31": Exo31(); break;
                    case "32": Exo32(); break;
                    case "33": Exo33(); break;
                    case "34": Exo34(); break;
                    case "35": Exo35(); break;
                    case "36": Exo36(); break;
                    case "t01": ExoT01(); break;
                    case "t02": ExoT02(); break;
                    case "t03": ExoT03(); break;
                    case "t04": ExoT04(); break;
                    case "t05": ExoT05(); break;
                    case "t06": ExoT06(); break;
                    case "l01": ExoL01(); break;
                    case "l02": ExoL02(); break;
                    case "l03": ExoL03(); break;
                    case "l04": ExoL04(); break;
                    case "l05": ExoL05(); break;
                    case "l06": ExoL06(); break;
                    case "l07": ExoL07(); break;
                    case "l08": ExoL08(); break;
                    case "l09": ExoL09(); break;
                    case "l10": ExoL10(); break;
                    case "l11": ExoL11(); break;
                    case "l12": ExoL12(); break;
                    case "l13": ExoL13(); break;
                    case "e01": ExoE01(); break;
                    case "e02": ExoE02(); break;
                    case "io01": ExoIO01(); break;
                    case "io02": ExoIO02(); break;
                    case "a01": ExoA01(); break;
                    case "a02": ExoA02(); break;
                    case "a03": ExoA03(); break;
                    case "a04": ExoA04(); break;
                    case "300": Morpion(); break;
                    case "00": Console.WriteLine("à bientôt..."); break;
                    default: Console.WriteLine("Esseyez un autre exercices"); break;
                }
                Console.WriteLine();
            }
        }
    }
}