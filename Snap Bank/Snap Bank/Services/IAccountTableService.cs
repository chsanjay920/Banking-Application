using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Bank.Services
{
    public interface IAccountTableService
    {
        IEnumerable<AccountTable> Get();

        IEnumerable<AccountTable> Post(AccountTable accountTable);

        IEnumerable<AccountTable> Delete(int id);

        IEnumerable<AccountTable> Put(AccountTable accountTable);
    }
}
