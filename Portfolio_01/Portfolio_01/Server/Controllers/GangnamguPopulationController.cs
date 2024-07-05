using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_01.Server.Interfaces;
using Portfolio_01.Shared;

namespace Portfolio_01.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GangnamguPopulationController : ControllerBase
    {
        private readonly IGangnamguPopulation _IGangnamguPopulation;
        public GangnamguPopulationController(IGangnamguPopulation iGangnamguPopulation)
        {
            _IGangnamguPopulation = iGangnamguPopulation;
        }

        [HttpGet]
        public IEnumerable<GangnamguPopulation> Get() 
        {
            return _IGangnamguPopulation.GetAllGangnamguPopulation();
        }

        [HttpPost]
        public void Post(GangnamguPopulation data)
        { 
            _IGangnamguPopulation.AddGangnamguPopulation(data);
        }
    }
}
