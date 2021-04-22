using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Repository
{
    public class LeagueRepository : ILeagueRepository
    {
        private List<League> _leagueList;

        public LeagueRepository()
        {
            _leagueList = new List<League>()
            {
                new League(){Id = 1, Name = "Super League"},
                new League(){Id = 2, Name = "Premier League" },
                new League(){Id = 3, Name = "English Premier League" }
            };
        }

        public IEnumerable<League> GetAllLeagues()
        {
            return this._leagueList;
        }

        public League GetLeague(int Id)
        {
            return this._leagueList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
