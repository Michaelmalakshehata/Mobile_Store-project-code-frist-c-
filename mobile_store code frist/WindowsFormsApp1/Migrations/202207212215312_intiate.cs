namespace main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.accessierdetailes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        type = c.String(),
                        quantity = c.Int(nullable: false),
                        warranty = c.Double(nullable: false),
                        date = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.accessierimages",
                c => new
                    {
                        id = c.Int(nullable: false),
                        nameproduct = c.String(nullable: false),
                        productimg1 = c.Binary(),
                        productimg2 = c.Binary(),
                        productimg3 = c.Binary(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.accessierdetailes", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        customer_phone = c.Int(nullable: false),
                        productname = c.String(),
                        quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CustomerProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CustomerPhone = c.Int(nullable: false),
                        typeproduct = c.String(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.mobildetailes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        screen = c.Double(nullable: false),
                        storage = c.Int(nullable: false),
                        ram = c.Int(nullable: false),
                        battery = c.Int(nullable: false),
                        front_camera = c.Int(nullable: false),
                        back_camera = c.Int(nullable: false),
                        processor = c.String(),
                        android = c.String(),
                        network = c.String(),
                        quantity = c.Int(nullable: false),
                        warranty = c.Double(nullable: false),
                        date = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.mobile_images",
                c => new
                    {
                        mobildetaileId = c.Int(nullable: false),
                        nameproduct = c.String(nullable: false),
                        productimg1 = c.Binary(),
                        productimg2 = c.Binary(),
                        productimg3 = c.Binary(),
                    })
                .PrimaryKey(t => t.mobildetaileId)
                .ForeignKey("dbo.mobildetailes", t => t.mobildetaileId)
                .Index(t => t.mobildetaileId);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                        Confirm_Password = c.String(),
                        Check_Answer = c.String(),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerProductBills",
                c => new
                    {
                        CustomerProduct_ID = c.Int(nullable: false),
                        Bill_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CustomerProduct_ID, t.Bill_Id })
                .ForeignKey("dbo.CustomerProducts", t => t.CustomerProduct_ID, cascadeDelete: true)
                .ForeignKey("dbo.Bills", t => t.Bill_Id, cascadeDelete: true)
                .Index(t => t.CustomerProduct_ID)
                .Index(t => t.Bill_Id);
            
            CreateTable(
                "dbo.mobildetaileBills",
                c => new
                    {
                        idmob = c.Int(nullable: false),
                        idbillmob = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.idmob, t.idbillmob })
                .ForeignKey("dbo.mobildetailes", t => t.idmob, cascadeDelete: true)
                .ForeignKey("dbo.Bills", t => t.idbillmob, cascadeDelete: true)
                .Index(t => t.idmob)
                .Index(t => t.idbillmob);
            
            CreateTable(
                "dbo.accessierdetaileBills",
                c => new
                    {
                        idaccess = c.Int(nullable: false),
                        idbillaccess = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.idaccess, t.idbillaccess })
                .ForeignKey("dbo.accessierdetailes", t => t.idaccess, cascadeDelete: true)
                .ForeignKey("dbo.Bills", t => t.idbillaccess, cascadeDelete: true)
                .Index(t => t.idaccess)
                .Index(t => t.idbillaccess);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.accessierdetaileBills", "idbillaccess", "dbo.Bills");
            DropForeignKey("dbo.accessierdetaileBills", "idaccess", "dbo.accessierdetailes");
            DropForeignKey("dbo.mobile_images", "mobildetaileId", "dbo.mobildetailes");
            DropForeignKey("dbo.mobildetaileBills", "idbillmob", "dbo.Bills");
            DropForeignKey("dbo.mobildetaileBills", "idmob", "dbo.mobildetailes");
            DropForeignKey("dbo.CustomerProducts", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.CustomerProductBills", "Bill_Id", "dbo.Bills");
            DropForeignKey("dbo.CustomerProductBills", "CustomerProduct_ID", "dbo.CustomerProducts");
            DropForeignKey("dbo.Bills", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.accessierimages", "id", "dbo.accessierdetailes");
            DropIndex("dbo.accessierdetaileBills", new[] { "idbillaccess" });
            DropIndex("dbo.accessierdetaileBills", new[] { "idaccess" });
            DropIndex("dbo.mobildetaileBills", new[] { "idbillmob" });
            DropIndex("dbo.mobildetaileBills", new[] { "idmob" });
            DropIndex("dbo.CustomerProductBills", new[] { "Bill_Id" });
            DropIndex("dbo.CustomerProductBills", new[] { "CustomerProduct_ID" });
            DropIndex("dbo.mobile_images", new[] { "mobildetaileId" });
            DropIndex("dbo.CustomerProducts", new[] { "Customer_ID" });
            DropIndex("dbo.Bills", new[] { "Customer_ID" });
            DropIndex("dbo.accessierimages", new[] { "id" });
            DropTable("dbo.accessierdetaileBills");
            DropTable("dbo.mobildetaileBills");
            DropTable("dbo.CustomerProductBills");
            DropTable("dbo.users");
            DropTable("dbo.mobile_images");
            DropTable("dbo.mobildetailes");
            DropTable("dbo.CustomerProducts");
            DropTable("dbo.Customers");
            DropTable("dbo.Bills");
            DropTable("dbo.accessierimages");
            DropTable("dbo.accessierdetailes");
        }
    }
}
