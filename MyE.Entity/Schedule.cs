using System;
using System.Collections.Generic;
namespace MyE.Entity
{
    public class Schedule
    {
        public int Id {get;set;}
        public DateTime AgreedDate {get;set;}
        public DateTime ArrivalDate {get;set;}
        //
        public virtual int UserId {get;set;}
        public virtual int OrderId {get;set;}
        public virtual ICollection<MachineReview> MachineReviews {get;set;}

    }
}