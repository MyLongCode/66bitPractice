using Dal.Team.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Footballer.Models
{
    public class FootballerDal
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthdayDate { get; set; }
        public int TeamId { get; set; }
        public TeamDal Team { get; set; }
        public Country Country { get; set; }
    }
}
