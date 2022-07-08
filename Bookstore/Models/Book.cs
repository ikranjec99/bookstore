using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    [Index(nameof(AuthorId), nameof(GenreId), nameof(Title), nameof(Price))]
    public class Book
    {
        public Guid Id { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public Guid GenreId { get; set; }
        public double Price { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Description { get; set;  }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
