using System.Collections.Generic;
using System;

namespace MyE.Entity
{
    public class MachineReview
    {
        public int Id {get;set;}
       public DateTime ReviewDate {get;set;}

        public virtual ICollection<FinalReport> FinalReports { get; set; }
        //
        public virtual int ScheduleId {get;set;} 

    }
}