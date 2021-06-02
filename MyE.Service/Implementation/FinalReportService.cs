using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository;
namespace MyE.Service.implementation
{
    public class FinalReportService : IFinalReportService
    {
        private IFinalReportRepository finalReportRepository;
        public FinalReportService(IFinalReportRepository finalReportRepository)
        {
           this.finalReportRepository = finalReportRepository;
        }
       public bool Delete(int id)
        {
           return this.finalReportRepository.Delete(id);
        }

        public FinalReport Get(int id)
        {
           return this.finalReportRepository.Get(id);
        }

        public IEnumerable<FinalReport> GetAll()
        {
           return this.finalReportRepository.GetAll();
        }

        public IEnumerable<FinalReport> GetFinalReportsByMemberShip(int membershipId)
        {
            throw new System.NotImplementedException();
        }

        public bool Save(FinalReport entity)
        {
           return this.finalReportRepository.Save(entity);
        }

        public bool Update(FinalReport entity)
        {
           return this.finalReportRepository.Update(entity);
        }
    }
}