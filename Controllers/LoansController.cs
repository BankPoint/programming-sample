using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using FullStackTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStackTest.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class LoansController : ControllerBase
    {
        private IDbService _dbService;
        
        public LoansController(IDbService dbService)
        {
            _dbService = dbService;
        }
        
        [HttpGet]
        public IList<LoanDto> GetLoans()
        {
            var loans = _dbService.GetLoans();
            return loans;
        }
        
        [HttpPost]
        public IActionResult UploadLoans(IFormFile loanfile)
        {
            using (var reader = new StreamReader(loanfile.OpenReadStream()))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var loans = csv.GetRecords<LoanFileRecord>().ToList();
                _dbService.AddLoans(loans);
                return Ok($"Successfully uploaded {loans.Count} loans");
            }
        }
    }
}