using FinanceManager.DataLayer.Entities;

namespace FinanceManager.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinanceManager.DataLayer.SampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinanceManager.DataLayer.SampleContext context)
        {
            if (!context.Categorys.Any())
            {
                context.Categorys.Add(new CategoryEntity
                {
                    Name = "Default"
                });
            }
        }
    }
}
