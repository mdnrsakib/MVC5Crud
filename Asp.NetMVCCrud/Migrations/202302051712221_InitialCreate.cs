namespace Asp.NetMVCCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        BatchId = c.Int(nullable: false, identity: true),
                        BatchCode = c.String(nullable: false, maxLength: 50),
                        Course = c.Int(nullable: false),
                        Round = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(storeType: "date"),
                        IsComplete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BatchId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Batches");
        }
    }
}
