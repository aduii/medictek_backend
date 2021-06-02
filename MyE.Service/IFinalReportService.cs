using MyE.Entity;
using System.Collections.Generic;

namespace MyE.Service
{
    public interface IFinalReportService:ICrudService<FinalReport>
    {
         IEnumerable<FinalReport> GetFinalReportsByMemberShip(int membershipId);
    }
}