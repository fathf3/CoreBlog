namespace CoreDemo.Models
{
    public class AddProfileImage
    {
        public int WriterId { get; set; }
        public string writerName { get; set; }
        public string writerAbout { get; set; }
        public IFormFile writerImage { get; set; }
        public string writerMail { get; set; }
        public string writerPassword { get; set; }
        public bool writerStatus { get; set; }
    }
}
