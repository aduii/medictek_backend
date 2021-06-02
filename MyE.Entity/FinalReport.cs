using System;

namespace MyE.Entity
{
    public class FinalReport
    {
        public int Id {get;set;}
        public string Description {get;set;}
        public DateTime ReportDate {get;set;}
        //
        public virtual int MachineReviewId {get;set;}
 
    }
}