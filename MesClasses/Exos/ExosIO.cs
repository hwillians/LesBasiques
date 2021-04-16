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

            using (var stream = new FileStream("personne.xml",FileMode.Open,FileAccess.Read))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Personne>));
                var personnes = xmlSerializer.Deserialize(stream) as List<Personne>;

                foreach (var item in personnes) Console.WriteLine(item);
            }
        }

    }
}
