namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewFeature : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "FavoriteColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "FavoriteColor");
        }
    }
}
