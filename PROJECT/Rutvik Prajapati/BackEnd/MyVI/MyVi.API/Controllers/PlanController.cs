using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyVi.API.IRepository;
using MyVi.API.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVi.API.Controllers
{
    [Route("api/myvi/[controller]")]
    [ApiController]
    public class PlanController : Controller
    {
        private readonly IPlan plan;

        public PlanController(IPlan context)
        {
            plan= context;
        }
        // POST: api/myvi/Plan/AddNewPlan
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("AddNewPlan")]
        public ActionResult<IEnumerable> CreateNewPlan([FromBody] PlanModel model)
        {
            if (model.PlanTypeId <= 0 || model.Price <= 0 ||
                string.IsNullOrEmpty(model.Call)|| string.IsNullOrEmpty(model.Data) ||
                string.IsNullOrEmpty(model.Sms) || model.Validity <= 0 ||
                string.IsNullOrEmpty(model.Benefits))
                return BadRequest("Invalid data.");

            plan.Create(model);

            return Ok(new {Status="Success",Message="Successfully created plan" });
        }

        // POST: api/myvi/Plan/UpdatePlan
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("UpdatePlan")]
        public ActionResult<IEnumerable> UpdatePlan(int id,[FromBody] PlanModel model)
        {
            if (model.PlanTypeId <= 0 || model.Price <= 0 ||
                string.IsNullOrEmpty(model.Call)|| string.IsNullOrEmpty(model.Data)||
                string.IsNullOrEmpty(model.Sms)|| model.Validity <= 0 ||
                string.IsNullOrEmpty(model.Benefits)|| id <= 0)
                return BadRequest("Invalid data.");

            plan.Update(id,model);

            return Ok(new { Status = "Success", Message = "Successfully updated plan" });
        }

        // POST: api/myvi/Plan/DeletePlan
        //[Authorize(Roles = "Admin")]
        [HttpDelete]
        [Route("DeletePlan")]
        public ActionResult<IEnumerable> DeletePlan(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid data.");

            plan.Delete(id);

            return Ok(new { Status = "Success", Message = "Successfully delete plan" });
        }

        // GET: api/myvi/Plan/GetAllPlan
        //[Authorize]
        [HttpGet]
        [Route("GetAllPlan")]
        public ActionResult<IEnumerable> GetAllPlan()
        {
            var planList = plan.GetAllPlan();

            if (planList == null)
            {
                return NotFound(planList);
            }

            return Ok(planList);
        }

        // GET: api/myvi/Plan/GetPlanById
        //[Authorize]
        [HttpGet]
        [Route("GetPlanById")]
        public ActionResult<IEnumerable> GetPlanById(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid Data");

            var planDetail = plan.GetPlanById(id);

            if (planDetail == null)
            {
                return NotFound(planDetail);
            }

            return Ok(planDetail);
        }
    }
}
