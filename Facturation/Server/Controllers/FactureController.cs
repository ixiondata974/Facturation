using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FactureController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FactureController> logger;
        private readonly IBusinessData businessData;

        public FactureController(ILogger<FactureController> logger, IBusinessData BusiData)
        {
            this.logger = logger;
            this.businessData = BusiData;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            /*var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();*/
            return businessData.les_factures;
        }

        [HttpGet("CA")]
        public decimal GetCA()
        {
            return businessData.CA;
        }

        [HttpGet("{reference}")]
        public ActionResult<Facture> Get(int reference)
        {
            var une_facture = businessData.les_factures.Where(fac => fac.Id == reference).FirstOrDefault();
            if(une_facture != null)
            {
                return une_facture;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Facture> Post([FromQuery] Facture newFacture)
        {
            if (ModelState.IsValid)
            {
                return Created($"Facture/{newFacture.Id}", newFacture);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }
    }
}
