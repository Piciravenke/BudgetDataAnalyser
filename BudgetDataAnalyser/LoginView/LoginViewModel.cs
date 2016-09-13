using BudgetDataAnalyser.BusinessLayer.Common;
using BudgetDataAnalyser.BusinessLayer.UserModel;
using BudgetDataAnalyser.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.LoginView
{
    public class LoginViewModel : BaseModel
    {
        private readonly IMessageService _messageService;
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IUserService _userService;
        private string _userName;
        private string _password;

        public LoginViewModel(IMessageService messageService,
           ILoggedInUserService loggedInUserService,
           IUserService userService)
        {
            _messageService = messageService;
            _loggedInUserService = loggedInUserService;
            _userService = userService;
        }
        public string UserName
        {
            get { return _userName; }
            set { OnPropertyChanged(ref _userName, value); }
        }
        public string Password
        {
            get { return _password; }
            set { OnPropertyChanged(ref _password, value); }
        }
        public void Login(CancelEventArgs args)
        {
            UserModel userModel = _userService.Login(UserName, Password);
            if (userModel != null)
            {
                _loggedInUserService.LoggedInUser = userModel;
                return;
            }
            else
            {
                _messageService.ShowErrorMessage("Hibás felhasználónév vagy jelszó!");
                args.Cancel = true;
            }
        }
    }
}
