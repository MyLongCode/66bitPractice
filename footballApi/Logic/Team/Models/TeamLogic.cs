using Logic.Footballer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Team.Models
{
    public class TeamLogic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FootballerLogic> Footballers { get; set; } = new List<FootballerLogic>();
    }
}
