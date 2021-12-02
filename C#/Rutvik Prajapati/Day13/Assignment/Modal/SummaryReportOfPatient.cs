using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day13Task.API.Modal
{
    public class SummaryReportOfPatient
    {
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public int BloodPressure { get; set; }
        public DateTime VisitDateTime { get; set; }
        public int Status { get; set; }
    }
}
