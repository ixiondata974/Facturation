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

        public String getDesignation()
        {
            return this.designation;
        }
        public int getQuantite()
        {
            return this.quantite;
        }
        public int getPrix_HT()
        {
            return this.prix_unit_HT;
        }
    }
}
