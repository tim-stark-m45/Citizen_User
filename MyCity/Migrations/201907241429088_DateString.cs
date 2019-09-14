namespace MyCity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Infrastructures", "DateTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Infrastructures", "DateTime", c => c.Int(nullable: false));
        }
    }
}
