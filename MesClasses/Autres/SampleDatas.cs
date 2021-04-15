using MesClasses;
using MesClasses.Personnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.Autres
{
    public static class SampleDatas
    {
        public static List<Personne> GetSamplePersonnes()
        {
            List<Personne> personnes = new();

            var random = new Random();

            personnes.Add(new Personne("Roche", "Charlotte", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Michel", "Nathan", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Lacroix MD", "Quentin", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Dufour", "Louis", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Dumas", "Clémence", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Clara", "Vincent", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Carla", "Huet", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Maëlle", "Blanchard", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Justine", "Brun", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Noémie", "Fournier", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Jean", "Dupond", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Pierre", "Dupont", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Jacques", "Dupou", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Thierry", "Dapont", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Jean", "Bille", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Thomas", "Artoh", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Romain", "Dupont", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Dufour", "Charlotte", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Roche", "Huet", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));

            return personnes;
        }
    }
}
