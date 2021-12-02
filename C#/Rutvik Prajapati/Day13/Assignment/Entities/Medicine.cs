using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day13Task.API.Entities
{
    public partial class Medicine
    {
        public Medicine()
        {
            PatientMedicine = new HashSet<PatientMedicine>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PatientMedicine> PatientMedicine { get; set; }
    }
}
