using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Repository
{
    public class FixtureRepository : IFixtureRepository
    {
        private List<Fixture> _fixtureList;

        public FixtureRepository()
        {
            _fixtureList = new List<Fixture>()
            {
                new Fixture(){Id = 1, LeagueId = 1, Date = new DateTime(2021,11,12), HomeTeam = "Olympiakos", AwayTeam = "Panathinaikos" },
                new Fixture(){Id = 2, LeagueId = 2, Date = new DateTime(2021,12,14), HomeTeam = "Everton", AwayTeam = "Fulham" },
                new Fixture(){Id = 3, LeagueId = 3, Date = new DateTime(2021,12,16), HomeTeam = "Burnlay", AwayTeam = "Arsenal" },
            };
        }

        public IEnumerable<Fixture> GetAllFixtures()
        {
            return this._fixtureList;
        }

        public Fixture GetFixture(int Id)
        {
            return this._fixtureList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
