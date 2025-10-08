namespace KeystrokeMonitor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlackListWords",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                        WordCode = c.String(),
                        CreationDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlackListWords");
        }
    }
}
