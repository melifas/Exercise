using Exercise.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise.Models;

namespace Exercise.Controllers
{
    [ApiController]
    public class FixtureController : ControllerBase
    {
        private readonly IFixtureRepository _fixtureRepository;

        public FixtureController(IFixtureRepository fixtureRepository)
        {
            _fixtureRepository = fixtureRepository;
        }

        
        [HttpGet("Fixtures/getFixtures")]
        public IActionResult GetFixtures()
        {
            var fixtures = _fixtureRepository.GetAllFixtures();
            return new JsonResult(fixtures);

        }

        [HttpPost("Fixtures/getSpecificFixtures")]
        public IActionResult GetSpecificFixtures([FromBody] Fixture fixture )
        {
            var specificFixtures = _fixtureRepository.GetSpecificFixtures(fixture.LeagueId,fixture.Date.ToString("d"));

            if (specificFixtures == null)
            {
                return NotFound();
            }
            return new JsonResult(specificFixtures);

        }

    }
}
