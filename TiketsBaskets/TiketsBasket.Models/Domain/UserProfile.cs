using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiketsBasket.Models.Domain
{
    public class UserProfile:Record
    {
        public UserProfile()
        {
            CreatedOn = DateTime.UtcNow;
        }
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(25)]
        public string Country { get; set; }
        [Required]
        [StringLength(25)]
        public string City { get; set; }
        public bool IsOrganizer { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual List<Event> Events { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<WishlistEvent> WishlistEvents { get; set; }
        public virtual List<Like> Likes { get; set; }
        public virtual List<JobApplication> SentApplications     { get; set; } // Sent by normal User
        public virtual List<JobApplication> RecievedApplications { get; set; }
    }
}
