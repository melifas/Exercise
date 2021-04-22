using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Repository
{
    public interface IFixtureRepository
    {
        IEnumerable<Fixture> GetAllFixtures();
        Fixture GetFixture(int Id);
    }
}
