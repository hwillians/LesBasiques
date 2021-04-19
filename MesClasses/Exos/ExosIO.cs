using MesClasses.Personnes;
using MyClasses.Autres;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MesClasses.Exos
{

    public static class ExosIO
    {
        //Sérialiser et désérialiser une liste de personnes dans un fichier
        public static void ExoIO01()
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

                foreach (var p in personnes) Console.WriteLine(p);
            }
        }

        public static void ExoIO02() => ExtraireInfo(new DirectoryInfo(@"e:\test"), '-');

        static void ExtraireInfo(DirectoryInfo dir, char separateur, int niveau = 0)
        {
            var fileAttributes = new EnumerationOptions();
            fileAttributes.AttributesToSkip = (FileAttributes)2;
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Separateur(separateur, niveau) + dir.Name);
                foreach (var dirFils in dir.GetDirectories("*", fileAttributes))
                {
                    ExtraireInfo(dirFils, separateur, ++niveau);
                    --niveau;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (var file in dir.GetFiles()) Console.WriteLine(Separateur(separateur, niveau + 1) + file.Name);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        static string Separateur(char separateur = '.', int niveau = 0)
        {
            var sep = "";
            for (int i = 0; i < niveau; i++) sep += separateur;
            return sep;
        }
    }
}
