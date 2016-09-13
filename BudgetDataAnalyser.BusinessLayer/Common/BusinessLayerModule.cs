using Autofac;
using BudgetDataAnalyser.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDataAnalyser.BusinessLayer.Common
{
    public class BusinessLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           /* builder.RegisterType<ProductService>()
                .As<IProductService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<OrderService>()
                .As<IOrderService>()
                .InstancePerLifetimeScope();*/
            builder.RegisterAssemblyModules(
                typeof(ISampleContext).Assembly);
        }
    }
}
