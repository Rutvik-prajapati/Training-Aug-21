using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day13Task.API.Entities
{
    public partial class PatientMedicinesList
    {
        public string PatientName { get; set; }
        public string MedicineName { get; set; }
        public int? CountMedicine { get; set; }
    }
}
