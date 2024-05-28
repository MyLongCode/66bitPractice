
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Footballer
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
