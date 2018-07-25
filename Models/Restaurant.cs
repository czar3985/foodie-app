using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodieApp.Models {
    public class Restaurant {
        public int Id { get; set; }
        public string Name { get; set; }
        // Navigation Properties
        public virtual IList<MenuItem> MenuItems { get; set; }
    }
}