using System;
using static MesClasses.Autres.Outils;
using static System.Console;

namespace MesClasses.Exos
{
    public static class ExosBasiques
    {
        public static void Exo1() => WriteLine("Hello\nWorld!");

        public static void Exo2() => WriteLine("2 fonctions ont été créées, une pour récupérer l’entrée utilisateur en chaine de caractère et l’autre pour récupérer un entier.");

        public static void Exo3() //Faites rentrez 3 mots à l’utilisateur et afficher les dans l’ordre inverse de la saisie
        {
            WriteLine("Rentrez 3 mots SVP");
            string reponse = "";

            for (int i = 0; i < 3; i++) reponse = GetString($"{i + 1}._ ") + " " + reponse;
            WriteLine($"Vouz avez saisi : {reponse}");
        }

        public static void Exo4() //Affichez si les 2 nombres rentré par l’utilisateur sont égaux
        {
            DeuxNombres(out int nombre1, out int nombre2);
            WriteLine(nombre2 == nombre1 ? "Les deux nombres rentrés sont égaux"
                : "les deux nombres rentrés sont différents");
        }

        public static void Exo5() //Créez 2 nombres, les afficher, les intervertir et les réafficher
        {
            DeuxNombres(out int nombre1, out int nombre2);
            WriteLine($"{nombre1} - {nombre2}\n{nombre2} - {nombre1}");
        }

        /*6. Affichez le résultat de l’ajout, la soustraction, la multiplication et la division de 2 nombres
        rentrés par l’utilisateur*/
        public static void Exo6()
        {
            DeuxNombres(out int nombre1, out int nombre2);
            WriteLine($"Adition = {nombre1 + nombre2} \n" +
                $"Soustraction = {nombre1 - nombre2} \n" +
                $"Multiplication = {nombre1 * nombre2} \n" +
                $"Division = {(nombre2 == 0 ? "Erreur ! : Division par Zero" : (decimal)nombre1 / nombre2)} ");
        }

        //7. Affichez la moyenne de 4 nombres rentrés par l’utilisateur
        public static void Exo7(int n = 4)
        {
            decimal add = 0;

            WriteLine($"Tapez {n} nombres pour calculer la moyenne");

            for (int i = 0; i < n; i++) add += GetInt($"{1 + i}._ ");

            WriteLine($"La moyenne est : {add / n}");
        }


        public static void Exo8(int n = 4) //Affichez le nombre le plus grand de 4 nombres rentrés par l’utilisateur
        {
            int temoin = int.MinValue;
            WriteLine($"Tapez {n} nombres SVP");

            for (int i = 0; i < n; i++)
            {
                int nombre = GetInt($"{1 + i}._ ");
                if (nombre > temoin) temoin = nombre;
            }
            WriteLine($"Le plus grand de {n} nombres est : {temoin}");
        }

        public static void Exo9() //Savoir si le nombre rentré est négatif ou positif
        {
            var nombre = GetInt("Tapez un nombre : ");

            WriteLine(nombre >= 0 ? (nombre == 0 ? "0" : "Ce nombre est positif")
                : "Ce nombre est negatif");
        }
        //10. Savoir si le nombre donné est pair ou impair
        public static void Exo10() => WriteLine(GetInt("Tapez un nombre : ") % 2 == 0 ? "Ce nombre est pair" : "Ce nombre est impair");

        public static void Exo11()  // Rentrez un nombre en Celsius et le convertir en Kelvin et Fahrenheit
        {
            var celsius = GetInt("Tapez la temperature en Celsius : ");

            WriteLine("{0}°C equivaut à {1}°K et à {2}°F", celsius, celsius + 273.15, 9 * (double)celsius / 5 + 32);
        }

        public static void Exo12() // Rentrez un chiffre et dire de quel jour il s’agit sous forme de texte
        {
            var day = GetInt("Trouver le jour de la semaine \nTapez un chifffre : ");
            string dayOfWeek = "";

            switch (day)
            {
                case 1: dayOfWeek = "Lundi"; break;
                case 2: dayOfWeek = "Mardi"; break;
                case 3: dayOfWeek = "Mercredi"; break;
                case 4: dayOfWeek = "Jeudi"; break;
                case 5: dayOfWeek = "Vendredi"; break;
                case 6: dayOfWeek = "Samedi"; break;
                case 7: dayOfWeek = "Dimanche"; break;
                default: WriteLine("Aucun jour de la semaine corresponde à cette chiffre"); break;
            }
            WriteLine(dayOfWeek);
        }

        public static void Exo13(string mdp = "password") // Bloquez un utilisateur après avoir rentré 3 faux password
        {
            var temoin = 0;
            for (int i = 0; i < 3; i++)
            {
                var password = GetString("Rentrez votre mot de passe SVP : ");
                if (mdp != password)
                {
                    WriteLine("Mot de passe incorrect");
                    temoin++;
                }
                else break;
            }
            WriteLine(temoin < 3 ? "Bienvenue" : "Vous êtez bloqué");
        }

        public static void Exo14() // Rentrez un nombre, puis un signe(+ - * /), puis un autre nombre, affichez ensuite le résultat
        {
            var nombre1 = GetInt("Première valeur : ");
            var opp = GetString("Choisisez une operation (+ - * /) : ");
            while (opp != "+" && opp != "-" && opp != "*" && opp != "/")
                opp = GetString("Cette operation n'est pas reconnue, choisisez une operation (+ - * /) : ");

            var nombre2 = GetInt("Deuxième valeur : ");
            var resultat = 0.0;

            switch (opp)
            {
                case "+": resultat = nombre1 + nombre2; break;
                case "-": resultat = nombre1 - nombre2; break;
                case "*": resultat = nombre1 * nombre2; break;
                case "/": resultat = (double)nombre1 / nombre2; break;
            }
            WriteLine(nombre2 == 0 && opp == "/" ? "Erreur ! : Division par Zero"
                : $"Le resultat de votre operation est : {resultat}");
        }

        public static void Exo15() // Afficher les 10 premiers chiffres à partir de 0 (avec une boucle for)
        {
            for (int i = 0; i < 10; i++) WriteLine(i);
        }

        public static void Exo16() // Donnez la table de multiplication des 10 premiers chiffres
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++) WriteLine($"{i} x {j} = {i * j}");
        }

        public static void Exo17() // Afficher une lettre sous forme de triangle d'une taille definie par l'utilisateur
        {
            var lettre = GetString("Tapez un lettre : ");
            var taille = GetInt("Definisez la taille du triangle : ");
            for (int i = 0; i < taille; i++)
            {
                string ligne = "";
                int tailleLigne = 0;
                while (tailleLigne <= i)
                {
                    ligne += lettre;
                    tailleLigne++;
                }
                WriteLine(ligne);
            }
        }

        public static void Exo18() //Faire une pyramide d’une hauteur donnée
        {
            var lettre = GetString("Tapez un lettre : ") + " ";
            var taille = GetInt("Definisez la taille : ");
            for (int i = 0; i < taille; i++)
            {
                string tab = "", ligne = "";
                int tailleTab = 0, tailleLigne = 0;
                while (tailleTab < (taille - i))
                {
                    tab += " ";
                    tailleTab++;
                }

                while (tailleLigne <= i)
                {
                    ligne += lettre;
                    tailleLigne++;
                }
                WriteLine(tab + ligne);
            }
        }

        public static void Exo19()   // Faire un diamant d’une hauteur donnée
        {
            var lettre = GetString("Tapez un lettre : ") + " ";
            var length = GetInt("Definisez la taille : ");
            for (int i = 0; i < length * 2 - 1; i++)
            {
                string tab = "", ligne = "";
                int tailleTab = 0, tailleLigne = 0;

                if (i < length)
                {
                    while (tailleTab < (length - (i + 1)))
                    {
                        tab += " ";
                        tailleTab++;
                    }
                    while (tailleLigne <= i)
                    {
                        ligne += lettre;
                        tailleLigne++;
                    }
                }
                else
                {
                    while (tailleTab <= i - length)
                    {
                        tab += " ";
                        tailleTab++;
                    }
                    while (tailleLigne < 2 * length - (i + 1))
                    {
                        ligne += lettre;
                        tailleLigne++;
                    }
                }
                WriteLine(tab + ligne);
            }
        }
        //20. Créez la date d’aujourd’hui et affichez-la de façon complète puis de façon jour/mois/année)
        public static void Exo20() => WriteLine($"{DateTime.Now}\n{DateTime.Now.ToString("dd/MM/yyyy")}");

        /*21. Créer une date avec l’utilisateur qui rentre l’année, mois, jour, heure, minute et seconde et
            afficher le jour(Lundi, mardi...) | en français ou en anglais*/
        public static void Exo21()
        {
            var annee = GetInt("Tapez l'année : ");
            var mois = GetInt("Tapez le mois : ");
            var jour = GetInt("Tapez le jour : ");
            var heure = GetInt("Tapez l'heure : ");
            var minute = GetInt("Tapez la minute : ");
            var seconde = GetInt("Tapez le seconde : ");

            var date = new DateTime(annee, mois, jour, heure, minute, seconde);
            WriteLine(date.DayOfWeek);
        }

        public static void Exo22() //Affichez la différence de temps entre 2 dates
        {
            var date = new DateTime(1986, 01, 14);
            WriteLine($"{(DateTime.Now - date).TotalDays} jours de difference");
        }

        //Convertir une chaine de caractère en date
        public static void Exo23() => WriteLine(StringToDate());


        public static void Exo24() //Jeu du plus ou moins
        {
            Random rnd = new();
            int nombreDefinit = rnd.Next(100);
            int nombre = GetInt("Devinez le nombre (entre 0 et 99): ");

            while (nombre != nombreDefinit) nombre = GetInt(nombre < nombreDefinit ? "C'est plus : " : "C'est moins : ");
            WriteLine($"Vouz avez deviné le nombre : {nombre}.");
        }

        //Affichez une chaine donnée en majuscule
        public static void Exo25() => WriteLine(GetString("Tapez : ").ToUpper());

        public static void Exo26()  // Affichez le nombre de caractère d’une chaine sans utiliser la propriété Length
        {
            int val = 0;
            foreach (var item in GetString()) val++;
            WriteLine(val);
        }

        public static void Exo27() //Affichez un espace entre toute les lettres d’une chaine de caractère donnée en inversant les lettres
        {
            var chaine = "";
            foreach (var item in GetString()) chaine = item + " " + chaine;
            WriteLine(chaine.ToUpper());
        }

        // Dire si une chaine est égale à une autre sans prendre en compte la casse
        public static void Exo28() => WriteLine(string.Compare(GetString("Premier text : "), GetString("Deuxieme text : "), true) == 0 ?
                "Les text sont égaux" : "Le text sont différents");


        public static void Exo29() //Savoir si la chaine donnée est un palindrome(mot qui se lit dans les deux sens : SOS)
        {
            var mot = GetString().ToLower();
            var motInv = "";
            foreach (var lettre in mot) motInv = lettre + motInv;
            WriteLine(mot + " " + (motInv == mot ? "est un palindrome" : " n'est pas un palindrome"));
        }

        /*Lister les nombres de 1 à 100, en remplaçant le nombre par un mot selon certaines
        conditions. Un retour à la ligne tous les 9 éléments*/
        public static void Exo30()
        {
            var tableau = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var item = i * 10 + j + 1;
                    var text = "";
                    if (item % 3 == 0 && item % 5 == 0) text = "FizzBuzz"; //Le mot FizzBuzz s'il est multiple de 3 et de 5
                    else if (item % 3 == 0) text = "Fizz"; //Le mot Fizz s'il est multiple de 3
                    else if (item % 5 == 0) text = "Buzz"; //Le mot Buzz s'il est multiple de 5
                    else text = item.ToString();
                    tableau[i, j] = text;
                }
            }
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    Write(tableau[i, j] + (j == 9 ? "\n" : " - "));
        }

        #region morpion 
        public static void Morpion()
        {
            var tablau = new string[3, 3];
            var essaie = 0;

            //Initialisation du tableau 
            for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) tablau[i, j] = " ";

            while (essaie < 9 && !winner(tablau))
            {
                var x = GetInt("Position en x (1-3) : ", 1, 3);
                var y = GetInt("Position en y (1-3) : ", 1, 3);
                if (tablau[x - 1, y - 1] == " ")
                {
                    tablau[x - 1, y - 1] = essaie % 2 == 0 ? "X" : "O";
                    essaie++;
                }
                // réécriture du tableau
                for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) Write(tablau[i, j] + (j == 2 ? "\n" : "|"));
                if (winner(tablau))
                {
                    WriteLine("Nous avons un gagneur !");
                    break;
                }
            }
            if (!winner(tablau)) WriteLine("Meilleur chance la prochaine fois !");
        }

        static bool winner(string[,] board)
        {
            //  les diagonales
            if (board[1, 1] != " " && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return true;
            if (board[1, 1] != " " && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;

            for (int x = 0; x < 3; x++) //  les lignes
                if (board[x, 0] != " " && board[x, 0] == board[x, 1] && board[x, 0] == board[x, 2]) return true;

            for (int y = 0; y < 3; y++)  //  les colones
                if (board[0, y] != " " && board[0, y] == board[1, y] && board[0, y] == board[2, y]) return true;

            return false;
        }
        #endregion
    }
}