using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.BusinessLayer.UserModel
{
    public interface ILoggedInUserService
    {
        UserModel LoggedInEmployee { get; set; }
    }
}
