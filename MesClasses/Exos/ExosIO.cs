using MesClasses.Personnes;
using MyClasses.Autres;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using static System.Console;

namespace MesClasses.Exos
{
    public static class ExosIO
    {
        public static void ExoIO01()  //Sérialiser et désérialiser une liste de personnes dans un fichier
        {
            using (var stream = new FileStream("personne.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Personne>));
                xmlSerializer.Serialize(stream, SampleDatas.GetSamplePersonnes());
            }

            using (var stream = new FileStream("personne.xml", FileMode.Open, FileAccess.Read))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Personne>));
                var personnes = xmlSerializer.Deserialize(stream) as List<Personne>;

                foreach (var p in personnes) WriteLine(p);
            }
        }

        public static void ExoIO02() => ExtraireInfo(new DirectoryInfo(@"e:\test"), '-');

        static void ExtraireInfo(DirectoryInfo dir, char separateur, int niveau = 0)
        {
            var fileAttributes = new EnumerationOptions();
            fileAttributes.AttributesToSkip = (FileAttributes)2;
            try
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine(Separateur(separateur, niveau) + dir.Name);
                foreach (var dirFils in dir.GetDirectories("*", fileAttributes))
                {
                    ExtraireInfo(dirFils, separateur, ++niveau);
                    --niveau;
                }
                ForegroundColor = ConsoleColor.Blue;
                foreach (var file in dir.GetFiles()) WriteLine(Separateur(separateur, niveau + 1) + file.Name);
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
            }
            ForegroundColor = ConsoleColor.White;
        }

        static string Separateur(char separateur = '.', int niveau = 0)
        {
            var sep = "";
            for (int i = 0; i < niveau; i++) sep += separateur;
            return sep;
        }
    }
}
