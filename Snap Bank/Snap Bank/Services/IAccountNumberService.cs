using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Bank.Services
{
    public interface IAccountNumberService
    {
        IEnumerable<AccountNumber> Get();

        bool Post(AccountNumber accountNumber);

        bool Delete(int id);

        bool Put(AccountNumber accountNumber);
    }
}
