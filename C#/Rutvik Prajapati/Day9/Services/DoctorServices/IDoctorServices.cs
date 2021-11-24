using System;
using System.Collections.Generic;
using System.Text;
using Day9Task.Modal;

namespace Day9Task.Services.DoctorServices
{
    public interface IDoctorServices
    {
        string addNewDoctor(DoctorModal doctorModal);
        string updateDoctorDetail(DoctorWithDepartment doctorDeptModal);
        bool deleteDoctor(int doctorId);
        List<DoctorWithDepartment> getDoctorDetails();
        List<DepartmentModal> getAllDepartments();
        void getListOfDoctorPatients();
        void getListOfPatientsMedicine();
        void summaryReportOfDoctorPatient();
        
    }
}
