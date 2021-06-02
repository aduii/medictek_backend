using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository.Context;
using System.Linq;

namespace MyE.Repository.Implementation
{
    public class FinalReportRepository : IFinalReportRepository
    {
        private ApplicationDbContext context;
        public FinalReportRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new FinalReport();
                result = context.FinalReports.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public FinalReport Get(int id)
        {
            var result = new FinalReport();
            try {
                result = context.FinalReports.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<FinalReport> GetAll()
        {
            var result = new List<FinalReport>();
            try{
                result = context.FinalReports.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(FinalReport entity)
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

        public bool Update(FinalReport entity)
        {
            try{
                var newFinalReport = context.FinalReports.Single(x => x.Id == entity.Id);
                newFinalReport.Id = entity.Id;
                newFinalReport.Description = entity.Description;
                newFinalReport.ReportDate = entity.ReportDate;
                context.Update(newFinalReport);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return true;
            }
            return false;
        }
    
    }
}