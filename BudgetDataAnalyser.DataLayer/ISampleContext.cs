using BudgetDataAnalyser.DataLayer.Schema;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.DataLayer
{
    public interface ISampleContext
    {
        IDbSet<Category> Category { get; }
        IDbSet<User> User { get; }
        IDbSet<IncomeItem> IncomeItem { get; }
        IDbSet<SpendingItem> SpendingItems { get; }
        IDbSet<Income> Income { get; }
        IDbSet<Spending> Spending { get; }

        int SaveChanges();
    }
}
