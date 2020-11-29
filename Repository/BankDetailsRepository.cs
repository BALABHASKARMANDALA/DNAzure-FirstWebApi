using BankEnquiryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankEnquiryService.Repository
{
    public class BankDetailsRepository : IBankDetailsRepository
    {
        static List<BankDetails> bankdetails = new List<BankDetails>()
        {
            new BankDetails{UserId = 1, AccountNo = 201 , UserName = "abc", Balance = 25000},
            new BankDetails{UserId = 2, AccountNo = 202 , UserName = "xyz", Balance = 35000},
            new BankDetails{UserId = 3, AccountNo = 203 , UserName = "pqr", Balance = 30000},
        };

        public IEnumerable<BankDetails> GetAll()
        {
            return bankdetails;
        }
        public BankDetails GetAccountDetails(int userid)
        {
            return bankdetails.FirstOrDefault(b => b.UserId == userid);
        }
    }
}
