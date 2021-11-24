using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day9Task.Assignment.Models
{
    public partial class Patient
    {
        public Patient()
        {
            DoctorPatientData = new HashSet<DoctorPatientData>();
            PatientMedicine = new HashSet<PatientMedicine>();
            PatientReport = new HashSet<PatientReport>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AssistantId { get; set; }

        public virtual Assistant Assistant { get; set; }
        public virtual ICollection<DoctorPatientData> DoctorPatientData { get; set; }
        public virtual ICollection<PatientMedicine> PatientMedicine { get; set; }
        public virtual ICollection<PatientReport> PatientReport { get; set; }
    }
}
