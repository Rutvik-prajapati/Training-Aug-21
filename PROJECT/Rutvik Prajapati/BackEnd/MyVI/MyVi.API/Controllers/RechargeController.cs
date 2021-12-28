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
    public class RechargeController : Controller
    {
        private readonly IRecharge recharge;
        private readonly IUser user;
        private readonly IPlan plan;
        public RechargeController(IRecharge context, IUser _user, IPlan _plan)
        {
            recharge = context;
            user = _user;
            plan = _plan;
        }

        // POST: api/myvi/Recharge/NewRecharge
        //[Authorize]
        [HttpPost]
        [Route("NewRecharge")]
        public ActionResult<IEnumerable> NewRecharge([FromBody] RechargeModel model)
        {
            if (model.UserId <= 0 || model.PlanId <= 0 ||
                string.IsNullOrEmpty(model.CardNumber)|| string.IsNullOrEmpty(model.Expiry) ||
                model.Cvv <= 0 )
                return BadRequest("Invalid data.");
            if (model.CardNumber.Length < 16)
            {
                return BadRequest("Invalid card detail.");
            }

            if (user.CheckUserExist(model.UserId) == false)
                return Ok(new { Status = "fail", Message = "UserId does not exist" });
            else if (plan.CheckPlanExist(model.PlanId) == false)
                return Ok(new { Status = "fail", Message = "PlanId does not exist" });
            else
            {
                recharge.Create(model);
                return Ok(new { Status = "Success", Message = "Successfully recharge" });
            } 
        }


        // DELETE: api/myvi/Recharge/DeleteRecharge
        //[Authorize(Roles = "Admin")]
        [HttpDelete]
        [Route("DeleteRecharge")]
        public ActionResult<IEnumerable> DeleteRechargeRecord(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid Id.");

            recharge.Delete(id);

            return Ok(new { Status = "Success", Message = "Successfully delete recharge record" });
        }

        // GET: api/myvi/Recharge/GetAllRecharge
        //[Authorize]
        [HttpGet]
        [Route("GetAllRecharge")]
        public ActionResult<IEnumerable> GetAllRechargeRecord()
        {
            var rechargeList = recharge.GetAllRecharge();

            if (rechargeList == null)
            {
                return NotFound(rechargeList);
            }

            return Ok(rechargeList);
        }

        // GET: api/myvi/PortNumber/GetRechargeById
        //[Authorize]
        [HttpGet]
        [Route("GetRechargeById")]
        public ActionResult<IEnumerable> GetRechargeById(int id)
        {
            var rechargeDetail = new RechargeDetailModel();
            if (id <= 0)
                return BadRequest("Invalid Id");
            else if (recharge.CheckRechargeIdExist(id) == false)
                return Ok(new { Status = "fail", Message = "RechargeId does not exist" });
            else
            {
                rechargeDetail = recharge.GetRechargeDetailById(id);
                if (rechargeDetail == null)
                {
                    return NotFound(rechargeDetail);
                }
                return Ok(rechargeDetail);
            }
        }

        // GET: api/myvi/PortNumber/GetAllRechargeByUserId
        //[Authorize]
        [HttpGet]
        [Route("GetAllRechargeByUserId")]
        public ActionResult<IEnumerable> GetAllRechargeByUserId(int userId)
        {
            //var rechargeList = new List<RechargeDetailModel>();
            if (userId <= 0)
                return BadRequest("Invalid Id");
            else if (user.CheckUserExist(userId) == false)
                return Ok(new { Status = "fail", Message = "UserId does not exist" });
            else
            {
                var rechargeList = recharge.GetAllRechargeByUserId(userId);
                if (rechargeList == null)
                {
                    return NotFound(rechargeList);
                }
                return Ok(rechargeList);
            }
        }
    }
}
