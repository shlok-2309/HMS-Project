using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagementSysytem.Models
{
	public class ShowRegistration
	{
        public int rId { get; set; }
        public string rName { get; set; }
        public string rAdress { get; set; }
        public string rDepartment { get; set; }
        public string rDoctor { get; set; }
        public int rFees { get; set; }
        public int rDiscount { get; set; }
        public int rNetAmount { get; set; }

    }
}