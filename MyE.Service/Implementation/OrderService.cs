using System.Collections.Generic;
using MyE.Entity;

using MyE.Repository;
namespace MyE.Service.implementation
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
          this.orderRepository = orderRepository;
        }
         public bool Delete(int id)
        {
          return this.orderRepository.Delete(id);
        }

        public Order Get(int id)
        {
          return this.orderRepository.Get(id);
        }

        public IEnumerable<Order> GetAll()
        {
          return this.orderRepository.GetAll();
        }

        public bool Save(Order entity)
        {
          return this.orderRepository.Save(entity);
        }

        public bool Update(Order entity)
        {
          return this.orderRepository.Update(entity);
        }
    }
}