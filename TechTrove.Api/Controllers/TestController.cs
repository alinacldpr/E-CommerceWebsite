using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechTrove.DAL;
using TechTrove.DAL.Entities;

namespace TechTrove.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TechTroveContext _context;

        public TestController(TechTroveContext context)
        {
            _context = context;
        }

        // GET: api/Test
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechTroveProduct>>> GetProducts()
        {
            var products = await _context.TechTroveProducts.ToListAsync();
            return Ok(products);
        }
    }
}