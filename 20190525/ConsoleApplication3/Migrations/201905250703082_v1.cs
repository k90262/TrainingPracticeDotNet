namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarBrandID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "CarBrandID");
            AddForeignKey("dbo.Cars", "CarBrandID", "dbo.CarBrands", "CarBrandID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarBrandID", "dbo.CarBrands");
            DropIndex("dbo.Cars", new[] { "CarBrandID" });
            DropColumn("dbo.Cars", "CarBrandID");
        }
    }
}
