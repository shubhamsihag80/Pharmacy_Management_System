using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderProj.Models;
using OrderProj.Repository;

namespace OrderProj.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        //private readonly pharmacy_dbContext _context;

        //public OrderItemsController(pharmacy_dbContext context)
        //{
        //    _context = context;
        //}
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemsController(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
        // GET: api/OrderItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItem()
        {
            return Ok(_orderItemRepository.GetOrderItem());
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderItem>> GetOrderItem(int id)
        {
            return Ok(_orderItemRepository.GetOrderItem(id));
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderItem)
        {
            if (id != orderItem.OrderId)
            {
                return BadRequest();
            }
            _orderItemRepository.PutOrderItem(id, orderItem);
            return NoContent();
        }

        // POST: api/OrderItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderItem)
        {
            _orderItemRepository.PostOrderItem(orderItem);
            return CreatedAtAction("GetOrderItem", new { id = orderItem.OrderId }, orderItem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderItem>> DeleteOrderItem(int id)
        {
            IQueryable<OrderItem> orderItems = (IQueryable<OrderItem>)_orderItemRepository.DeleteOrderItem(id);
            if (orderItems.Count() == 0)
            {
                return NotFound();
            }

            return Ok(orderItems);
        }
    }
}
