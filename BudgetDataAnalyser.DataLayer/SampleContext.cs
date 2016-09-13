using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetDataAnalyser.DataLayer.Schema;

namespace BudgetDataAnalyser.DataLayer
{
    public class SampleContext : DbContext , ISampleContext
    {
        public SampleContext()
        {

        }
        public SampleContext(string connectionString)
            : base(connectionString)
        {

        }

        public IDbSet<Category> Category
        {
            get { return Set<Category>(); }
        }

        public IDbSet<Income> Income
        {
            get { return Set<Income>(); }
        }

        public IDbSet<IncomeItem> IncomeItem
        {
            get { return Set<IncomeItem>(); }
        }

        public IDbSet<Spending> Spending
        {
            get { return Set<Spending>(); }
        }

        public IDbSet<SpendingItem> SpendingItems
        {
            get { return Set<SpendingItem>(); }
        }

        public IDbSet<User> User
        {
            get { return Set<User>(); }
        }
       
    }
}
