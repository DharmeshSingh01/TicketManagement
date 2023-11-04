using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiketsBasket.Models.Domain
{
    public class Like:Record
    {
        public Like()
        {
            CreatedOn = DateTime.UtcNow;
        }
        public DateTime CreatedOn { get; set; }
        public virtual Event Event { get; set; }
        public string EventId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public string UserProfileId { get; set; }
    }
}
