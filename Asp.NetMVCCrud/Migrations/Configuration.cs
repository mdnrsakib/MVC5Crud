namespace Asp.NetMVCCrud.Migrations
{
    using Asp.NetMVCCrud.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Asp.NetMVCCrud.Models.BatchDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Asp.NetMVCCrud.Models.BatchDbContext context)
        {
            Batch b = new Batch { BatchCode = "CS/ACSL-A/50/01", Course = Course.ESAD, Round = 50, StartDate = DateTime.Now.AddDays(-5 * 30), IsComplete = false };
            context.Batches.Add(b);
            context.SaveChanges();
        }
    }
}
