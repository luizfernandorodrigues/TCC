namespace Repositorio.DALL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.A23",
                c => new
                    {
                        UKEY = c.Int(nullable: false, identity: true),
                        A23_001_C = c.String(nullable: false, maxLength: 100),
                        A23_002_C = c.String(nullable: false, maxLength: 2),
                        TIMESTAMP = c.DateTime(nullable: false),
                        A22_UKEY = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UKEY)
                .ForeignKey("dbo.A22", t => t.A22_UKEY, cascadeDelete: true)
                .Index(t => t.A22_UKEY);
            
            CreateTable(
                "dbo.A22",
                c => new
                    {
                        UKEY = c.Int(nullable: false, identity: true),
                        A22_001_C = c.String(nullable: false, maxLength: 50),
                        A22_002_C = c.String(nullable: false, maxLength: 10),
                        TIMESTAMP = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UKEY);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.A23", "A22_UKEY", "dbo.A22");
            DropIndex("dbo.A23", new[] { "A22_UKEY" });
            DropTable("dbo.A22");
            DropTable("dbo.A23");
        }
    }
}
