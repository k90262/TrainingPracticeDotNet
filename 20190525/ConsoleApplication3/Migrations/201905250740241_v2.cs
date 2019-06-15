namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Cars");
            DropColumn("dbo.Cars", "CarID");

            AddColumn("dbo.Cars", "CarNo", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cars", "CarNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "CarID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Cars");
            DropColumn("dbo.Cars", "CarNo");
            AddPrimaryKey("dbo.Cars", "CarID");
        }
    }
}
