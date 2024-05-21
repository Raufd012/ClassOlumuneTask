namespace MeetUp.Areas.Admin.ViewModes.Data
{
    public class UpdateDataVM
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Image {  get; set; }
        public IFormFile? Photo { get; set; }
    }
}
