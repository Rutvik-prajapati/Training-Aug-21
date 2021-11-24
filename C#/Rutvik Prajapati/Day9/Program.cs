using System;
using Day9Task.Assignment.Models;
using Day9Task.Services.DoctorServices;
using Day9Task.Modal;
using System.Collections.Generic;

namespace Day9Task
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hospital Management System");
                Console.WriteLine("Select Any one Option");
                Console.WriteLine("\n 1.Insert Doctor " +
                                  "\n 2.Update Doctor " +
                                  "\n 3.Delete Doctor " +
                                  "\n 4.Find a report of patient assigned to a particular doctor" +
                                  "\n 5.Find a report of medicine list for a particular patient" +
                                  "\n 6.Display summary report of Doctor and patient (use Include method)" +
                                  "\n 7.Get Doctor Details" +
                                  "\n 8.Exit");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Hospital.InsertNewDoctorDetail();
                        break;
                    case 2:
                        Hospital.UpdateDoctorDetail();
                        break;
                    case 3:
                        Hospital.DeleteDoctorDetail();
                        break;
                    case 4:
                        Hospital.GetListOfDoctorPatients();
                        break;
                    case 5:
                        Hospital.GetListOfPatientsMedicine();
                        break;
                    case 6:
                        Hospital.SummaryReportOfDoctorPatient();
                        break;
                    case 7:
                        Hospital.GetDoctorDetails();
                        break;
                    case 8:
                        return;
                    default:
                        break;
                }
            }   
        }
    }
}
