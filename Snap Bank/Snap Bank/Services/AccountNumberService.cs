using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snap_Bank.Services
{
    public class AccountNumberService : IAccountNumberService
    {
        SnapDbContext snapDbContext;

        public AccountNumberService()
        {
            snapDbContext = new SnapDbContext();
        }

        public IEnumerable<AccountNumber> Get()
        {
            return snapDbContext.accountNumbers.ToList();
        }

        public bool Post(AccountNumber accountNumber)
        {
            using (var dbContext = new SnapDbContext())
            {
                dbContext.accountNumbers.Add(accountNumber);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            using (var ent = new SnapDbContext())
            {
                var user = ent.accountNumbers.Where(s => s.id == id).FirstOrDefault();
                if (user != null)
                {
                    ent.accountNumbers.Remove(user);
                    ent.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public bool Put(AccountNumber accountNumber)
        {
            using (var ent = new SnapDbContext())
            {
                var temp = ent.accountNumbers.Find(accountNumber.id);
                if (temp != null)
                {
                    temp.id = accountNumber.id;
                    temp.Date = accountNumber.Date;
                    temp.number = accountNumber.number;
                }
                ent.SaveChanges();
                return true;
            }
            return false;
        }
    }
}