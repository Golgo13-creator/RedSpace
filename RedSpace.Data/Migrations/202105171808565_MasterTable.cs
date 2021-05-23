namespace RedSpace.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasterTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SpaceShip", "LaunchSiteId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SpaceShip", "LaunchSiteId");
        }
    }
}
