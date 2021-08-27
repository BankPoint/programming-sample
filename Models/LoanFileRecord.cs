using System;

namespace FullStackTest.Models
{
    public class LoanFileRecord
    {
        public DateTime EffectiveDate { get; set; }
        public string LoanNumber { get; set; }
        public string CustomerName { get; set; }
        public string AccountTypeDescription { get; set; }
        public decimal PrincipalBalance { get; set; }
        public DateTime OriginationDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public decimal? OriginalLoanAmount { get; set; }
        public decimal? CommitmentAmount { get; set; }
        public int? Late30Days { get; set; }
        public int? Late60Days { get; set; }
        public int? Late90Days { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? AccruedInterest { get; set; }
        public string RateTypeIndexDescription { get; set; }
        public decimal? RateMargin { get; set; }
        public decimal? EscrowBalance { get; set; }
        public string BranchCode { get; set; }
        public string BranchDescription { get; set; }
    }
}