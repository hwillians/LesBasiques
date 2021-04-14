using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Personnes
{
    class ComparatuerPersonnes : IComparer<Personne>
    {
        public int Compare(Personne p1, Personne p2)
        {
            var comp = p1.Nom.CompareTo(p2.Nom);
            if (comp == 0) comp = p1.Prenom.CompareTo(p2.Prenom);
            if (comp == 0) comp = p1.DateNaissance.ToShortDateString().CompareTo(p2.DateNaissance.ToShortDateString());
            return comp;
        }
    }
}
