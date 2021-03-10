using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HICTasks.Controllers
{
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly Response _response = new Response();

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [RequireHttps]
        [Route("/v1/hello")]
        public string Get()
        {
            var cert = Request.HttpContext.Connection.ClientCertificate;
            if (cert.Subject.Contains("OU=UNIT 1"))
            {
                return "world";
            }

            return _response.data = "Invalid OU value";
        }
        
        [HttpPost]
        [Route("/v2/hello")]
        public string Post([FromBody] Payload payload)
        {
            if (string.IsNullOrEmpty(payload.Format) && payload.Format != "json")
            {
                return "Invalid payload";
            }

            return JsonConvert.SerializeObject(_response);
        }
    }
}
