using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository;
namespace MyE.Service.implementation
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
         public bool Delete(int id)
        {
            return this.userRepository.Delete(id);
        }

        public User Get(int id)
        {
           return  this.userRepository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
          return  this.userRepository.GetAll();
        }

        public bool Save(User entity)
        {
           return userRepository.Save(entity);
        }

        public bool Update(User entity)
        {
           return this.userRepository.Update(entity);
        }
    }
}