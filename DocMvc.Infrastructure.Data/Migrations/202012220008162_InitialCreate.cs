namespace DocMvc.Infrastructure.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documento",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Revisao = c.String(nullable: false, maxLength: 1, unicode: false),
                        DataPlanejada = c.DateTime(nullable: false, precision: 0),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Codigo);
        }
        
        public override void Down()
        {
            DropTable("dbo.Documento");
        }
    }
}
