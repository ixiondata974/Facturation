using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Contractants
    {
        private string nom;
        private string adresse;
        private string ville;
        private int cp;
        public Contractants(string nom, string adresse, string ville, int cp)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.ville = ville;
            this.cp = cp;
        }
        public string Nom => nom;
        public string Adresse => adresse;
        public string Ville => ville;
        public int Cp => cp;
    }
}
