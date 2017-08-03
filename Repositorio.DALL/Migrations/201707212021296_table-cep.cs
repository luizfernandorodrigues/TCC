namespace Repositorio.DALL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablecep : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.A25",
                c => new
                    {
                        UKEY = c.Int(nullable: false, identity: true),
                        A25_001_C = c.String(nullable: false, maxLength: 8),
                        A25_002_C = c.String(nullable: false, maxLength: 60),
                        A25_003_C = c.String(nullable: false, maxLength: 60),
                        TIMESTAMP = c.DateTime(nullable: false),
                        A24_UKEY = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UKEY)
                .ForeignKey("dbo.A24", t => t.A24_UKEY, cascadeDelete: true)
                .Index(t => t.A24_UKEY);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.A25", "A24_UKEY", "dbo.A24");
            DropIndex("dbo.A25", new[] { "A24_UKEY" });
            DropTable("dbo.A25");
        }
    }
}
