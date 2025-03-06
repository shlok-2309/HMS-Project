namespace HospitalManagementSysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblDepartments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.tblDoctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        DoctorName = c.String(),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.tblRegistrations",
                c => new
                    {
                        rId = c.Int(nullable: false, identity: true),
                        rName = c.String(),
                        rAdress = c.String(),
                        rDepartment = c.Int(nullable: false),
                        rDoctor = c.Int(nullable: false),
                        rFees = c.Int(nullable: false),
                        rDiscount = c.Int(nullable: false),
                        rNetAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.rId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblRegistrations");
            DropTable("dbo.tblDoctors");
            DropTable("dbo.tblDepartments");
        }
    }
}
