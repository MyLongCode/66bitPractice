using Logic.Footballer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Footballer.Interfaces
{
    public interface IFootballerLogicManager
    {
        public FootballerLogic GetFootballerById (int id);
        public int CreateFootballer (FootballerLogic footballer);
        public int UpdateFootballer (FootballerLogic footballer);
        public int DeleteFootballerById (int id);
        public IEnumerable<FootballerLogic> GetAllFootballers();
        public IEnumerable<FootballerLogic> GetAllFootballersByTeamId(int teamId);
    }
}
