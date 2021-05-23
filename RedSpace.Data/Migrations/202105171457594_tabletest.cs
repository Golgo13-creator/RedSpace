namespace RedSpace.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabletest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SpaceShip", "LaunchsiteId", c => c.Int(nullable: false));
            CreateIndex("dbo.SpaceShip", "LaunchsiteId");
            AddForeignKey("dbo.SpaceShip", "LaunchsiteId", "dbo.LaunchSite", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpaceShip", "LaunchsiteId", "dbo.LaunchSite");
            DropIndex("dbo.SpaceShip", new[] { "LaunchsiteId" });
            DropColumn("dbo.SpaceShip", "LaunchsiteId");
        }
    }
}
