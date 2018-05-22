namespace BilleniumProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactData",
                c => new
                    {
                        ContactDataId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Comment = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ContactDataId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactData");
        }
    }
}
