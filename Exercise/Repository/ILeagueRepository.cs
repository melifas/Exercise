using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Repository
{
    public interface ILeagueRepository
    {
        IEnumerable<League> GetAllLeagues();
        League GetLeague(int Id);
    }
}
