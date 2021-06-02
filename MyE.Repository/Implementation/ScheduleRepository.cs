using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository.Context;
using System.Linq;

namespace MyE.Repository.Implementation
{
    public class ScheduleRepository : IScheduleRepository
    {
        private ApplicationDbContext context;
        public ScheduleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
         public bool Delete(int id)
        {
            try
            {
                var result = new Schedule();
                result = context.Schedules.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public Schedule Get(int id)
        {
            var result = new Schedule();
            try {
                result = context.Schedules.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Schedule> GetAll()
        {
           var result = new List<Schedule>();
            try{
                result = context.Schedules.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Schedule entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Schedule entity)
        {
            try{
                var newSchedule = context.Schedules.Single(x => x.Id == entity.Id);
                newSchedule.Id = entity.Id;
                newSchedule.AgreedDate = entity.AgreedDate;
                newSchedule.ArrivalDate = entity.ArrivalDate;
            }
            catch(System.Exception)
            {
                return true;
            }
            return false;
        }
        public IEnumerable<Schedule> GetSchedulerByUser(int userId)
        {
            try
            {
                var Schedules = context.Schedules.Where(x => x.UserId == userId);
                return Schedules;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
        public IEnumerable<Schedule> GetSchedulerByoRDER(int orderId)
        {
            try
            {
                var Schedules = context.Schedules.Where(x => x.OrderId == orderId);
                return Schedules;
            }
            catch (System.Exception)
            {
                return null;
            }

        }
    }
}