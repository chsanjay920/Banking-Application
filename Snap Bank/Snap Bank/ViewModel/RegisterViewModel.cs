using Microsoft.OData.Edm;
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
        public Date DateOfBirth { get; set; }
        public String Gender { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public int SortCode1 { get; set; }
        public int SortCode2 { get; set; }
        public int SortCode3 { get; set; }
        public int CompleteSortCode { get; set; }
        public String AccountType { get; set; }
        public int AccountNumber { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }
        public int Pin { get; set; }
        public String SecurityQuestion1 { get; set; }
        public String SecurityQuestion2 { get; set; }
        public String SecurityQuestion3 { get; set; }
    }
    public enum AccountType
    {
        SavingsAccount,
        CurrentAccount
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}