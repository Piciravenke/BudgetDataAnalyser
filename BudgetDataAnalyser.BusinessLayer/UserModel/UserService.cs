using BudgetDataAnalyser.DataLayer;
using BudgetDataAnalyser.DataLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.BusinessLayer.UserModel
{
    public class UserService : IUserService
    {
        private readonly ISampleContext _sampleContext;
        public UserService(ISampleContext sampleContext)
        {
            _sampleContext = sampleContext;
        }
        public UserModel Login(string uName, string pw)
        {
            var userModel = _sampleContext.User
               .Where(e => e.UserName == uName)
               .Select(e => new UserModel
               {
                   Id = e.Id,                   
                   Password = e.Password,
                   UserName = e.UserName,                  
               })
               .FirstOrDefault();
            if (userModel == null) return null;
            if (PasswordHelper.CheckPassword(pw, userModel.Password)) return userModel;
            return null;
        }
    }
}
