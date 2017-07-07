namespace Repositorio.DALL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.A24",
                c => new
                    {
                        UKEY = c.Int(nullable: false, identity: true),
                        A24_001_C = c.String(nullable: false, maxLength: 60),
                        A24_002_N = c.Int(nullable: false),
                        TIMESTAMP = c.DateTime(nullable: false),
                        A23_UKEY = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UKEY)
                .ForeignKey("dbo.A23", t => t.A23_UKEY, cascadeDelete: true)
                .Index(t => t.A23_UKEY);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.A24", "A23_UKEY", "dbo.A23");
            DropIndex("dbo.A24", new[] { "A23_UKEY" });
            DropTable("dbo.A24");
        }
    }
}
