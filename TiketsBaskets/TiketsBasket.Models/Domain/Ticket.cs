﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiketsBasket.Models.Domain
{
    public  class Ticket:Record
    {
        public Ticket()
        {
            CreatedOn = DateTime.UtcNow;
        }
        [Required]
        public string Barcode { get; set; }
        public int? Discount { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal FinalPrice { get; set; }
        public string Place { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Event Event { get; set; }
        public string EventId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public string UserProfileId { get; set; }

    }
}
