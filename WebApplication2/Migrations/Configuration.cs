namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Models.EFContext context)
        {
            Grades[] g = {
                new Grades{ Title = "S2T89"},
                new Grades{ Title = "S2T93"}
            };
            context.Grades.AddOrUpdate(g); // 通过我们的表往其中存放默认数据
            context.SaveChanges(); //保存更改
            
        }
    }
}
