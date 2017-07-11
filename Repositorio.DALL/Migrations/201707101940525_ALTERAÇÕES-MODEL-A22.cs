namespace Repositorio.DALL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ALTERAÇÕESMODELA22 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.A22", "A22_002_C", c => c.String(nullable: false, maxLength: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.A22", "A22_002_C", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
