using BlazorWasmProject.Server.Interfaces;
using BlazorWasmProject.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmProject.Server.Controllers
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

        [HttpPut]
        public void Put(GangnamguPopulation data) 
        {
            _IGangnamguPopulation.UpdateGangnamguPopulation(data);
        }

        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            _IGangnamguPopulation.DeleteGangnamguPopulation(id);
        }
    }
}
