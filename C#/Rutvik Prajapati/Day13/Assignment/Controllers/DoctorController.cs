using Day13Task.API.Modal;
using Day13Task.API.Services.DoctorServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day13Task.API.Controllers
{
    [ApiController]
    [Route("api/Doctor")]
    public class DoctorController : Controller
    {
        private IDoctorServices _doctorServices;
        public DoctorController(IDoctorServices doctorServices)
        {
            this._doctorServices = doctorServices;
        }

        // add new doctor 
        [Authorize]
        [HttpPost]   
        [Route("addnewdoctor")]
        public string AddNewDoctor([FromBody]DoctorModal doctorModal)
        {
            var response = "";
            try
            {
                if (doctorModal != null)
                {
                    response = _doctorServices.addNewDoctor(doctorModal);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
                
            }
        }

        //delete doctor from db
        [Authorize]
        [HttpPost]
        [Route("deletedoctor/{doctorId}")]
        public string DeleteDoctor(int doctorId)
        {
            var response = false;
            try
            {
                if (doctorId != 0 && doctorId>0)
                {
                    response = _doctorServices.deleteDoctor(doctorId);
                    if (response == true)
                    {
                        return "successfully delete doctor";
                    }
                    return "something wrong";
                    
                }
                return "enter proper doctorId";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //get all departments
        [Authorize]
        [HttpGet]
        [Route("allDepartment")]
        public List<DepartmentModal> GetAllDepartment()
        {
            var response = new List<DepartmentModal>();
            try
            {
                response = _doctorServices.getAllDepartments();
                return response; 
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //get doctor with their department 
        [Authorize]
        [HttpGet]
        [Route("getDoctorDepartment")]
        public List<DoctorWithDepartment> GetDoctorWithDepartment()
        {
            var response = new List<DoctorWithDepartment>();
            try
            {
                response = _doctorServices.getDoctorDetails();
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //get doctor's patients
        [Authorize]
        [HttpGet]
        [Route("getDoctorPatients")]
        public List<DoctorPatientsModal> GetDoctorPatientList()
        {
            var response = new List<DoctorPatientsModal>();
            try
            {
                response = _doctorServices.getListOfDoctorPatients();
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //get patient's medicines list
        [Authorize]
        [HttpGet]
        [Route("getpatientMedicines")]
        public List<PatientMedicinesModel> GetPatientMedicineList()
        {
            var response = new List<PatientMedicinesModel>();
            try
            {
                response = _doctorServices.getListOfPatientsMedicine();
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //get patient summary report
        [Authorize]
        [HttpGet]
        [Route("patientSummaryReport")]
        public List<SummaryReportOfPatient> PatientSummaryReport()
        {
            var response = new List<SummaryReportOfPatient>();
            try
            {
                response = _doctorServices.summaryReportOfDoctorPatient();
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //update doctor details
        [Authorize]
        [HttpPost]
        [Route("updateDoctor")]
        public string UpdateDoctor(DoctorWithDepartment doctorDeptModal)
        {
            var response = "";
            try
            {
                if (doctorDeptModal != null)
                {
                    response = _doctorServices.updateDoctorDetail(doctorDeptModal);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
