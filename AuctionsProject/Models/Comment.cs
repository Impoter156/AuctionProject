using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionsProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }

        [Required]  //a listing cannot exist without an associated user.
        public string? IdentityUserId { get; set; } //nulable string to create contructor
        [ForeignKey("IdentityUserId")]  //Pointing to IdentityUser table
        public IdentityUser? User { get; set; }

        public int? ListingId { get; set; }
        [ForeignKey("ListingId")]
        public Listing? Listing { get; set; }
    }
}
