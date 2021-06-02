
using System.Collections.Generic;

namespace MyE.Entity
{
    public class Role
    {
        public int Id {get; set;}
        public string NameRole {get; set;}
        public virtual ICollection<User> Users { get; set; }
    }
}