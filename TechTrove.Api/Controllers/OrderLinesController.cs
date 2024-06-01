using Microsoft.AspNetCore.Mvc;
using TechTrove.BLL.Interfaces;
using TechTrove.DAL.Entities;

namespace TechTrove.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLinesController : ControllerBase
    {
        private readonly IOrderLineService _orderLineService;

        public OrderLinesController(IOrderLineService orderLineService)
        {
            _orderLineService = orderLineService;
        }

        // GET: api/OrderLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechTroveOrderLine>>> GetOrderLines()
        {
            var orderLines = await _orderLineService.GetAllOrderLinesAsync();
            return Ok(orderLines);
        }

        // GET: api/OrderLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TechTroveOrderLine>> GetOrderLine(int id)
        {
            var orderLine = await _orderLineService.GetOrderLineByIdAsync(id);

            if (orderLine == null)
            {
                return NotFound();
            }

            return Ok(orderLine);
        }

        // POST: api/OrderLines
        [HttpPost]
        public async Task<ActionResult<TechTroveOrderLine>> CreateOrderLine(TechTroveOrderLine orderLine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _orderLineService.CreateOrderLineAsync(orderLine);
            return CreatedAtAction(nameof(GetOrderLine), new { id = orderLine.Id }, orderLine);
        }

        // PUT: api/OrderLines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrderLine(int id, TechTroveOrderLine orderLine)
        {
            if (id != orderLine.Id)
            {
                return BadRequest();
            }

            try
            {
                await _orderLineService.UpdateOrderLineAsync(orderLine);
            }
            catch (Exception ex)
            {
                // Gestionează erorile corespunzător
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return NoContent();
        }

        // DELETE: api/OrderLines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderLine(int id)
        {
            var orderLine = await _orderLineService.GetOrderLineByIdAsync(id);
            if (orderLine == null)
            {
                return NotFound();
            }

            await _orderLineService.DeleteOrderLineAsync(id);
            return NoContent();
        }
    }
}
