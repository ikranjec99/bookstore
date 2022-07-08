using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    [Index(nameof(IdentityUserId), nameof(BookId), nameof(BorrowedAt))]
    public class BorrowedBook
    {
        public Guid Id { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public string IdentityUserId { get; set; }
        public Book Book { get; set; }
        public Guid BookId { get; set; }
        public DateTime? BorrowedAt { get; set; }
        public DateTime? ReturnedAt { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
