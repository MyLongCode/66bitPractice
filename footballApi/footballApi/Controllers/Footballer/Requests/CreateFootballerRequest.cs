namespace Api.Controllers
{
    public class CreateFootballerRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string TeamName { get; set; }
        public string? CustomTeamName { get; set; }
        public Country Country { get; set; }
    }
}
