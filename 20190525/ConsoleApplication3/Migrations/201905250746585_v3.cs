namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "CarBrandID", "dbo.CarBrands");
            DropIndex("dbo.Cars", new[] { "CarBrandID" });
            RenameColumn(table: "dbo.Cars", name: "CarBrandID", newName: "Brand_CarBrandID");
            AddColumn("dbo.Cars", "BrandNo", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "Brand_CarBrandID", c => c.Int());
            CreateIndex("dbo.Cars", "Brand_CarBrandID");
            AddForeignKey("dbo.Cars", "Brand_CarBrandID", "dbo.CarBrands", "CarBrandID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Brand_CarBrandID", "dbo.CarBrands");
            DropIndex("dbo.Cars", new[] { "Brand_CarBrandID" });
            AlterColumn("dbo.Cars", "Brand_CarBrandID", c => c.Int(nullable: false));
            DropColumn("dbo.Cars", "BrandNo");
            RenameColumn(table: "dbo.Cars", name: "Brand_CarBrandID", newName: "CarBrandID");
            CreateIndex("dbo.Cars", "CarBrandID");
            AddForeignKey("dbo.Cars", "CarBrandID", "dbo.CarBrands", "CarBrandID", cascadeDelete: true);
        }
    }
}
