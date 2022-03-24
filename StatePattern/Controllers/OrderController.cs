using Microsoft.AspNetCore.Mvc;
using StatePattern.Enums;
using StatePattern.Repositories;

namespace StatePattern.Controllers
{
    [Route("api/Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var orders = _orderRepository.GetAll();

            if (orders.Count > 0)
            {
                return Ok(orders);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var order = _orderRepository.GetById(id);

            if (order != null)
            {
                return Ok(order);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}/makePayment/{paymentStatus}")]
        public async Task<IActionResult> MakePayment(int id, PaymentStatus paymentStatus)
        {
            var order = _orderRepository.GetById(id);

            if (order == null)
            {
                return NoContent();
            }

            order.ProcessFurther(paymentStatus);

            return Ok(order);
        }
    }
}
