using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class ListCommande
    {
        private String designation;
        private int quantite;
        private int prix_unit_HT;

        public ListCommande(String Design, int Quantite, int Prix)
        {
            this.designation = Design;
            this.quantite = Quantite;
            this.prix_unit_HT = Prix;
        }

        public String Designation => designation;
        public int Quantite => quantite;
        public int Prix_HT => prix_unit_HT;
    }
}
