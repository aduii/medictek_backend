using MyE.Entity;
using System.Collections.Generic;

namespace MyE.Repository
{
    public interface IOrderRepository:ICrudRepository<Order>
    {
         IEnumerable<Order> GetOrderByMedical(int medicalequipmentId);
    }
}