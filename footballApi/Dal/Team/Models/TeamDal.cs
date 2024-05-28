using Dal.Footballer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Team.Models
{
    public class TeamDal
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public List<FootballerDal> Footballers { get; set; } = new List<FootballerDal>();
    }
}
