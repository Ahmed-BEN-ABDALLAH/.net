namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Availabilities", "dateAvailable", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Availabilities", "dateAvailable");
        }
    }
}
