namespace Locacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201908272005460_Padawan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoVeiculoes", "Termo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TipoVeiculoes", "Termo");
        }
    }
}
