using Microsoft.AspNetCore.Mvc;

namespace ElasticSearchAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : ControllerBase
    {

        private readonly ILogger<APIController> _logger;

        public APIController(ILogger<APIController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Index")]
        public IEnumerable<string> Index()
        {
            return new string[] { };
        }
    }
}