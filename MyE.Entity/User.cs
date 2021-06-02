

using System.Collections.Generic;

namespace MyE.Entity
{
    public class User
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Tipodoc { get; set; }
        public string Numdoc { get; set; }
        public string Password { get; set;}
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }   
        //
        public virtual int IdRole { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    
    }
}