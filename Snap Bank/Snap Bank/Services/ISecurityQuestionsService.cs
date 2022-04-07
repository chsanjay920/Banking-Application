using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Bank.Services
{
    public interface ISecurityQuestionsService
    {
        IEnumerable<SecurityQuestions> Get();

        bool Post(SecurityQuestions securityQuestion);

        bool Delete(int id);

        bool Put(SecurityQuestions securityQuestion);
    }
}
