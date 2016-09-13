using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.BusinessLayer.UserModel
{
    public interface IUserService
    {
        UserModel Login(string uName, string pw);
    }
}
