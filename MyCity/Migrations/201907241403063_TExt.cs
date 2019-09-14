namespace MyCity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TExt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Infrastructures", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Infrastructures", "Text");
        }
    }
}
