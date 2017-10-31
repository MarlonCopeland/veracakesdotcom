namespace Veracakes.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrationEver : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifyDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedSessionID = c.Int(),
                        ModifySessionID = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        PastryDesignID = c.String(),
                        OrderDate = c.DateTime(),
                        ConsultDate = c.DateTime(),
                        OverallPrice = c.Double(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifyDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedSessionID = c.Int(),
                        ModifySessionID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.PastryDesign",
                c => new
                    {
                        PastryID = c.Int(nullable: false, identity: true),
                        PastryStyle = c.String(),
                        PastryType = c.String(),
                        PastryDetails = c.String(),
                        PastryPrice = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifyDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedSessionID = c.Int(),
                        ModifySessionID = c.Int(),
                    })
                .PrimaryKey(t => t.PastryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PastryDesign");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
