using Microsoft.AspNetCore.Mvc;
using TechTrove.BLL.Services;
using TechTrove.DAL.Entities;

namespace TechTrove.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;

        public CartItemsController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        // GET: api/CartItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechTroveCartItem>>> GetCartItems()
        {
            var cartItems = await _cartItemService.GetAllCartItemsAsync();
            return Ok(cartItems);
        }

        // GET: api/CartItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TechTroveCartItem>> GetCartItem(int id)
        {
            var cartItem = await _cartItemService.GetCartItemByIdAsync(id);

            if (cartItem == null)
            {
                return NotFound();
            }

            return Ok(cartItem);
        }

        // POST: api/CartItems
        [HttpPost]
        public async Task<ActionResult<TechTroveCartItem>> CreateCartItem(TechTroveCartItem cartItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _cartItemService.CreateCartItemAsync(cartItem);
            return CreatedAtAction(nameof(GetCartItem), new { id = cartItem.Id }, cartItem);
        }

        // PUT: api/CartItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCartItem(int id, TechTroveCartItem cartItem)
        {
            if (id != cartItem.Id)
            {
                return BadRequest();
            }

            try
            {
                await _cartItemService.UpdateCartItemAsync(cartItem);
            }
            catch (Exception ex)
            {
                // Gestionează erorile corespunzător
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return NoContent();
        }

        // DELETE: api/CartItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            var cartItem = await _cartItemService.GetCartItemByIdAsync(id);
            if (cartItem == null)
            {
                return NotFound();
            }

            await _cartItemService.DeleteCartItemAsync(id);
            return NoContent();
        }
    }
}
