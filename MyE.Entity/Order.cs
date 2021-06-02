using System;
using System.Collections.Generic;

namespace MyE.Entity
{
    public class Order
    {
        public int Id {get;set;}
        public int Priority {get;set;}
        public DateTime Date {get;set;}
        public string description {get;set;}
        public virtual ICollection<Schedule> Schedules {get;set;}
        //  
        public virtual int MedicalEquipamentId {get;set;}
    }
}