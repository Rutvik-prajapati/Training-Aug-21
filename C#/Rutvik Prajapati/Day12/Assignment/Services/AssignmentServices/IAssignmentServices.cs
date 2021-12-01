using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day12Task.API.Model;

namespace Day12Task.API.Services.AssignmentServices
{
    public interface IAssignmentServices
    {
        string createNewAssignment(Int64 employeeId,AssignmentModel assignmentModel);
        List<AssignmentModel> getAllAssignment(Int64 employeeId);
        AssignmentModel getAssignment(Int64 employeeId, Int64 assignmentId);
        string updateAssignment(Int64 employeeId, Int64 assignmentId,AssignmentModel assignmentModel);
    }
}
