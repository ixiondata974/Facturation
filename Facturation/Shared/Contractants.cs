using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Contractants
    {
        private string Nom_société;
        private string Adresse_société;
        private string Ville_société;
        private int Cp_société;
        public Contractants(string nom, string adresse, string ville, int cp)
        {
            this.Nom_société = nom;
            this.Adresse_société = adresse;
            this.Ville_société = ville;
            this.Cp_société = cp;
        }

        public string getNom()
        {
            return this.Nom_société;
        }
        public string getAdresse()
        {
            return this.Adresse_société;
        }
        public string getVille()
        {
            return this.Ville_société;
        }
        public int getCp()
        {
            return this.Cp_société;
        }
    }
}
