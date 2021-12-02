using Day13Task.API.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using Day13Task.API.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Day13Task.API.Services.DoctorServices
{
    public class DoctorServices : IDoctorServices
    {
        public HospitalDB2021Context dbContext { get; set; }
        public DoctorServices(HospitalDB2021Context hospitalDB2021Context)
        {
            this.dbContext = hospitalDB2021Context;
        }

        //add new doctor
        public string addNewDoctor(DoctorModal doctorModal)
        { 
            var newDoctor = new Doctor()
            {
                DepartmentId = doctorModal.DepartmentId,
                Name = doctorModal.Name,
                IsActive = true,
                IsDelete = false
            };
            dbContext.Doctor.Add(newDoctor);
            dbContext.SaveChanges();
            return "New Doctor Inserted Successfully.";
        }

        //delete doctor 
        public bool deleteDoctor(int doctorId)
        {
            var doctorModal = new DoctorModal();
            
            var doctorDetail = dbContext.Doctor.FirstOrDefault(x => x.Id == doctorId);
            if (doctorDetail != null)
            {
                doctorDetail.Name = doctorDetail.Name;
                doctorDetail.DepartmentId = doctorDetail.DepartmentId;
                doctorDetail.IsActive = false;
                doctorDetail.IsDelete = true;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }


        //get list of all departments
        public List<DepartmentModal> getAllDepartments()
        {
            var departmentList = new List<DepartmentModal>();
            departmentList = dbContext.Department.Select(x => new DepartmentModal()
            {
                DepartmentId = x.Id,
                DepartmentName = x.Name
            }).ToList();
            return departmentList;
        }


        //get list of doctor details
        public List<DoctorWithDepartment> getDoctorDetails()
        {
            var doctorDetails = new List<DoctorWithDepartment>();
            
            doctorDetails = dbContext.Doctor.Where(x => x.IsDelete == false).Join(
                                    dbContext.Department,
                                    doctor => doctor.Id,
                                    department => department.Id,
                                    (doctor, department) => new DoctorWithDepartment()
                                    {
                                        DoctorId = doctor.Id,
                                        DoctorName = doctor.Name,
                                        DepartmentName = department.Name
                                    }).ToList();
            return doctorDetails;
            
        }

        //get list of doctor's patients
        public List<DoctorPatientsModal> getListOfDoctorPatients()
        {
            var result =  dbContext.DoctorPatientsList.Select(x=> new DoctorPatientsModal()
            {
                DoctorName = x.DoctorName,
                PatientName = x.PatientName
            }).ToList();
            return result;
        }

        //get list of patient's medicine
        public List<PatientMedicinesModel> getListOfPatientsMedicine()
        {
            var result = dbContext.PatientMedicinesList.Select(x=> new PatientMedicinesModel()
            {
                PatientName = x.PatientName,
                MedicineName = x.MedicineName
            }).ToList();
            return result;
        }

        //get list of patient summary report
        public List<SummaryReportOfPatient> summaryReportOfDoctorPatient()
        {
            var result = dbContext.PatientReport.Include(x => x.Doctor).Include(y => y.Patient).Select
                (x=> new SummaryReportOfPatient()
                {
                    DoctorName = x.Doctor.Name,
                    PatientName = x.Patient.Name,
                    VisitDateTime = x.VisitDateTime,
                    BloodPressure = x.BloodPressure,
                    Status = x.Status
                }).ToList();
            return result;
        }

        //update doctor details
        public string updateDoctorDetail(DoctorWithDepartment doctorDeptModal)
        {
            var doctorDetail = dbContext.Doctor.FirstOrDefault(x => x.Id == doctorDeptModal.DoctorId);
            var departmentDetail = dbContext.Department.FirstOrDefault(x => x.Name == doctorDeptModal.DepartmentName);
            if (doctorDetail != null && departmentDetail != null)
            {
                doctorDetail.Name = doctorDeptModal.DoctorName;
                doctorDetail.DepartmentId = departmentDetail.Id;
                dbContext.SaveChanges();
                return "Successfully Update Doctor Details.";
            }
            return "Doctor does not exist."; 
        }
    }
}
