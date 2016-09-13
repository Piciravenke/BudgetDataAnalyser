using BudgetDataAnalyser.BusinessLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.BusinessLayer.UserModel
{
    public class UserModel : BaseModel
    {
        private int _id;       
        private string _userName;
        private string _password;        

        public int Id
        {
            get { return _id; }
            set { OnPropertyChanged(ref _id, value); }
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
    }
}
