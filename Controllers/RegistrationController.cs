using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalManagementSysytem.Models;

namespace HospitalManagementSysytem.Controllers
{
    public class RegistrationController : Controller
    {
        DatabaseContext _db = new DatabaseContext();
        public ActionResult AddPatient(int P = 0)
        {
            tblRegistration1 _reg1 = new tblRegistration1();
            ViewBag.BT = "Save";
            _reg1.lstDepartment = _db.tblDepartments.ToList();

            if (P > 0)
            {
                var data = _db.tblRegistrations.Where(m => m.rId == P).ToList();
                _reg1.rId = data[0].rId;
                _reg1.rName = data[0].rName;
                _reg1.rAdress = data[0].rAdress;
                _reg1.rDepartment = data[0].rDepartment;
                _reg1.rDoctor = data[0].rDoctor;
                _reg1.rFees = data[0].rFees;    
                _reg1.rDiscount = data[0].rDiscount;
                _reg1.rNetAmount = data[0].rNetAmount;
                ViewBag.BT = "Update";
            }
            _reg1.lstDoctor = _db.tblDoctors.Where(m => m.DepartmentId == _reg1.rDepartment).ToList();
            return View(_reg1);
        }

        [HttpPost]
        public ActionResult AddPatient(tblRegistration1 _reg1)
        {
            tblRegistration obj = new tblRegistration();
            obj.rName = _reg1.rName;
            obj.rAdress = _reg1.rAdress;
            obj.rDepartment = _reg1.rDepartment;
            obj.rDoctor = _reg1.rDoctor;
            obj.rFees = _reg1.rFees;
            obj.rDiscount = _reg1.rDiscount;
            obj.rNetAmount = obj.rFees - obj.rDiscount;
            if (_reg1.rId == 0)
            {
                
                _db.tblRegistrations.Add(obj);
            }
            else
            {
                obj.rId = _reg1.rId;
                _db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            _db.SaveChanges();
            return RedirectToAction("ShowData");
        }

        public ActionResult DeleteData(int P)
        {
            var data = _db.tblRegistrations.Find(P);
            _db.tblRegistrations.Remove(data);
            _db.SaveChanges();
            return RedirectToAction("ShowData");
        }

        public ActionResult ShowData()
        {
            var data = (from R in _db.tblRegistrations
                        join D in _db.tblDepartments on R.rDepartment equals D.DepartmentId
                        join Doc in _db.tblDoctors on R.rDoctor equals Doc.DoctorId
                        select new ShowRegistration { rId=R.rId, rName=R.rName,rAdress=R.rAdress,rDepartment=D.DepartmentName,rDoctor=Doc.DoctorName,rFees=R.rFees,rDiscount=R.rDiscount, rNetAmount=R.rNetAmount}).ToList();
            return View(data);
        }

        public JsonResult GetDoctor(int A)
        {
            var data = _db.tblDoctors.Where(m => m.DepartmentId == A).ToList();
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}