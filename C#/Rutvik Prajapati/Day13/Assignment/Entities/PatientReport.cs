using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day13Task.API.Entities
{
    public partial class PatientReport
    {
        public int Id { get; set; }
        public DateTime VisitDateTime { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int Sugar { get; set; }
        public int BloodPressure { get; set; }
        public int HartBeat { get; set; }
        public int Status { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
