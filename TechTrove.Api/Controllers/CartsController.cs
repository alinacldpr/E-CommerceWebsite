using Microsoft.AspNetCore.Mvc;
using TechTrove.BLL.Services;
using TechTrove.DAL.Entities;

namespace TechTrove.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }

        // GET: api/Carts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechTroveCart>>> GetCarts()
        {
            var carts = await _cartService.GetAllCartsAsync();
            return Ok(carts);
        }

        // GET: api/Carts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TechTroveCart>> GetCart(int id)
        {
            var cart = await _cartService.GetCartByIdAsync(id);

            if (cart == null)
            {
                return NotFound();
            }

            return Ok(cart);
        }

        // POST: api/Carts
        [HttpPost]
        public async Task<ActionResult<TechTroveCart>> CreateCart(TechTroveCart cart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _cartService.CreateCartAsync(cart);
            return CreatedAtAction(nameof(GetCart), new { id = cart.Id }, cart);
        }

        // PUT: api/Carts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCart(int id, TechTroveCart cart)
        {
            if (id != cart.Id)
            {
                return BadRequest();
            }

            try
            {
                await _cartService.UpdateCartAsync(cart);
            }
            catch (Exception ex)
            {
                // Gestionează erorile corespunzător
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return NoContent();
        }

        // DELETE: api/Carts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            var cart = await _cartService.GetCartByIdAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            await _cartService.DeleteCartAsync(id);
            return NoContent();
        }
    }
}
