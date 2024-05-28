using Dal.Footballer.Interfaces;
using Dal.Footballer.Models;
using Logic.Footballer.Interfaces;
using Logic.Footballer.Models;
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

        public FootballerLogicManager(IFootballerRepository footballerRepository)
        {
            _footballerRepository = footballerRepository;
        }
        public int CreateFootballer(FootballerLogic footballer)
        {
            return _footballerRepository.CreateFootballer(new FootballerDal
            {
                FirstName = footballer.FirstName,
                LastName = footballer.LastName,
                Sex = footballer.Sex,
                BirthdayDate = footballer.BirthdayDate,
                TeamId = footballer.TeamId,
                Country = footballer.Country,
            });
        }

        public int DeleteFootballerById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FootballerLogic> GetAllFootballers()
        {
            return _footballerRepository.GetAllFootballers().Select(f => new FootballerLogic
            {
                FirstName = f.FirstName,
                LastName = f.LastName,
                Sex = f.Sex,
                BirthdayDate = f.BirthdayDate,
                TeamId = f.TeamId,
                Country = f.Country,
            });
        }

        public IEnumerable<FootballerLogic> GetAllFootballersByTeamId(int teamId)
        {
            throw new NotImplementedException();
        }

        public FootballerLogic GetFootballerById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateFootballer(FootballerLogic footballer)
        {
            throw new NotImplementedException();
        }
    }
}
