using System.ComponentModel.DataAnnotations;

namespace RazorPageMovie.models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public float Price { get; set; }
    }
}