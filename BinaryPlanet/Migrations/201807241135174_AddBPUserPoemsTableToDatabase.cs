namespace BinaryPlanet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBPUserPoemsTableToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BPUserPoems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BPUserId = c.Int(nullable: false),
                        PoemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BPUsers", t => t.BPUserId, cascadeDelete: true)
                .ForeignKey("dbo.Poems", t => t.PoemId, cascadeDelete: true)
                .Index(t => t.BPUserId)
                .Index(t => t.PoemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BPUserPoems", "PoemId", "dbo.Poems");
            DropForeignKey("dbo.BPUserPoems", "BPUserId", "dbo.BPUsers");
            DropIndex("dbo.BPUserPoems", new[] { "PoemId" });
            DropIndex("dbo.BPUserPoems", new[] { "BPUserId" });
            DropTable("dbo.BPUserPoems");
        }
    }
}
