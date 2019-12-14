namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tt2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Appointments", "dateAppointment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "dateAppointment", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
