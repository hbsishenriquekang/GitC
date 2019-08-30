namespace Locacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Padawan3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculoes", "InicioFK", c => c.Int(nullable: false));
            AddColumn("dbo.Veiculoes", "FinalFK", c => c.Int(nullable: false));
            CreateIndex("dbo.Veiculoes", "InicioFK");
            CreateIndex("dbo.Veiculoes", "FinalFK");
            //AddForeignKey("dbo.Veiculoes", "FinalFK", "dbo.TipoVeiculoes", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.Veiculoes", "InicioFK", "dbo.TipoVeiculoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculoes", "InicioFK", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Veiculoes", "FinalFK", "dbo.TipoVeiculoes");
            DropIndex("dbo.Veiculoes", new[] { "FinalFK" });
            DropIndex("dbo.Veiculoes", new[] { "InicioFK" });
            DropColumn("dbo.Veiculoes", "FinalFK");
            DropColumn("dbo.Veiculoes", "InicioFK");
        }
    }
}
