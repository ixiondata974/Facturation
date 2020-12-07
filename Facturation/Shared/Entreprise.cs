using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Entreprise : Contractants
    {
        private int siret;
        private int tel;
        public Entreprise(string nom, string adresse, string ville, int cp, int Siret, int Tel):base(nom,adresse,ville,cp)
        {
            this.siret = Siret;
            this.tel = Tel;
        }

        public int getSiret()
        {
            return this.siret;
        }
        public int getTel()
        {
            return this.tel;
        }
    }
}
