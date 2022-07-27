using Microsoft.AspNetCore.Mvc;
using OperationSystemApp.Business;

namespace OperationSystemApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtnController : ControllerBase
    {
        private readonly IUtnService _utnService;

        public UtnController(IUtnService utnService)
        {
            _utnService = utnService;
        }

        [HttpGet(nameof(SayHello))]
        public IActionResult SayHello()
        {
            return Ok(_utnService.SayHello());
        }
    }
}
