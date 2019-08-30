namespace LocacaoGaragem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Automovels", "Placa", c => c.String());
            AddColumn("dbo.Motoes", "Placa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Motoes", "Placa");
            DropColumn("dbo.Automovels", "Placa");
        }
    }
}
