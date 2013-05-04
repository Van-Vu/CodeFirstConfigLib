namespace CodeFirstConfigLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "NewProperty", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "NewProperty");
        }
    }
}
