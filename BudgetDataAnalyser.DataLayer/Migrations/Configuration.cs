namespace BudgetDataAnalyser.DataLayer.Migrations
{
    using Common;
    using Schema;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BudgetDataAnalyser.DataLayer.SampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BudgetDataAnalyser.DataLayer.SampleContext context)
        {
            if (!context.User.Any())
                context.User.AddOrUpdate(entity => entity.UserName, new User
                {                   
                    UserName = "admin",
                    Password = PasswordHelper.EncryptPassword("admin"),                   
                });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
