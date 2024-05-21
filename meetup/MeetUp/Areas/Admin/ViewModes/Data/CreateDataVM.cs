namespace MeetUp.Areas.Admin.ViewModes.Data
{
    public class CreateDataVM
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
