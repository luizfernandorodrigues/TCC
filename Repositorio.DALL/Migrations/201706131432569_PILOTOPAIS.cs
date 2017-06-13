namespace Repositorio.DALL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PILOTOPAIS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.A22",
                c => new
                    {
                        UKEY = c.Int(nullable: false, identity: true),
                        A22_001_C = c.String(nullable: false, maxLength: 50),
                        A22_002_c = c.String(nullable: false, maxLength: 10),
                        TIMESTAMP = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UKEY);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.A22");
        }
    }
}
