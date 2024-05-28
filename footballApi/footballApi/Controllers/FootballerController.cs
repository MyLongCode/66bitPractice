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
            var footballers = _footballerLogicManager.GetAllFootballers();
            return View("Index", footballers);
        }
    }
}
