
namespace IRF_Project.Entities
{
    public class Video
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Country { get; set; }
        public string DateAdded { get; set; }
        public int ReleaseYear { get; set; }
        public string Rating { get; set; }
        public string Duration { get; set; }
        public string Listedin { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
