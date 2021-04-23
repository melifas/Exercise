using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Repository
{
    public class FixtureRepository : IFixtureRepository
    {
        private readonly List<Fixture> _fixtureList;

        public FixtureRepository()
        {
            _fixtureList = new List<Fixture>()
            {
                new Fixture(){Id = 1, LeagueId = 1, Date = new DateTime(2021,11,12), HomeTeam = "Olympiakos", AwayTeam = "Panathinaikos" },
                new Fixture(){Id = 2, LeagueId = 2, Date = new DateTime(2021,12,14), HomeTeam = "Everton", AwayTeam = "Fulham" },
                new Fixture(){Id = 3, LeagueId = 3, Date = new DateTime(2021,12,16), HomeTeam = "Burnlay", AwayTeam = "Arsenal" },
                new Fixture(){Id = 4, LeagueId = 1, Date = new DateTime(2021,11,12), HomeTeam = "Totenam", AwayTeam = "Napoli" },
            };
        }

        public IEnumerable<Fixture> GetAllFixtures()
        {
            return this._fixtureList;
        }

        public IEnumerable<Fixture> GetSpecificFixtures(int leagueId, string date)
        {
            var test = this._fixtureList.Where(f => f.LeagueId == leagueId && f.Date.ToString("d") == date);

            if (test.Count()==0)
            {
                return null;
            }
            return test;
        }

        public Fixture GetFixture(int Id)
        {
            return this._fixtureList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
