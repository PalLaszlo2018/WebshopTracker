using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebshopTracker.Service;

namespace WebshopTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebshopTrackerController : ControllerBase
    {
        public WebshopTrackerController(TrackerService trackerService)
        {
            TrackerService = trackerService;
        }

        public TrackerService TrackerService { get; }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return null; //TODO
        }
    }
}
