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

                foreach (var item in personnes) Console.WriteLine(item);
            }
        }

        public static void ExoIO02()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"e:\");
            var fileAttributes = new EnumerationOptions();
            fileAttributes.AttributesToSkip = (FileAttributes)2;
            var niveau = 0;
            var etape = 0;
            Console.WriteLine(niveau + directoryInfo.Name);

            ExtraireInfo(directoryInfo);

            void ExtraireInfo(DirectoryInfo dir, int letape = 0)
            {
                //foreach (var item in DirectoryInfo.GetFiles()) Console.WriteLine("f : " + item.Name);
            }
        }
    }
}
