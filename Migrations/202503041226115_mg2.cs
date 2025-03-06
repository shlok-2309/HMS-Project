namespace HospitalManagementSysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tblRegistrations", "rNetAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblRegistrations", "rNetAmount", c => c.Int(nullable: false));
        }
    }
}
