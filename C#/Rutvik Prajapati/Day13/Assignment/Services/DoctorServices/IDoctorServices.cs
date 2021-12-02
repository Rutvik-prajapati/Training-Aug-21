using System;
using System.Collections.Generic;
using System.Text;
using Day13Task.API.Modal;

namespace Day13Task.API.Services.DoctorServices
{
    public interface IDoctorServices
    {
        string addNewDoctor(DoctorModal doctorModal);
        string updateDoctorDetail(DoctorWithDepartment doctorDeptModal);
        bool deleteDoctor(int doctorId);
        List<DoctorWithDepartment> getDoctorDetails();
        List<DepartmentModal> getAllDepartments();
        List<DoctorPatientsModal> getListOfDoctorPatients();
        List<PatientMedicinesModel> getListOfPatientsMedicine();
        List<SummaryReportOfPatient> summaryReportOfDoctorPatient();
        
    }
}
