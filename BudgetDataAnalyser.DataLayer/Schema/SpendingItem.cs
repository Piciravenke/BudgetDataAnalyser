﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.DataLayer.Schema
{
    public class SpendingItem
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int LastVaule { get; set; }
    }
}
