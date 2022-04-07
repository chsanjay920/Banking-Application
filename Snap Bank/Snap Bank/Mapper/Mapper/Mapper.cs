using Snap_Bank.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Snap_Bank.Models;

namespace Snap_Bank.Mapper
{
    public class Mapper
    {
        public AccountViewModel MapAccountViewModelToAccount(AccountViewModel accountViewModel, AccountTable account)
        {
            account.AccountNumber = accountViewModel.AccountNumber;
            account.AccountType = accountViewModel.AccountType;
            account.UserId = accountViewModel.UserId;
            account.Password = accountViewModel.Password;
            account.SortCode = accountViewModel.SortCode;
            account.UserName = accountViewModel.UserName;
            account.Pin = accountViewModel.Pin;


            return accountViewModel;
        }

        public AccountTable MapAccountToMapAccountViewModel(AccountTable account, AccountViewModel accountViewModel)
        {
            accountViewModel.AccountNumber = account.AccountNumber;
            accountViewModel.AccountType = account.AccountType;
            accountViewModel.UserId = account.UserId;
            accountViewModel.Password = account.Password;
            accountViewModel.SortCode = account.SortCode;
            accountViewModel.UserName = account.UserName;
            accountViewModel.Pin = account.Pin;

            return account;
        }

        public PersonalDetailsViewModel PersonalDetailsViewModelToPersonalDetails(PersonalDetailsViewModel personalDetailsViewModel, PersonalDetails personalDetails)
        {
            personalDetailsViewModel.UserId = personalDetails.UserId;
            personalDetailsViewModel.FirstName = personalDetails.FirstName;
            personalDetailsViewModel.LastName = personalDetails.LastName;
            personalDetailsViewModel.MobileNumber = personalDetails.MobileNumber;
            personalDetailsViewModel.Gender = personalDetails.Gender;
            personalDetailsViewModel.Gmail = personalDetails.Gmail;
            personalDetailsViewModel.DateOfBirth = personalDetails.DateOfBirth;

            return personalDetailsViewModel;

        }

        public PersonalDetails MapPersonalDetailsToPersonalDetailsViewMOdel(PersonalDetails personalDetails, PersonalDetailsViewModel personalDetailsViewModel)
        {
            personalDetails.UserId = personalDetailsViewModel.UserId;
            personalDetails.FirstName = personalDetailsViewModel.FirstName;
            personalDetails.LastName = personalDetailsViewModel.LastName;
            personalDetails.MobileNumber = personalDetailsViewModel.MobileNumber;
            personalDetails.Gender = personalDetailsViewModel.Gender;
            personalDetails.Gmail = personalDetailsViewModel.Gmail;
            personalDetails.DateOfBirth = personalDetailsViewModel.DateOfBirth;

            return personalDetails;
        }

        public SecurityQuestionsViewModel MapSecurityQuestionsViewModelToSecurityQuestions(SecurityQuestionsViewModel securityQuestionsViewModel, SecurityQuestions securityQuestions)
        {
            securityQuestionsViewModel.UserId = securityQuestions.UserId;
            securityQuestionsViewModel.PetName = securityQuestions.PetName;
            securityQuestionsViewModel.BirthPlace = securityQuestions.BirthPlace;
            securityQuestionsViewModel.FavouriteFood = securityQuestions.FavouriteFood;

            return securityQuestionsViewModel;
        }

        public SecurityQuestions MapSecurityQuestionsToSecurityQuestionsViewModel(SecurityQuestions securityQuestions, SecurityQuestionsViewModel securityQuestionsViewModel)
        {
            securityQuestions.UserId = securityQuestionsViewModel.UserId;
            securityQuestions.PetName = securityQuestionsViewModel.PetName;
            securityQuestions.BirthPlace = securityQuestionsViewModel.BirthPlace;
            securityQuestions.FavouriteFood = securityQuestionsViewModel.FavouriteFood;

            return securityQuestions;
        }

        public Transactions MapTransactionsToTranscationViewModel(Transactions transactions, TransactionViewModel transactionViewModel)
        {
            transactions.UserId = transactionViewModel.UserId;
            transactions.TransactionDate = transactionViewModel.TransactionDate;
            transactions.FromAccount = transactionViewModel.FromAccount;
            transactions.ToAccount = transactionViewModel.ToAccount;
            transactions.AccountType = transactionViewModel.AccountType;
            transactions.Amount = transactionViewModel.Amount;
            transactions.TransactionType = transactionViewModel.TransactionType;
            transactions.TransactionCompleted = transactionViewModel.TransactionCompleted;
            transactions.mode = transactionViewModel.mode;

            return transactions;
        }

        public TransactionViewModel MapTransactionViewModelToTranscations(TransactionViewModel transactionsViewModel, Transactions transactions)
        {
            transactionsViewModel.UserId = transactions.UserId;
            transactionsViewModel.TransactionDate = transactions.TransactionDate;
            transactionsViewModel.FromAccount = transactions.FromAccount;
            transactionsViewModel.ToAccount = transactions.ToAccount;
            transactionsViewModel.AccountType = transactions.AccountType;
            transactionsViewModel.Amount = transactions.Amount;
            transactionsViewModel.TransactionType = transactions.TransactionType;
            transactionsViewModel.TransactionCompleted = transactions.TransactionCompleted;
            transactionsViewModel.mode = transactions.mode;

            return transactionsViewModel;
        }
    }
}