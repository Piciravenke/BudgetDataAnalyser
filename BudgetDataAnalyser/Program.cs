using Autofac;
using BudgetDataAnalyser.BusinessLayer.UserModel;
using BudgetDataAnalyser.Common;
using BudgetDataAnalyser.LoginView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetDataAnalyser
{
    static class Program
    {
        public static IContainer Container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(
                typeof(IUserService).Assembly);
          /*  builder.RegisterType<UserService>()
                .As<IUserService>()
                .InstancePerLifetimeScope();*/
            builder.RegisterType<LoginViewModel>()
                .AsSelf()
                .InstancePerLifetimeScope();
            builder.RegisterType<LoginForm>()
                .AsSelf()
                .InstancePerLifetimeScope();
            builder.RegisterType<LoggedInUserService>()
                .As<ILoggedInUserService>()
                .SingleInstance();
            builder.RegisterType<MessageService>()
                .As<IMessageService>()
                .SingleInstance();

            Container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
