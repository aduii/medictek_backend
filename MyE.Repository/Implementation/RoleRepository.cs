using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository.Context;
using System.Linq;

namespace MyE.Repository.Implementation
{
    public class RoleRepository : IRoleRepository
    {
        private ApplicationDbContext context;
        public RoleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
         public bool Delete(int id)
        {
           try
            {
                var result = new Role();
                result = context.Roles.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public Role Get(int id)
        {
            var result = new Role();
            try {
                result = context.Roles.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Role> GetAll()
        {
            var result = new List<Role>();
            try{
                result = context.Roles.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Role entity)
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

        public bool Update(Role entity)
        {
            try{
                var newRole = context.Roles.Single(x => x.Id == entity.Id);
                newRole.Id = entity.Id;
                newRole.NameRole = entity.NameRole;
                context.Update(newRole);
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