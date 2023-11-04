using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiketsBasket.Models.Domain
{
    public class EventImage:Record
    {
        [Required]
        public string ImageUrl { get; set; }

        public string ThumpUrl  { get; set; }
        public virtual Event Event { get; set; }
        public string EventId { get; set; }
    }
}
