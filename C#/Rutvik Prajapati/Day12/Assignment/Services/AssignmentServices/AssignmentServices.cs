using Day12Task.API.Model;
using Day12Task.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day12Task.API.Services.AssignmentServices
{
    public class AssignmentServices : IAssignmentServices
    {
        public EmployeeDBContext dbContext { get; set; }
        public AssignmentServices(EmployeeDBContext employeeDBContext)
        {
            this.dbContext = employeeDBContext;
        }

        //create new assignment
        public string createNewAssignment(Int64 employeeId, AssignmentModel assignmentModel)
        {
            var assignment = dbContext.Assignments.Where(x => x.AssignmentNumber == assignmentModel.AssignmentNumber).FirstOrDefault();
            if (assignment == null)
            {
                var newAssignment = new Assignment()
                {
                    AssignmentName = assignmentModel.AssignmentName,
                    AssignmentNumber = assignmentModel.AssignmentNumber
                };
                dbContext.Assignments.Add(newAssignment);
                dbContext.SaveChanges();

                var employeeAssignment = new Employee_Assignment()
                {
                    AssignmentId = newAssignment.AssignmentId,
                    EmployeeId = employeeId
                };
                dbContext.Employee_Assignments.Add(employeeAssignment);
                dbContext.SaveChanges();
                return "successfully create assignment";
            }

            var employeeAssignments = new Employee_Assignment()
            {
                AssignmentId = assignment.AssignmentId,
                EmployeeId = employeeId
            };
            dbContext.Employee_Assignments.Add(employeeAssignments);
            dbContext.SaveChanges();

            return "successfully create assignment";
        }

        //get list of assignment by employeeId
        public List<AssignmentModel> getAllAssignment(Int64 employeeId)
        {
            var listOfAssignment = new List<AssignmentModel>();

            listOfAssignment = (from a in dbContext.Assignments
                               join ea in dbContext.Employee_Assignments
                               on a.AssignmentId equals ea.AssignmentId
                               where ea.EmployeeId == employeeId
                               select new AssignmentModel()
                               {
                                   AssignmentId = a.AssignmentId,
                                   AssignmentName = a.AssignmentName,
                                   AssignmentNumber = a.AssignmentNumber
                               }).ToList();

            return listOfAssignment;
        }

        //get assignment Detail by employeeId and assignmentId
        public AssignmentModel getAssignment(Int64 employeeId, Int64 assignmentId)
        {
            var employeeAssignment = new AssignmentModel();

            employeeAssignment = (from a in dbContext.Assignments
                                join ea in dbContext.Employee_Assignments
                                on a.AssignmentId equals ea.AssignmentId
                                where ea.EmployeeId == employeeId && a.AssignmentId == assignmentId
                                select new AssignmentModel()
                                {
                                    AssignmentId = a.AssignmentId,
                                    AssignmentName = a.AssignmentName,
                                    AssignmentNumber = a.AssignmentNumber
                                }).FirstOrDefault();

            return employeeAssignment;
        }

        //update assignment by employeeId and assignmentId
        public string updateAssignment(Int64 employeeId, Int64 assignmentId,AssignmentModel assignmentModel)
        {
            var assignmentDetail = dbContext.Assignments.Where(x => x.AssignmentId == assignmentId).FirstOrDefault();
            assignmentDetail.AssignmentName = assignmentModel.AssignmentName;
            assignmentDetail.AssignmentNumber = assignmentModel.AssignmentNumber;
            dbContext.SaveChanges();
            return "successfully update assignment";
        }
    }
}
