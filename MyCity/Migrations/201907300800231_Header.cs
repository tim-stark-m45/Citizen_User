namespace MyCity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Header : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "Header", c => c.String());
            AddColumn("dbo.Governments", "Header", c => c.String());
            AddColumn("dbo.Hospitals", "Header", c => c.String());
            AddColumn("dbo.Ideas", "Header", c => c.String());
            AddColumn("dbo.Importants", "Header", c => c.String());
            AddColumn("dbo.Infrastructures", "Header", c => c.String());
            AddColumn("dbo.News", "Header", c => c.String());
            AddColumn("dbo.PublicTransports", "Header", c => c.String());
            AddColumn("dbo.Roads", "Header", c => c.String());
            AddColumn("dbo.Securities", "Header", c => c.String());
            AddColumn("dbo.Trade_Advertising", "Header", c => c.String());
            AddColumn("dbo.Yards", "Header", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yards", "Header");
            DropColumn("dbo.Trade_Advertising", "Header");
            DropColumn("dbo.Securities", "Header");
            DropColumn("dbo.Roads", "Header");
            DropColumn("dbo.PublicTransports", "Header");
            DropColumn("dbo.News", "Header");
            DropColumn("dbo.Infrastructures", "Header");
            DropColumn("dbo.Importants", "Header");
            DropColumn("dbo.Ideas", "Header");
            DropColumn("dbo.Hospitals", "Header");
            DropColumn("dbo.Governments", "Header");
            DropColumn("dbo.Buildings", "Header");
        }
    }
}
