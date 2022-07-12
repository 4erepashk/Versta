using System.Collections.Generic;
using System.Threading.Tasks;

namespace versApp.Date.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Models.Order>> GetAll();
        Task Create(Models.Order order);
    }
}
