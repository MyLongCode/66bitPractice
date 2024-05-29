using Logic.Team.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Footballer.Models
{
    public class FootballerLogic
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string TeamName { get; set; }
        public Country Country { get; set; }
    }
}
