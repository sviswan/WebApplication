using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }

        public String Description { get; set; }

        public String ReviewerName { get; set; }

        public String ReviewerEmailID { get; set; }

        public int Rating { get; set; }

        [Display(Name ="Restaurant")]
        public int RestaurantID { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}