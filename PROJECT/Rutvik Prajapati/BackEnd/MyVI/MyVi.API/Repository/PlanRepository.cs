using MyVi.API.Entities;
using MyVi.API.IRepository;
using MyVi.API.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVi.API.Repository
{
    public class PlanRepository : GenericRepository<PlanModel>, IPlan
    {
        public PlanRepository(MyVIDBContext context) : base(context)
        {

        }

        public override void Create(PlanModel entity)
        {
            context.Plan.Add(new Plan()
            {
                PlanTypeId = entity.PlanTypeId,
                Price = entity.Price,
                Call = entity.Call,
                Data = entity.Data,
                Sms = entity.Sms,
                Validity = entity.Validity,
                Benefits = entity.Benefits,
                IsActive = true,
                IsDeleted = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            });
            context.SaveChanges();
        }

        public override void Delete(int id)
        {
            var registeredPlan = context.Plan.Where(x => x.Id == id).FirstOrDefault();
            registeredPlan.IsDeleted = true;
            registeredPlan.OnUpdated = DateTime.Now;
            context.SaveChanges();
        }

        public override void Update(int id, PlanModel entity)
        {
            var registeredPlan = context.Plan.Where(x => x.Id == id).FirstOrDefault();
            registeredPlan.PlanTypeId = entity.PlanTypeId;
            registeredPlan.Price = entity.Price;
            registeredPlan.Call = entity.Call;
            registeredPlan.Data = entity.Data;
            registeredPlan.Sms = entity.Sms;
            registeredPlan.Validity = entity.Validity;
            registeredPlan.Benefits = entity.Benefits;
            registeredPlan.OnUpdated = DateTime.Now;
            context.SaveChanges();
        }
        public IEnumerable<PlanDetailModel> GetAllPlan()
        {
            var planList = new List<PlanDetailModel>();

            planList = (from p in context.Plan
                        join pt in context.PlanType on p.PlanTypeId equals pt.Id into planInfo
                        from plan in planInfo.DefaultIfEmpty()
                        where p.IsDeleted == false && plan.IsDeleted == false
                        select new PlanDetailModel()
                        {
                            Id = p.Id,
                            PlanTypeName = plan.Name,
                            Price = p.Price,
                            Call = p.Call,
                            Data = p.Data,
                            Sms = p.Sms,
                            Validity = p.Validity,
                            Benefits = p.Benefits
                        }).ToList();
            return planList;
        }

        public PlanDetailModel GetPlanById(int id)
        {
            var planDetail = new PlanDetailModel();
            planDetail = (from p in context.Plan
                          join pt in context.PlanType on p.PlanTypeId equals pt.Id into planInfo
                          from plan in planInfo.DefaultIfEmpty()
                          where p.Id == id
                          select new PlanDetailModel()
                          {
                              Id = p.Id,
                              PlanTypeName = plan.Name,
                              Price = p.Price,
                              Call = p.Call,
                              Data = p.Data,
                              Sms = p.Sms,
                              Validity = p.Validity,
                              Benefits = p.Benefits
                          }).FirstOrDefault();
            return planDetail;
        }

        public bool CheckPlanExist(int planId)
        {
            var isExist = false;
            isExist = context.Plan.Any(x => x.Id == planId);
            return isExist;
        }
    }
}
