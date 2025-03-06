using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalManagementSysytem.Models
{
	public class tblDoctor
	{
        [Key]
        public int DoctorId { get; set; }
        public int DepartmentId { get; set; }
        public string DoctorName { get; set; }
    }
}