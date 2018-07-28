namespace BinaryPlanet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeSequenceColumninPoemTableNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Poems", "Sequence", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Poems", "Sequence", c => c.Int(nullable: false));
        }
    }
}
