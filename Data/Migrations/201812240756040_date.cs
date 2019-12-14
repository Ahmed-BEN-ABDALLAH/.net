namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "dateAppointmentJEE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "dateAppointmentJEE");
        }
    }
}
