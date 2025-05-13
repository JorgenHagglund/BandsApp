namespace BandsApp.Web.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Album[] Albums { get; set; } = Array.Empty<Album>();
        public string Description { get; set; } = null!;  
        public string Image { get; set; } = null!;
        public string VideoUrl { get; set; } = null!;
    }
}
