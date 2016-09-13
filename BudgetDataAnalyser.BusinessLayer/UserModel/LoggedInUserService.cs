using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.BusinessLayer.UserModel
{
    public class LoggedInUserService : ILoggedInUserService
    {
        public UserModel LoggedInUser { get; set; }
    }
}
