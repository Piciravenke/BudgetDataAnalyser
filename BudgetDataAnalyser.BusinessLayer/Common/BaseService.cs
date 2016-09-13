using BudgetDataAnalyser.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.BusinessLayer
{
    public class BaseService
    {
        protected readonly ISampleContext Context;
        public BaseService(ISampleContext context)
        {
            Context = context;
        }
    }
}
