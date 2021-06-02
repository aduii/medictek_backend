using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository;

namespace MyE.Service.implementation
{
    public class MembershipService : IMembershipService
    {
        private IMembershipRepository membershipRepository;
        public MembershipService(IMembershipRepository membershipRepository)
        {
           this.membershipRepository = membershipRepository;
        }
         public bool Delete(int id)
        {
         return this.membershipRepository.Delete(id);
        }

        public Membership Get(int id)
        {
          return this.membershipRepository.Get(id);
        }

        public IEnumerable<Membership> GetAll()
        {
          return this.membershipRepository.GetAll();
        }

        public bool Save(Membership entity)
        {
         return this.membershipRepository.Save(entity);
        }

        public bool Update(Membership entity)
        {
         return this.membershipRepository.Update(entity);
        }
    }
}