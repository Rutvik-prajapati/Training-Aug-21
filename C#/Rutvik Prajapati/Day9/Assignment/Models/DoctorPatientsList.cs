using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day9Task.Assignment.Models
{
    public partial class DoctorPatientsList
    {
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public int? CountOfPatient { get; set; }
    }
}
