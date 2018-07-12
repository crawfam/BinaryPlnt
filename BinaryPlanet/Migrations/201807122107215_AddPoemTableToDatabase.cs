namespace BinaryPlanet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPoemTableToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Poems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sequence = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Poems");
        }
    }
}
