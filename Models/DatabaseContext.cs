using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HospitalManagementSysytem.Models
{
	public class DatabaseContext : DbContext
	{
        public DatabaseContext() : base("con")
        {

        }

        public DbSet<tblRegistration> tblRegistrations { get; set; }
        public DbSet<tblDepartment> tblDepartments { get; set; }
        public DbSet<tblDoctor> tblDoctors { get; set; }
    }
}