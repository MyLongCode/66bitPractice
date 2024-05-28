using Dal.Footballer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Footballer.Interfaces
{
    public interface IFootballerRepository
    {
        public FootballerDal GetFootballerById (int id);
        public int CreateFootballer (FootballerDal footballer);
        public int UpdateFootballer (FootballerDal footballer);
        public int DeleteFootballerById (int id);
    }
}
