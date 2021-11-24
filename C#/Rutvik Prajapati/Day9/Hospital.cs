using System;
using System.Collections.Generic;
using System.Text;
using Day9Task.Services.DoctorServices;
using Day9Task.Modal;

namespace Day9Task
{
    public class Hospital
    {
        private IDoctorServices _doctorServices;
        public Hospital(IDoctorServices doctorServices)
        {
            this._doctorServices = doctorServices;
        }

        public static void InsertNewDoctorDetail()
        {
            IDoctorServices doctorServices = new DoctorServices();
            Hospital hospital = new Hospital(doctorServices);

            try
            {
                var departmentList = new List<DepartmentModal>();
                var newDoctorDetail = new DoctorModal();

                Console.WriteLine("Enter Doctor Name:");
                newDoctorDetail.Name = Console.ReadLine();
                Console.WriteLine("Choose any one department and enter their department id");
                departmentList = doctorServices.getAllDepartments();
                foreach (var department in departmentList)
                {
                    Console.WriteLine($"Id = {department.DepartmentId}  Department Name = {department.DepartmentName}");
                }
                newDoctorDetail.DepartmentId = Convert.ToInt32(Console.ReadLine());
                var result = doctorServices.addNewDoctor(newDoctorDetail);
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static void UpdateDoctorDetail()
        {
            IDoctorServices doctorServices = new DoctorServices();
            Hospital hospital = new Hospital(doctorServices);
            try
            {
                List<DoctorWithDepartment> doctorDetailsList = new List<DoctorWithDepartment>();
                var updateDoctorDetail = new DoctorWithDepartment();

                Console.WriteLine("List of Doctor Given below:");
                doctorDetailsList = doctorServices.getDoctorDetails();

                foreach (var doctorDetail in doctorDetailsList)
                {
                    Console.WriteLine($"DoctorId = {doctorDetail.DoctorId} Doctor Name = {doctorDetail.DoctorName} and their Department Name = {doctorDetail.DepartmentName}");
                }
                Console.WriteLine("Enter DoctorId which you want to update Doctor Detail");
                updateDoctorDetail.DoctorId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter DoctorName :");
                updateDoctorDetail.DoctorName = Console.ReadLine();
                Console.WriteLine("Enter Department Name :");
                updateDoctorDetail.DepartmentName = Console.ReadLine();
                var result = doctorServices.updateDoctorDetail(updateDoctorDetail);
                Console.WriteLine(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void DeleteDoctorDetail()
        {
            IDoctorServices doctorServices = new DoctorServices();
            Hospital hospital = new Hospital(doctorServices);

            List<DoctorWithDepartment> doctorDetailsList = new List<DoctorWithDepartment>();

            Console.WriteLine("List of Doctor are given below");
            doctorDetailsList = doctorServices.getDoctorDetails();
            foreach (var doctorDetail in doctorDetailsList)
            {
                Console.WriteLine($"Doctor Id = {doctorDetail.DoctorId} Doctor Name = {doctorDetail.DoctorName} and their Department Name = {doctorDetail.DepartmentName}");
            }
            Console.WriteLine("Enter Doctor id which you want to delete :");
            var doctorId = Convert.ToInt32(Console.ReadLine());
            var isDeleted = doctorServices.deleteDoctor(doctorId);
            if (isDeleted)
            {
                Console.WriteLine("Successfully Delete Doctor.");
            }
            else
                Console.WriteLine("Something wrong");
        }

        public static void GetListOfDoctorPatients()
        {
            IDoctorServices doctorServices = new DoctorServices();
            Hospital hospital = new Hospital(doctorServices);
                    
            Console.WriteLine("Doctor's  Patients List Given Below:");
            doctorServices.getListOfDoctorPatients();
        }

        public static void GetListOfPatientsMedicine()
        {
            IDoctorServices doctorServices = new DoctorServices();
            Hospital hospital = new Hospital(doctorServices);

            Console.WriteLine("Patient's Medicine List Given Below:");
            doctorServices.getListOfPatientsMedicine();
        }

        public static void SummaryReportOfDoctorPatient()
        {
            IDoctorServices doctorServices = new DoctorServices();
            Hospital hospital = new Hospital(doctorServices);

            Console.WriteLine("Doctor-patient summary reports :");
            doctorServices.summaryReportOfDoctorPatient();
        }
        public static void GetDoctorDetails()
        {
            IDoctorServices doctorServices = new DoctorServices();
            Hospital hospital = new Hospital(doctorServices);

            List<DoctorWithDepartment> doctorDetailsList = new List<DoctorWithDepartment>();

            Console.WriteLine("Get Doctor Details:");
            doctorDetailsList = doctorServices.getDoctorDetails();

            foreach (var doctorDetail in doctorDetailsList)
            {
                Console.WriteLine($"Doctor Name = {doctorDetail.DoctorName} and their Department Name = {doctorDetail.DepartmentName}");
            }
        }
    }
}
