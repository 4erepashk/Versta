using System.Collections.Generic;
using System.Threading.Tasks;
using versApp.Date.Models;
using Microsoft.AspNetCore.Mvc;
using versApp.Date.Repositories;

namespace versApp.Date.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository userRepository)
        {
            _orderRepository = userRepository;
        }
     
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Get()
        {
            var order = await _orderRepository.GetAll();
            return View("Get",order);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            await _orderRepository.Create(order);
            return View();
        }
       
    }
}
