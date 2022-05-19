using Microsoft.AspNetCore.Mvc;

namespace MyDetails.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MYDATAController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<MYDATAController> _logger;

        public MYDATAController(ILogger<MYDATAController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<MYDATA> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new MYDATA
            {
                Date = DateTime.Now.AddDays(index),
                AGE = 23,
                DETAILS = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}