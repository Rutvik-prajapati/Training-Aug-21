using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day13Task.API.Entities
{
    public partial class Doctor
    {
        public Doctor()
        {
            Assistant = new HashSet<Assistant>();
            DoctorPatientData = new HashSet<DoctorPatientData>();
            PatientReport = new HashSet<PatientReport>();
        }

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Assistant> Assistant { get; set; }
        public virtual ICollection<DoctorPatientData> DoctorPatientData { get; set; }
        public virtual ICollection<PatientReport> PatientReport { get; set; }
    }
}
