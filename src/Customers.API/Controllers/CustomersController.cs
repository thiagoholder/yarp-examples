using Microsoft.AspNetCore.Mvc;

namespace Customers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(new[] { "Customer1", "Customer2", "Customer3" });
        }
    }
}
