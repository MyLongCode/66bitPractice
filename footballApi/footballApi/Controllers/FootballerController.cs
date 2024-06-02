﻿using Api.Models;
using Logic.Footballer.Interfaces;
using Logic.Footballer.Models;
using Logic.Team.Interfaces;
using Logic.Team.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("/footballer")]
    public class FootballerController : Controller
    {
        private IFootballerLogicManager _footballerLogicManager;
        private ITeamLogicManager _teamLogicManager;
        public FootballerController(IFootballerLogicManager footballerLogicManager
            ,ITeamLogicManager teamLogicManager)
        {
            _footballerLogicManager = footballerLogicManager;
            _teamLogicManager = teamLogicManager;
        }

        [HttpGet]
        [Route("/footballer")]
        public IActionResult Index()
        {
            var footballers = _footballerLogicManager.GetAllFootballers()
                .Select(f => new Footballer
                {
                    Id = f.Id,
                    FirstName = f.FirstName,
                    LastName = f.LastName,
                    Sex = f.Sex,
                    BirthdayDate = f.BirthdayDate,
                    TeamName = f.TeamName,
                    Country = f.Country,
                });
            return View("Index", footballers);
        }

        [HttpGet]
        [Route("/footballer/create")]
        public IActionResult Create()
        {
            ViewBag.Teams = _teamLogicManager.GetAllTeams()
                .Select(t => new Team
                {
                    Name = t.Name,
                    Footballers = t.Footballers.Select(f => new Footballer
                    {
                        Id = f.Id,
                        FirstName = f.FirstName,
                        LastName = f.LastName,
                        Sex = f.Sex,
                        BirthdayDate = f.BirthdayDate,
                        TeamName = f.TeamName,
                        Country = f.Country,
                    }).ToList()
                });
            return View("Create");
        }

        [HttpPost]
        [Route("/footballer/create")]
        public IActionResult Create(CreateFootballerRequest dto)
        {
            if (dto.TeamName == null)
                return BadRequest("Team is not found");
            var footballerId = _footballerLogicManager.CreateFootballer(new FootballerLogic
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Sex = dto.Sex,
                BirthdayDate = dto.BirthdayDate,
                TeamName = dto.TeamName,
                Country = dto.Country,
            });
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("/footballer/{id}/delete")]
        public IActionResult Delete(int id)
        {
            _footballerLogicManager.DeleteFootballerById(id);
            return RedirectToAction("Index");
        }
    }
}
