using Dal.EF;
using Dal.Team.Interfaces;
using Dal.Team.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Team
{
    public class TeamRepository : ITeamRepository 
    {
        private ApplicationDbContext db;
        public TeamRepository(ApplicationDbContext context) => this.db = context;
        public int CreateNewTeam(string name)
        {
            var team = new TeamDal
            {
                Name = name,
            };
            db.Teams.Add(team);
            db.SaveChanges();
            return team.Id;
        }

        public IEnumerable<TeamDal> GetAllTeams()
        {
            return db.Teams.ToList();
        }

        public TeamDal GetTeamByName(string name)
        {
            return db.Teams.FirstOrDefault(t => t.Name == name);
        }
    }
}
