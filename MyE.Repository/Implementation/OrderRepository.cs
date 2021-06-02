using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository.Context;
using System.Linq;

namespace MyE.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;
        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
         public bool Delete(int id)
        {
            try
            {
                var result = new Order();
                result = context.Orders.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public Order Get(int id)
        {
            var result = new Order();
            try {
                result = context.Orders.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Order> GetAll()
        {
            var result = new List<Order>();
            try{
                result = context.Orders.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Order entity)
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

        public bool Update(Order entity)
        {
            try{
                var newOrder = context.Orders.Single(x => x.Id == entity.Id);
                newOrder.Id = entity.Id;
                newOrder.Priority = entity.Priority;
                newOrder.Date = entity.Date;
                newOrder.description = entity.description;
                context.Update(newOrder);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return true;
            }
            return false;
        }

      


        public IEnumerable<Order> GetOrderByMedical(int medicalequipmentId)
        {
            try
            {
                var Orders = context.Orders.Where(x => x.MedicalEquipamentId == medicalequipmentId);
                return Orders;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

       
    }
}