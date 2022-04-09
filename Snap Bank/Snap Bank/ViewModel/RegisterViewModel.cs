using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snap_Bank.ViewModel
{
    public class RegisterViewModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public String Email { get; set; }
        public String Phone { get; set; }
        public Decimal SortCode { get; set; }
        public String AccountType { get; set; }
        public Decimal AccountNumber { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }
        public Decimal Pin { get; set; }
    }
}