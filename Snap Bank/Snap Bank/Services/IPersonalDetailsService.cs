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
        List<PersonalDetails> Get();

        List<PersonalDetails> Post(PersonalDetails personalDetail);

        List<PersonalDetails> Delete(int id);

        List<PersonalDetails> Put(PersonalDetails personalDetail);

    }
}
