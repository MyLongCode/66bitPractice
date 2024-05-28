using Api.Models;
using Logic.Footballer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("/footballer")]
    public class FootballerController : Controller
    {
        private IFootballerLogicManager _footballerLogicManager;
        public FootballerController(IFootballerLogicManager footballerLogicManager)
        {
            _footballerLogicManager = footballerLogicManager;
        }

        [HttpGet]
        [Route("/footballer")]
        public IActionResult GetAllFootballers()
        {
            var footballers = _footballerLogicManager.GetAllFootballers()
                .Select(f => new Footballer
                {
                    Id = f.Id,
                    FirstName = f.FirstName,
                    LastName = f.LastName,
                    Sex = f.Sex,
                    BirthdayDate = f.BirthdayDate,
                    TeamName = f.Team.Name,
                    Country = f.Country,
                });
            return View("Index", footballers);
        }
    }
}
