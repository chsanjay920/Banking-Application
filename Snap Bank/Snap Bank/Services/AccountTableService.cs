using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snap_Bank.Services
{
    public class AccountTableService : IAccountTableService
    {
        SnapDbContext snapDbContext;
        AccountTable accountTable;

        public AccountTableService()
        {
            snapDbContext = new SnapDbContext();
        }

        public List<AccountTable> Get()
        {
            return snapDbContext.AccountTables.ToList();
        }

        public List<AccountTable> Post(AccountTable accountTable)
        {
            using (var dbContext = new SnapDbContext())
            {
                dbContext.AccountTables.Add(accountTable);
                dbContext.SaveChanges();
            }
            return Get();
        }
        public List<AccountTable> Delete(int id)
        {
            using (var ent = new SnapDbContext())
            {
                var user = ent.AccountTables.Where(s => s.UserId == id).FirstOrDefault();
                if (user != null)
                {
                    ent.AccountTables.Remove(user);
                    ent.SaveChanges();
                }
                return Get();
            }
        }
        public List<AccountTable> Put(AccountTable accountTable)
        {
            using (var ent = new SnapDbContext())
            {
                var temp = ent.AccountTables.Find(accountTable.UserId);
                if (temp != null)
                {
                    temp.UserName = accountTable.UserName;
                    temp.Password = accountTable.Password;
                    temp.AccountNumber = accountTable.AccountNumber;
                    temp.Pin = accountTable.Pin;
                    temp.SortCode = accountTable.SortCode;
                    temp.AccountType = accountTable.AccountType;
                }
                ent.SaveChanges();
            }
            return Get();
        }
    }
}