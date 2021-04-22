using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Models
{
    public class Fixture
    {
        public int Id { get; set; }
        public int LeagueId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
    }
}
