using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Facturation.Shared;

namespace Facturation.Server.Models
{
    public class BusinessDataSQL : IBusinessData, IDisposable
    {
        private SqlConnection SqlConn;
        public BusinessDataSQL(string connexion)
        {
            SqlConn = new SqlConnection(connexion);
        }
        public void Dispose()
        {
            SqlConn.Dispose();
        }
        public IEnumerable<Facture> les_factures
            => SqlConn.Query<Facture>("SELECT * FROM Facture ORDER BY LivrableDate DESC");

        public decimal CA => SqlConn.QueryFirst<decimal>("SELECT SUM(TotalTTC) FROM Facture");
    }
}
