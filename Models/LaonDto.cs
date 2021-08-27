using System;

namespace FullStackTest.Models
{
    public class LoanDto
    {
        public string LoanNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Principal { get; set; }
        public DateTime MaturityDate { get; set; }
        public string BranchDescription { get; set; }
    }
}