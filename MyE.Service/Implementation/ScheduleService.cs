using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository;
namespace MyE.Service.implementation
{
    public class ScheduleService : IScheduleService
    {
        private IScheduleRepository scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
        }
         public bool Delete(int id)
        {
           return  this.scheduleRepository.Delete(id);
        }

        public Schedule Get(int id)
        {
            return this.scheduleRepository.Get(id);
        }

        public IEnumerable<Schedule> GetAll()
        {
           return this.scheduleRepository.GetAll();
        }

        public bool Save(Schedule entity)
        {
           return  this.scheduleRepository.Save(entity);
        }

        public bool Update(Schedule entity)
        {
            return this.scheduleRepository.Update(entity);
        }
    }
}