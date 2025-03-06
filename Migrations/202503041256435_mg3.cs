namespace HospitalManagementSysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegistrations", "rNetAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblRegistrations", "rNetAmount");
        }
    }
}
