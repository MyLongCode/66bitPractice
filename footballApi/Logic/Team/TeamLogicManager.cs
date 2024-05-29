using Dal.Footballer.Interfaces;
using Dal.Team.Interfaces;
using Dal.Team.Models;
using Logic.Footballer.Models;
using Logic.Team.Interfaces;
using Logic.Team.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Team
{
    public class TeamLogicManager : ITeamLogicManager
    {
        private readonly ITeamRepository _teamRepository;

        public TeamLogicManager(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public int CreateNewTeam(string name)
        {
            return _teamRepository.CreateNewTeam(name);
        }

        public IEnumerable<TeamLogic> GetAllTeams()
        {
            return _teamRepository.GetAllTeams()
                .Select(t => new TeamLogic
                {
                    Name = t.Name,
                    Footballers = t.Footballers.Select(f => new FootballerLogic
                    {
                        FirstName = f.FirstName,
                        LastName = f.LastName,
                        Sex = f.Sex,
                        BirthdayDate = f.BirthdayDate,
                        TeamName = f.Team.Name,
                        Country = f.Country,
                    }).ToList()
                });
        }

        public TeamLogic GetTeamByName(string name)
        {
            var team = _teamRepository.GetTeamByName(name);
            return new TeamLogic
            {
                Name = team.Name,
                Footballers = team.Footballers.Select(f => new FootballerLogic
                {
                    FirstName = f.FirstName,
                    LastName = f.LastName,
                    Sex = f.Sex,
                    BirthdayDate = f.BirthdayDate,
                    TeamName = f.Team.Name,
                    Country = f.Country,
                }).ToList()
            };
        }
    }
}
