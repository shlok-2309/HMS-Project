using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagementSysytem.Models
{
	public class tblRegistration1
	{
        public int rId { get; set; }
        public string rName { get; set; }
        public string rAdress { get; set; }
        public int rDepartment { get; set; }
        public int rDoctor { get; set; }
        public int rFees { get; set; }
        public int rDiscount { get; set; }
        public int rNetAmount { get; set;  }

        public List<tblDepartment> lstDepartment { get; set; }
        public List<tblDoctor> lstDoctor { get; set; }
    }
}