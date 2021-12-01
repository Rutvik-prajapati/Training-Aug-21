using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day12Task.API.Services.AssignmentServices;
using Day12Task.API.Model;

namespace Day12Task.API.Controllers
{
    [ApiController]
    [Route("api/emps")]
    [Produces("application/json")]
    public class AssignmentController : Controller
    {
        private IAssignmentServices _assignmentServices;
        public AssignmentController(IAssignmentServices assignmentServices)
        {
            this._assignmentServices = assignmentServices;
        }

        //create new Assignment by employeeId
        [Route("{employeeId}/child/assignments")]
        [HttpPost]
        public string CreateNewAssignment(Int64 employeeId,[FromBody] AssignmentModel assignmentModel)
        {
            var response = "";
            try
            {
                if (assignmentModel != null)
                {
                    response = _assignmentServices.createNewAssignment(employeeId,assignmentModel);
                    if (response == null)
                    {
                        return NotFound().ToString();
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //get employeeId by all assignment 
        [Route("{employeeId}/child/assignment")]
        [HttpPost]
        public List<AssignmentModel> GetAllAssignment(Int64 employeeId)
        {
            var response = new List<AssignmentModel>();
            try
            {
                if (employeeId != 0 && employeeId>0)
                {
                    response = _assignmentServices.getAllAssignment(employeeId);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //get assignment by employeeId and assignmentId
        [Route("{employeeId}/child/assignments/{assignmentId}")]
        [HttpPost]
        public AssignmentModel GetEmployeeAllAssignment(Int64 employeeId, Int64 assignmentId)
        {
            var response = new AssignmentModel();
            try
            {
                if (assignmentId != 0 && employeeId != 0 && employeeId>0 && assignmentId>0)
                {
                    response = _assignmentServices.getAssignment(employeeId,assignmentId);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //update assignment by employeeId and assignmentId
        [Route("{employeeId}/child/assignment/{assignmentId}")]
        [HttpPost]
        public string UpdateAssignment(Int64 employeeId, Int64 assignmentId,AssignmentModel assignmentModel)
        {
            var response = "";
            try
            {
                if (assignmentId != 0 && employeeId != 0 && employeeId > 0 && assignmentId > 0 && assignmentModel != null)
                {
                    response = _assignmentServices.updateAssignment(employeeId, assignmentId,assignmentModel);
                    if (response == null)
                    {
                        return NotFound().ToString();
                    }
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
