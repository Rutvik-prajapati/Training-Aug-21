using Day9Task.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using Day9Task.Assignment.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Day9Task.Services.DoctorServices
{
    public class DoctorServices : IDoctorServices
    {
        public string addNewDoctor(DoctorModal doctorModal)
        {
            using (var dbContext = new HospitalDB2021Context())
            {
                try
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
                catch (Exception)
                {
                    return "Something wrong.";
                }

            }
        }

        public bool deleteDoctor(int doctorId)
        {
            var doctorModal = new DoctorModal();
            using (var dbContext = new HospitalDB2021Context())
            {
                var doctorDetail = dbContext.Doctor.FirstOrDefault(x => x.Id == doctorId);
                if (doctorDetail != null)
                {
                    var deleteDoctor = new Doctor()
                    {
                        Name = doctorDetail.Name,
                        DepartmentId = doctorDetail.DepartmentId,
                        IsActive = false,
                        IsDelete = true
                    };
                    dbContext.Doctor.Add(deleteDoctor);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public List<DepartmentModal> getAllDepartments()
        {
            var departmentList = new List<DepartmentModal>();
            using (var dbContext = new HospitalDB2021Context())
            {
                departmentList = dbContext.Department.Select(x => new DepartmentModal()
                {
                    DepartmentId = x.Id,
                    DepartmentName = x.Name
                }).ToList();
                //var result = dbContext.Department.Include(x => x.Doctor).ToList();
                return departmentList;
            }
        }

        public List<DoctorWithDepartment> getDoctorDetails()
        {
            var doctorDetails = new List<DoctorWithDepartment>();
            using (var dbContext = new HospitalDB2021Context())
            {
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
        }

        public void getListOfDoctorPatients()
        {
            
            using (var dbContext = new HospitalDB2021Context())
            {
                var result =  dbContext.DoctorPatientsList.ToList();
                foreach (var item in result)
                {
                    Console.WriteLine($"Doctor Name = {item.DoctorName} \n Patients Name = {item.PatientName} \n\n");
                }
    
            }
        }

        public void getListOfPatientsMedicine()
        {
            using (var dbContext = new HospitalDB2021Context())
            {
                var result = dbContext.PatientMedicinesList.ToList();
                foreach (var item in result)
                {
                    Console.WriteLine($"Patient Name = {item.PatientName} \n Medicines Name = {item.MedicineName} \n\n");
                }
            }
        }

        public void summaryReportOfDoctorPatient()
        {
            using (var dbContext = new HospitalDB2021Context())
            {
                var result = dbContext.PatientReport.Include(x => x.Doctor).Include(y => y.Patient).ToList();

                foreach (var items in result)
                {
                    Console.WriteLine("Summary Report");
                    Console.WriteLine($"Doctor Name = {items.Doctor.Name}");
                    Console.WriteLine($"Patient Name = {items.Patient.Name}");
                    Console.WriteLine($"Date = {items.VisitDateTime}");
                    Console.WriteLine($"Blood Pressure : {items.BloodPressure} Sugar : {items.Sugar}  HartBeat : {items.HartBeat} ");
                    Console.WriteLine($"Status = {items.Status} \n\n");
                }
            }
        }

        public string updateDoctorDetail(DoctorWithDepartment doctorDeptModal)
        {
            using (var dbContext = new HospitalDB2021Context())
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
                return "Something Wrong.";
            }
        }
    }
}
