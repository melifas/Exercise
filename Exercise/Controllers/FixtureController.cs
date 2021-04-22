using Exercise.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Controllers
{
    public class FixtureController : Controller
    {
        private readonly IFixtureRepository _fixtureRepository;

        public FixtureController(IFixtureRepository fixtureRepository)
        {
            _fixtureRepository = fixtureRepository;
        }

        

        public IActionResult GetFixtures()
        {
            var fixtures = _fixtureRepository.GetAllFixtures();

        }
    }
}
