﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalManagementSysytem.Models
{
	public class tblDepartment
	{
		[Key]
		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }
	}
}