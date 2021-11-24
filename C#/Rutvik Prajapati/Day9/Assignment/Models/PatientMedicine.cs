using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day9Task.Assignment.Models
{
    public partial class PatientMedicine
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int MedicineId { get; set; }
        public int DayPart { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
