namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "firstName", c => c.String());
            AlterColumn("dbo.Users", "lastName", c => c.String());
            AlterColumn("dbo.Users", "gender", c => c.String());
            AlterColumn("dbo.Users", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "gender", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "lastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "firstName", c => c.String(nullable: false));
        }
    }
}
