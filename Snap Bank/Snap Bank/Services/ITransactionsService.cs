using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Bank.Services
{
    public interface ITransactionsService
    {
        List<Transactions> Get();

        List<Transactions> Post(Transactions transaction);

        List<Transactions> Delete(int id);

        List<Transactions> Put(Transactions transaction);
    }
}
