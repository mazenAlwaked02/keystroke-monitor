namespace KeystrokeMonitor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_IsSended_On_BlackListWords : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlackListWords", "IsSended", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlackListWords", "IsSended");
        }
    }
}
