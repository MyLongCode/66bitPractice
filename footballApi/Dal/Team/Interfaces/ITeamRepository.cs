using Dal.Team.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Team.Interfaces
{
    public interface ITeamRepository
    {
        public int CreateNewTeam(string name);
        public IEnumerable<TeamDal> GetAllTeams();
        public TeamDal GetTeamByName(string name);
    }
}
