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
        List<SecurityQuestions> Get();

        List<SecurityQuestions> Post(SecurityQuestions securityQuestion);

        List<SecurityQuestions> Delete(int id);

        List<SecurityQuestions> Put(SecurityQuestions securityQuestion);
    }
}
