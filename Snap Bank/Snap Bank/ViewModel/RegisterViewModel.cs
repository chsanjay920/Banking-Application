using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int SortCode1 { get; set; }
        public int SortCode2 { get; set; }
        public int SortCode3 { get; set; }
        public String AccountType { get; set; }
        public Decimal AccountNumber { get; set; }
        public String UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
        public String Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Please enter confirm password")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [DataType(DataType.Password)]
        public String ConfirmPassword { get; set; }
        public Decimal Pin { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public enum AccountType
    {
        SavingsAccount,
        CurrentAccount
    }
}