namespace Locacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Padawan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoVeiculoes", "Codigo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TipoVeiculoes", "Codigo");
        }
    }
}
