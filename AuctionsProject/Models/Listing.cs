using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionsProject.Models
{
    public class Listing
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImgPath { get; set; }

        public bool IsSold { get; set; }

        [Required]  //a listing cannot exist without an associated user.
        public string? IdentityUserId { get; set; } //nulable string to create contructor
        [ForeignKey("IdentityUserId")]  //Pointing to IdentityUser table
        public IdentityUser? User { get; set; }

        public List<Bid>? Bids { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
