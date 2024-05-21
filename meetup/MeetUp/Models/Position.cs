using MeetUp.Models.Base;

namespace MeetUp.Models
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }
        public List<Team> Teams { get; set; }
    }
}
