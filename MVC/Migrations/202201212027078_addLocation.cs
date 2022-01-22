namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "Location");
        }
    }
}
