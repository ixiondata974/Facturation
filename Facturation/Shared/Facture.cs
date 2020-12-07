using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Facture
    {
        private Entreprise notre_entreprise;
        private Client ceClient;
        private List<ListCommande> listCommandes;
        private DateTime date_de_facture;
        private DateTime date_de_livraison;
        private static int id = 0;
        public Facture(Entreprise Notre, Client unClient, List<ListCommande> uneListCommandes, DateTime date_Fact, DateTime date_livr)
        {
            Id = id++;
            this.notre_entreprise = Notre;
            this.ceClient = unClient;
            this.listCommandes = uneListCommandes;
            this.date_de_facture = date_Fact;
            this.date_de_livraison = date_livr;
        }

        public int Id { get; }

        public Entreprise GetEntreprise()
        {
            return this.notre_entreprise;
        }
        public Client GetClient()
        {
            return this.ceClient;
        }

        public DateTime getFactDate()
        {
            return this.date_de_facture;
        }
        public DateTime getLivrDate()
        {
            return this.date_de_livraison;
        }

        public List<ListCommande> GetLists()
        {
            return this.listCommandes;
        }

        public int getTotal_HT()
        {
            int tot = 0;
            foreach (var prix in this.listCommandes)
            {
                tot += prix.getPrix_HT();
            }
            return tot;
        }

        public int getTotal()
        {
            return getTotal_HT() + getTotal_HT() % 20;
        }
    }
}
