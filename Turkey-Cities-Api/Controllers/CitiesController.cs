using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Turkey_Cities_Api.Abstract;
using Turkey_Cities_Api.Entites;

namespace Turkey_Cities_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : Controller
    {
        private readonly IGetCities getCities;

        public CitiesController(IGetCities getCities)
        {
            this.getCities = getCities;
        }
        
        [HttpGet("get-all-cities")]
        public async Task<IActionResult> GetAllCities()
        {
            return Ok(await getCities.LoadJson());
        }
        [HttpGet("get-all-cities-array")]
        public async Task<IActionResult> GetAllCitiesAsArray()
        {
            return Ok(await getCities.LoadJsonWithoutClass());
        }

    }
}
