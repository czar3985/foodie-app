using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodieApp.Models {
    public class MenuItem {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        // Foreign Key
        public int RestaurantId { get; set; }
        public string CourseId { get; set; }
    }

    public class Course {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}