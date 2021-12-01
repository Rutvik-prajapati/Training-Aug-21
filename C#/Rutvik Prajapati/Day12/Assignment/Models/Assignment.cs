using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day12Task.API.Models
{
    public class Assignment
    {
        public string ActionCode { get; set; }
        public string ActionReasonCode { get; set; }
        public DateTime? ActualTerminationDate { get; set; }
        public string AssignmentCategory { get; set; }
        public string assignmentDFF { get; set; }
        public int? assignmentExtraInformation { get; set; }

        [Key]
        public Int64 AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public string AssignmentNumber { get; set; }
        public DateTime? AssignmentProjectedEndDate { get; set; }
        public string AssignmentStatus { get; set; }
        public Int64? AssignmentStatusTypeId { get; set; }
        public Int64? BusinessUnitId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string DefaultExpenseAccount { get; set; }
        public Int64? DepartmentId { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public string empreps { get; set; }
        public string EndTime { get; set; }
        public string Frequency { get; set; }
        public string FullPartTime { get; set; }
        public Int64? GradeId { get; set; }
        public Int64? GradeLadderId { get; set; }
        public Int64? JobId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public Int64? LegalEntityId { get; set; }
        public string links { get; set; }
        public Int64? LocationId { get; set; }
        public Int64? ManagerAssignmentId { get; set; }
        public Int64? ManagerId { get; set; }

        public ICollection<Employee_Assignment> Employee_Assignments { get; set; }
    }
}
