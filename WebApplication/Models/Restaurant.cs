using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }

        public String RName{ get; set; }

        public String RCity{ get; set; }

        public String RState{ get; set; }

        public int ReviewID { get; set; }

        public virtual List<Reviews> Reviews { get; set; }
    }
}