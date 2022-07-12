using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using versApp.Date.Models;

namespace versApp.Date.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public readonly ApplicationContext _context;
        public OrderRepository(ApplicationContext Context)
        {
            _context = Context;
        }
        public async Task Create(Order order)
        {
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Order.ToListAsync();
        }
    }
}
