namespace MyCity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class One : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "Image1", c => c.Binary());
            AddColumn("dbo.Buildings", "Text1", c => c.String());
            AddColumn("dbo.Buildings", "DateTime1", c => c.String());
            DropColumn("dbo.Buildings", "Image");
            DropColumn("dbo.Buildings", "Text");
            DropColumn("dbo.Buildings", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buildings", "DateTime", c => c.String());
            AddColumn("dbo.Buildings", "Text", c => c.String());
            AddColumn("dbo.Buildings", "Image", c => c.Binary());
            DropColumn("dbo.Buildings", "DateTime1");
            DropColumn("dbo.Buildings", "Text1");
            DropColumn("dbo.Buildings", "Image1");
        }
    }
}
