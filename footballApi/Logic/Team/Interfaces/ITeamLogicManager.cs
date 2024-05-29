using Logic.Team.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Team.Interfaces
{
    public interface ITeamLogicManager
    {
        public int CreateNewTeam(string name);
        public IEnumerable<TeamLogic> GetAllTeams();
        public TeamLogic GetTeamByName(string name);
    }
}
