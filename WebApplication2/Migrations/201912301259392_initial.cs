namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                        Birthday = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 4, unicode: false),
                        Tel = c.String(nullable: false, maxLength: 255, unicode: false),
                        Enmil = c.String(nullable: false, maxLength: 255, unicode: false),
                        GradesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradesId, cascadeDelete: true)
                .Index(t => t.GradesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GradesId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "GradesId" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
