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
        List<AccountTable> Get();

        List<AccountTable> Post(AccountTable accountTable);

        List<AccountTable> Delete(int id);

        List<AccountTable> Put(AccountTable accountTable);
    }
}
