namespace BinaryPlanet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTagLineColumnToPoemTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Poems", "TagLine", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Poems", "TagLine");
        }
    }
}
