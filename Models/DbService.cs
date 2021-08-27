using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Dapper;

namespace FullStackTest.Models
{
    public interface IDbService
    {
        void AddLoans(List<LoanFileRecord> loans);
        IList<LoanDto> GetLoans();

    }
    
    public class DbService : IDbService
    {
        private SqlConnection _con;
        
        public DbService(SqlConnection con)
        {
            _con = con;
        }

        public void AddLoans(List<LoanFileRecord> loans)
        {
            string sql = $@"
                INSERT INTO Loans 
                (LoanNumber, OriginationDate, OriginalLoanAmount, EffectiveDate, Principal, TotalLoanCommitment, 
                    InterestRate, MaturityDate, AccruedInterest, Escrow) 
                VALUES (@LoanNumber, @OriginationDate, @OriginalLoanAmount, @EffectiveDate, @PrincipalBalance, 
                        @CommitmentAmount, @InterestRate, @MaturityDate, @AccruedInterest, @EscrowBalance)";

            foreach (var item in loans)
            {
                _con.Execute(sql, item);
            }
        }

        public IList<LoanDto> GetLoans()
        {
            return _con.Query<LoanDto>(@$"SELECT * FROM Loans").ToList();
        }
    }

}