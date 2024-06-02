using Dal.Footballer.Interfaces;
using Dal.Footballer.Models;
using Dal.Team.Interfaces;
using Logic.Footballer.Interfaces;
using Logic.Footballer.Models;
using Logic.Team.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Footballer
{
    public class FootballerLogicManager : IFootballerLogicManager
    {
        private readonly IFootballerRepository _footballerRepository;
        private readonly ITeamRepository _teamRepository;

        public FootballerLogicManager(IFootballerRepository footballerRepository
            , ITeamRepository teamRepository)
        {
            _footballerRepository = footballerRepository;
            _teamRepository = teamRepository;
        }
        public int CreateFootballer(FootballerLogic footballer)
        {
            var team = _teamRepository.GetTeamByName(footballer.TeamName);
            if (team == null)
                _teamRepository.CreateNewTeam(footballer.TeamName);
            return _footballerRepository.CreateFootballer(new FootballerDal
            {
                FirstName = footballer.FirstName,
                LastName = footballer.LastName,
                Sex = footballer.Sex,
                BirthdayDate = footballer.BirthdayDate,
                TeamId = _teamRepository.GetTeamByName(footballer.TeamName).Id,
                Country = footballer.Country,
            });
        }

        public int DeleteFootballerById(int id)
        {
            return _footballerRepository.DeleteFootballerById(id);
        }

        public IEnumerable<FootballerLogic> GetAllFootballers()
        {
            return _footballerRepository.GetAllFootballers().Select(f => new FootballerLogic
            {
                Id = f.Id,
                FirstName = f.FirstName,
                LastName = f.LastName,
                Sex = f.Sex,
                BirthdayDate = f.BirthdayDate,
                TeamName = f.Team.Name,
                Country = f.Country,
            });
        }

        public IEnumerable<FootballerLogic> GetAllFootballersByTeamId(int teamId)
        {
            throw new NotImplementedException();
        }

        public FootballerLogic GetFootballerById(int id)
        {
            var f = _footballerRepository.GetFootballerById(id);
            return new FootballerLogic
            {
                Id = f.Id,
                FirstName = f.FirstName,
                LastName = f.LastName,
                Sex = f.Sex,
                BirthdayDate = f.BirthdayDate,
                TeamName = f.Team.Name,
                Country = f.Country,
            };
        }

        public int UpdateFootballer(FootballerLogic footballer)
        {
            return _footballerRepository.UpdateFootballer(new FootballerDal
            {
                Id = footballer.Id,
                FirstName = footballer.FirstName,
                LastName = footballer.LastName,
                Sex = footballer.Sex,
                BirthdayDate = footballer.BirthdayDate,
                Country = footballer.Country,
                Team = _teamRepository.GetTeamByName(footballer.TeamName)
            });
        }
    }
}
