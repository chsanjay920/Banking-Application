using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Bank.Services
{
    public interface IPersonalDetailsService
    {
        IEnumerable<PersonalDetails> Get();

        bool Post(PersonalDetails personalDetail);

        bool Delete(int id);

        bool Put(PersonalDetails personalDetail);

    }
}
