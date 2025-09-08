using System.Security.Claims;

namespace CMCS.Models
{
    public class Lecturer
    {

        public int LectuerID { get; set; }

        public string Name { get; set; } = "";

        public string Email { get; set; } = "";

        public string? ContactNumber {  get; set; }

        public ICollection<Claim> Claims { get; set; } = new List<Claim>();
    }
}
