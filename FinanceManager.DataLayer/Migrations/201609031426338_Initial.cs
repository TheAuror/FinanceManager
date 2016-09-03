namespace FinanceManager.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpenseItemEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(),
                        LastValue = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryEntities", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.ExpenseEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        ExpenseItemId = c.Int(),
                        Value = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseItemEntities", t => t.ExpenseItemId)
                .ForeignKey("dbo.UserEntities", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.ExpenseItemId);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IncomeItemEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(),
                        LastValue = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryEntities", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.IncomeEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        IncomeItemId = c.Int(),
                        Value = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IncomeItemEntities", t => t.IncomeItemId)
                .ForeignKey("dbo.UserEntities", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.IncomeItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IncomeEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.IncomeEntities", "IncomeItemId", "dbo.IncomeItemEntities");
            DropForeignKey("dbo.IncomeItemEntities", "CategoryId", "dbo.CategoryEntities");
            DropForeignKey("dbo.ExpenseEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.ExpenseEntities", "ExpenseItemId", "dbo.ExpenseItemEntities");
            DropForeignKey("dbo.ExpenseItemEntities", "CategoryId", "dbo.CategoryEntities");
            DropIndex("dbo.IncomeEntities", new[] { "IncomeItemId" });
            DropIndex("dbo.IncomeEntities", new[] { "UserId" });
            DropIndex("dbo.IncomeItemEntities", new[] { "CategoryId" });
            DropIndex("dbo.ExpenseEntities", new[] { "ExpenseItemId" });
            DropIndex("dbo.ExpenseEntities", new[] { "UserId" });
            DropIndex("dbo.ExpenseItemEntities", new[] { "CategoryId" });
            DropTable("dbo.IncomeEntities");
            DropTable("dbo.IncomeItemEntities");
            DropTable("dbo.UserEntities");
            DropTable("dbo.ExpenseEntities");
            DropTable("dbo.ExpenseItemEntities");
            DropTable("dbo.CategoryEntities");
        }
    }
}
