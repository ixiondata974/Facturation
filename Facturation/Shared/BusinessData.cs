using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class BusinessData
    {
        private Entreprise monEntreprise = new Entreprise("Toto", "21 rue Tartanpion", "Bordeaux", 33000, 54484661, 06785194);

        /*private Entreprise monEntreprise = new Entreprise("Gakuen", "21 rue Tartanpion", "Bordeaux", 33000, 54484661, 06785194);

        private Client unClient = new Client("Tata", "33 rue des fesses", "St-Pierre", 97410);
        private Client unClient2 = new Client("Titi", "32 rue des fesses", "St-Pierre", 97410);
        private Client unClient3 = new Client("Tonton", "31 rue des fesses", "St-Pierre", 97410);
        private Client unClient4 = new Client("Tutu", "30 rue des fesses", "St-Pierre", 97410);
        private List<ListCommande> uneList = new List<ListCommande>();

        public List<Facture> les_factures = new List<Facture>();
        public BusinessData()
        {
            insert();
            insertFact();
        }
        
        

        private void insert()
        {
            uneList.Add(new ListCommande("Livre", 20, 15));
            uneList.Add(new ListCommande("Jeu", 20, 15));
            uneList.Add(new ListCommande("BD", 20, 15));
        }
        
        private void insertFact()
        {
            les_factures.Add(new Facture(monEntreprise,unClient,uneList,new DateTime(), new DateTime()));
            les_factures.Add(new Facture(monEntreprise, unClient2, uneList, new DateTime(), new DateTime()));
            les_factures.Add(new Facture(monEntreprise, unClient3, uneList, new DateTime(), new DateTime()));
            les_factures.Add(new Facture(monEntreprise, unClient4, uneList, new DateTime(), new DateTime()));
        }*/

        public List<Facture> les_factures = new List<Facture>();
        public BusinessData()
        {
            les_factures.Add(new Facture(1, "Tata", "Logiciel1", 500, new DateTime(2021, 3, 19)));
            les_factures.Add(new Facture(2, "Tata", "Logiciel2", 550, new DateTime(2021, 3, 20)));
            les_factures.Add(new Facture(3, "Tata", "Logiciel3", 300, new DateTime(2021, 3, 21)));
        }
    }
}
