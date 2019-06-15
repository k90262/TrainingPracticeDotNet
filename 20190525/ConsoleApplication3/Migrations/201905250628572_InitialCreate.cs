namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarBrands",
                c => new
                    {
                        CarBrandID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CarBrandID);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.CarID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
            DropTable("dbo.CarBrands");
        }
    }
}
