using MyE.Entity;
using System.Collections.Generic;

namespace MyE.Repository
{
    public interface IMachineReviewRepository:ICrudRepository<MachineReview>
    {
       IEnumerable<MachineReview> GetFinalReportsBySchedule(int scheduleId);
    }
}