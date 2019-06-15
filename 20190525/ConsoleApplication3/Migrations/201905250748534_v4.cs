namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "Brand_CarBrandID", "dbo.CarBrands");
            DropIndex("dbo.Cars", new[] { "Brand_CarBrandID" });
            DropColumn("dbo.Cars", "BrandNo");
            RenameColumn(table: "dbo.Cars", name: "Brand_CarBrandID", newName: "BrandNo");
            AlterColumn("dbo.Cars", "BrandNo", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "BrandNo");
            AddForeignKey("dbo.Cars", "BrandNo", "dbo.CarBrands", "CarBrandID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "BrandNo", "dbo.CarBrands");
            DropIndex("dbo.Cars", new[] { "BrandNo" });
            AlterColumn("dbo.Cars", "BrandNo", c => c.Int());
            RenameColumn(table: "dbo.Cars", name: "BrandNo", newName: "Brand_CarBrandID");
            AddColumn("dbo.Cars", "BrandNo", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "Brand_CarBrandID");
            AddForeignKey("dbo.Cars", "Brand_CarBrandID", "dbo.CarBrands", "CarBrandID");
        }
    }
}
