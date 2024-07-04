using Blazor_Portfolio_01.Server.Interfaces;
using Blazor_Portfolio_01.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_Portfolio_01.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GangnamguPopulationController : ControllerBase
    {
        private readonly IGangnamguPopulation _IGangnamguPopulation;

        // 디펜던시 인젝션에서DI하는 방법
        // 생성자를 통한 의존성 주입
        // 의존성 주입은 따로 공부해보자.
        public GangnamguPopulationController(IGangnamguPopulation iGangnamguPopulation)
        {
            _IGangnamguPopulation = iGangnamguPopulation;
        }

        // 컨트롤러에서 라우터로 REST API를 구분하고 알맞는 인터페이스를 연결 후
        // 인터페이스를 통해 실제로 기능 수행을 하는 서비스로 이동한다.
        [HttpGet]
        public IEnumerable<GangnamguPopulation> Get() 
        {
            return _IGangnamguPopulation.GetAllGangnamguPopulation();
        }
    }
}
