namespace Locacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Padawan1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Veiculoes", "Status", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Veiculoes", "Status", c => c.Boolean(nullable: false));
        }
    }
}
