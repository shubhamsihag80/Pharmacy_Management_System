using OrderProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProj.Repository
{
    public interface IOrderItemRepository
    {

        public List<OrderItem> GetOrderItem();
        public IQueryable<OrderItem> GetOrderItem(int id);
        public OrderItem PutOrderItem(int id, OrderItem orderItem);
        public void PostOrderItem(OrderItem orderItem);
        public IQueryable<OrderItem> DeleteOrderItem(int id);
    }
}
