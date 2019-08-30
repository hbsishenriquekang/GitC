namespace LocacaoGaragem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Automovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarcaFK = c.Int(nullable: false),
                        ModeloFK = c.Int(nullable: false),
                        CorFK = c.Int(nullable: false),
                        DescontoEmFolha = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cors", t => t.CorFK, cascadeDelete: true)
                .ForeignKey("dbo.MotoMarcas", t => t.MarcaFK, cascadeDelete: true)
                .ForeignKey("dbo.MotoModeloes", t => t.ModeloFK, cascadeDelete: true)
                .Index(t => t.MarcaFK)
                .Index(t => t.ModeloFK)
                .Index(t => t.CorFK);
            
            CreateTable(
                "dbo.Cors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MotoMarcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Marca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MotoModeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AutomovelMarcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Marca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AutomovelModeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bicicletas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescontoEmFolha = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Motoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarcaFK = c.Int(nullable: false),
                        ModeloFK = c.Int(nullable: false),
                        CorFK = c.Int(nullable: false),
                        DescontoEmFolha = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cors", t => t.CorFK, cascadeDelete: true)
                .ForeignKey("dbo.MotoMarcas", t => t.MarcaFK, cascadeDelete: true)
                .ForeignKey("dbo.MotoModeloes", t => t.ModeloFK, cascadeDelete: true)
                .Index(t => t.MarcaFK)
                .Index(t => t.ModeloFK)
                .Index(t => t.CorFK);
            
            CreateTable(
                "dbo.Patinetes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescontoEmFolha = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Motoes", "ModeloFK", "dbo.MotoModeloes");
            DropForeignKey("dbo.Motoes", "MarcaFK", "dbo.MotoMarcas");
            DropForeignKey("dbo.Motoes", "CorFK", "dbo.Cors");
            DropForeignKey("dbo.Automovels", "ModeloFK", "dbo.MotoModeloes");
            DropForeignKey("dbo.Automovels", "MarcaFK", "dbo.MotoMarcas");
            DropForeignKey("dbo.Automovels", "CorFK", "dbo.Cors");
            DropIndex("dbo.Motoes", new[] { "CorFK" });
            DropIndex("dbo.Motoes", new[] { "ModeloFK" });
            DropIndex("dbo.Motoes", new[] { "MarcaFK" });
            DropIndex("dbo.Automovels", new[] { "CorFK" });
            DropIndex("dbo.Automovels", new[] { "ModeloFK" });
            DropIndex("dbo.Automovels", new[] { "MarcaFK" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Patinetes");
            DropTable("dbo.Motoes");
            DropTable("dbo.Bicicletas");
            DropTable("dbo.AutomovelModeloes");
            DropTable("dbo.AutomovelMarcas");
            DropTable("dbo.MotoModeloes");
            DropTable("dbo.MotoMarcas");
            DropTable("dbo.Cors");
            DropTable("dbo.Automovels");
        }
    }
}
