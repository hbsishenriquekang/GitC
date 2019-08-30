namespace LocacaoGaragem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Automovels", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Motoes", "Ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Motoes", "Ativo");
            DropColumn("dbo.Automovels", "Ativo");
        }
    }
}
