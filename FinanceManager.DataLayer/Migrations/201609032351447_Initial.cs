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
                "dbo.TransactionItemEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(),
                        LastValue = c.Int(),
                        IsIncome = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryEntities", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.TransactionEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        TransactionItemId = c.Int(),
                        Value = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        IsIncome = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TransactionItemEntities", t => t.TransactionItemId)
                .ForeignKey("dbo.UserEntities", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.TransactionItemId);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.TransactionEntities", "TransactionItemId", "dbo.TransactionItemEntities");
            DropForeignKey("dbo.TransactionItemEntities", "CategoryId", "dbo.CategoryEntities");
            DropIndex("dbo.TransactionEntities", new[] { "TransactionItemId" });
            DropIndex("dbo.TransactionEntities", new[] { "UserId" });
            DropIndex("dbo.TransactionItemEntities", new[] { "CategoryId" });
            DropTable("dbo.UserEntities");
            DropTable("dbo.TransactionEntities");
            DropTable("dbo.TransactionItemEntities");
            DropTable("dbo.CategoryEntities");
        }
    }
}
