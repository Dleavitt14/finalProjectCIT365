using Microsoft.EntityFrameworkCore;
using MvcMeals.Models;

namespace MvcMeal.Data
{
    public class MvcMealContext : DbContext
    {
        public MvcMealContext (DbContextOptions<MvcMealContext> options)
            : base(options)
        {
        }

        public DbSet<Meal> Meal { get; set; }
    }
}