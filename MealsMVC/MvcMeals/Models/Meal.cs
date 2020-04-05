using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMeals.Models
{
    public class Meal
    {

        public int Id { get; set; }
        [Display(Name = "Day of Week")]
        public string DayOfWeek { get; set; }

        public string Cook { get; set; }

        [Display(Name = "Main Dish")]
        public string MainDish { get; set; }

        [Display(Name = "Vegetable")]
        public string SideDish1 { get; set; }

        [Display(Name = "Side Dish")]
        public string SideDish2 { get; set; }

        [Display(Name = "Recipe Link")]
        [DataType(DataType.Url)]
        public string RecipeLink { get; set; }
        
    }
}