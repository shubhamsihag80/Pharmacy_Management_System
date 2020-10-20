using Microsoft.EntityFrameworkCore;
using OrderProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProj.Repository
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly pharmacy_dbContext _context;

        public OrderItemRepository(pharmacy_dbContext context)
        {
            _context = context;
        }
        public IQueryable<OrderItem> DeleteOrderItem(int id)
        {
            IQueryable<OrderItem> orderItems = _context.OrderItem.Where(a => a.OrderId == id);
            _context.OrderItem.Remove(orderItems.FirstOrDefault());
            _context.SaveChangesAsync();
            return orderItems;
        }

        public List<OrderItem> GetOrderItem()
        {
            return _context.OrderItem.ToList();
        }

        public IQueryable<OrderItem> GetOrderItem(int id)
        {
            return _context.OrderItem.Where(a => a.OrderId == id);
        }

        public void PostOrderItem(OrderItem orderItem)
        {
            _context.OrderItem.Add(orderItem);
            _context.SaveChangesAsync();
        }

        public OrderItem PutOrderItem(int id, OrderItem orderItem)
        {
            _context.Entry(orderItem).State = EntityState.Modified;
            _context.SaveChangesAsync();
            return orderItem;
        }
    }
}
