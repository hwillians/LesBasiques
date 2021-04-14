﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
   public class Employe : Personne
    {
        public double Salaire { get; set; }
        public Employe(string nom, string prenom, DateTime dateNaissance, double salaire) : base(nom, prenom, dateNaissance)
        {
            Salaire = salaire;
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom.ToUpper()}, ${Salaire} ({DateNaissance.ToString("dd/MM/yyyy")})";
        }

        public override string Afficher()
        {
            return $"Prenom : {Prenom}, Nom : {Nom}, Date de Naissance : {DateNaissance.ToString("dd/MM/yyyy")}, Salaire : {Salaire}";
        }
    }
}