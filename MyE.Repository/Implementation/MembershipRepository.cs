using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository.Context;
using System.Linq;

namespace MyE.Repository.Implementation
{
    public class MembershipRepository : IMembershipRepository
    {
        private ApplicationDbContext context;
        public MembershipRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new Membership();
                result = context.Memberships.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public Membership Get(int id)
        {
             var result = new Membership();
            try {
                result = context.Memberships.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Membership> GetAll()
        {
            var result = new List<Membership>();
            try{
                result = context.Memberships.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Membership entity)
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

        public bool Update(Membership entity)
        {
            try{
                var newMembership = context.Memberships.Single(x => x.Id == entity.Id);
                newMembership.Id = entity.Id;
                newMembership.QuantityEngineers = entity.QuantityEngineers;
                newMembership.Name = entity.Name;
                newMembership.Price = entity.Price;
                context.Update(newMembership);
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