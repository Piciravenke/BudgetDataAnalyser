using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.DataLayer.Schema
{
    public class Spending
    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int SpendingItemId { get; set; }
        public virtual int Vaule { get; set; }
        public virtual DateTime CreatedTime { get; set; }
    }
}
