namespace BinaryPlanet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSectionColumnToPoemTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Poems", "Section", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Poems", "Section");
        }
    }
}
