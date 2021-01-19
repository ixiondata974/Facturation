using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IBusinessData
    {
        IEnumerable<Facture> les_factures { get; }

        decimal CA { get; }
    }
}
