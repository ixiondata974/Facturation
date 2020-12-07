using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Client : Contractants
    {
        public Client(string nom, string adresse, string ville, int cp) : base(nom, adresse, ville, cp) { }
    }
}
