namespace Repositorio.DALL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Refatoraçãotabeladepaismudançanosnomesdascolunas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPais",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricaoPais = c.String(nullable: false, maxLength: 50),
                        codigoPais = c.String(nullable: false, maxLength: 4),
                        TIMESTAMP = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
           // DropTable("dbo.A22");
        }
        
      
    }
}
