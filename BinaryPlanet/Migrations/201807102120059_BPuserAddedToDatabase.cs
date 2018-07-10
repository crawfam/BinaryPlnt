namespace BinaryPlanet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BPuserAddedToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BPUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BPUsers");
        }
    }
}
