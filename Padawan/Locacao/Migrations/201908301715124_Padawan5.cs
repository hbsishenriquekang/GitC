namespace Locacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Padawan5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Veiculoes", "FinalFK", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Veiculoes", "InicioFK", "dbo.TipoVeiculoes");
            DropIndex("dbo.Veiculoes", new[] { "InicioFK" });
            DropIndex("dbo.Veiculoes", new[] { "FinalFK" });
            AlterColumn("dbo.Veiculoes", "InicioFK", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Veiculoes", "FinalFK", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Veiculoes", "FinalFK", c => c.Int(nullable: false));
            AlterColumn("dbo.Veiculoes", "InicioFK", c => c.Int(nullable: false));
            CreateIndex("dbo.Veiculoes", "FinalFK");
            CreateIndex("dbo.Veiculoes", "InicioFK");
            AddForeignKey("dbo.Veiculoes", "InicioFK", "dbo.TipoVeiculoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Veiculoes", "FinalFK", "dbo.TipoVeiculoes", "Id", cascadeDelete: true);
        }
    }
}
