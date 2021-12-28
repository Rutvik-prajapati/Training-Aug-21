using MyVi.API.Entities;
using MyVi.API.IRepository;
using MyVi.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVi.API.Repository
{
    public class RechargeRepository : GenericRepository<RechargeModel>, IRecharge
    {
        public RechargeRepository(MyVIDBContext context) : base(context)
        {

        }

        public override void Create(RechargeModel entity)
        {
            var newPaymentCard = new PaymentCard()
            {
                CardNumber = entity.CardNumber,
                Expiry = entity.Expiry,
                Cvv = entity.Cvv,
                IsActive = true,
                IsDeleted = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            };
            context.PaymentCard.Add(newPaymentCard);
            context.SaveChanges();

            context.UserRechargeHistory.Add(new UserRechargeHistory()
            {
                UserId = entity.UserId,
                PlanId = entity.PlanId,
                PaymentCardId = newPaymentCard.Id,
                IsActive = true,
                IsDeleted = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            });
            context.SaveChanges();
        }

        public override void Update(int id, RechargeModel entity)
        {
            var rechargeRecord = context.UserRechargeHistory.Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault();
            rechargeRecord.UserId = entity.UserId;
            rechargeRecord.PlanId = entity.PlanId;
            rechargeRecord.OnUpdated = DateTime.Now;
            context.SaveChanges();

            var paymentCard = context.PaymentCard.Where(x => x.Id == rechargeRecord.PaymentCardId && x.IsDeleted == false).FirstOrDefault();
            paymentCard.CardNumber = entity.CardNumber;
            paymentCard.Expiry = entity.Expiry;
            paymentCard.Cvv = entity.Cvv;
            paymentCard.OnUpdated = DateTime.Now;
            context.SaveChanges();
        }

        //public override IEnumerable<RechargeModel> GetAll()
        //{
        //    var rechargeList = new List<RechargeModel>();
        //    rechargeList = context.UserRechargeHistory.Where(x=>x.IsDeleted == false)
        //        .Select(x => new RechargeModel()
        //    {
        //        Id = x.Id,
        //        UserId = x.UserId,
        //        PlanId = x.PlanId,
        //        CardNumber = x.PaymentCard.CardNumber,
        //        Expiry = x.PaymentCard.Expiry,
        //        Cvv = x.PaymentCard.Cvv
        //    }).ToList();

        //    return rechargeList;
        //}

        public override void Delete(int id)
        {
            var rechargeDetail = context.UserRechargeHistory.Where(x => x.Id == id).FirstOrDefault();
            rechargeDetail.IsDeleted = true;
            rechargeDetail.OnUpdated = DateTime.Now;
            context.SaveChanges();
        }

        public RechargeDetailModel GetRechargeDetailById(int id)
        {
            var recharge = new RechargeDetailModel();
            recharge = context.UserRechargeHistory.Where(x => x.IsDeleted == false && x.Id == id)
                .Select(x => new RechargeDetailModel()
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    ContactNo = x.User.ContactNo,
                    PlanId = x.PlanId,
                    PlanTypeId = x.Plan.PlanTypeId,
                    Price = x.Plan.Price,
                    Call = x.Plan.Call,
                    Data = x.Plan.Data,
                    Sms = x.Plan.Sms,
                    Validity = x.Plan.Validity,
                    Benefits = x.Plan.Benefits,
                    CardNumber = x.PaymentCard.CardNumber,
                    Expiry = x.PaymentCard.Expiry,
                    Cvv = x.PaymentCard.Cvv
                }).FirstOrDefault();

            return recharge;
        }

        public IEnumerable<RechargeDetailModel> GetAllRecharge()
        {
            var rechargeList = new List<RechargeDetailModel>();
            rechargeList = context.UserRechargeHistory.Where(x => x.IsDeleted == false)
                .Select(x => new RechargeDetailModel()
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    ContactNo = x.User.ContactNo,
                    PlanId = x.PlanId,
                    PlanTypeId = x.Plan.PlanTypeId,
                    Price = x.Plan.Price,
                    Call = x.Plan.Call,
                    Data = x.Plan.Data,
                    Sms = x.Plan.Sms,
                    Validity = x.Plan.Validity,
                    Benefits = x.Plan.Benefits,
                    CardNumber = x.PaymentCard.CardNumber,
                    Expiry = x.PaymentCard.Expiry,
                    Cvv = x.PaymentCard.Cvv
                }).ToList();

            return rechargeList;
        }

        public IEnumerable<RechargeDetailModel> GetAllRechargeByUserId(int userId)
        {
            var rechargeList = new List<RechargeDetailModel>();

            rechargeList = context.UserRechargeHistory.Where(x =>x.UserId == userId && x.IsDeleted == false)
                .Select(x => new RechargeDetailModel()
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    ContactNo = x.User.ContactNo,
                    PlanId = x.PlanId,
                    PlanTypeId = x.Plan.PlanTypeId,
                    Price = x.Plan.Price,
                    Call = x.Plan.Call,
                    Data = x.Plan.Data,
                    Sms = x.Plan.Sms,
                    Validity = x.Plan.Validity,
                    Benefits = x.Plan.Benefits,
                    CardNumber = x.PaymentCard.CardNumber,
                    Expiry = x.PaymentCard.Expiry,
                    Cvv = x.PaymentCard.Cvv
                }).ToList();

            return rechargeList;
        }

        public bool CheckRechargeIdExist(int planId)
        {
            var isExist = false;
            isExist = context.UserRechargeHistory.Any(x => x.Id == planId);
            return isExist;
        }
    }
}
