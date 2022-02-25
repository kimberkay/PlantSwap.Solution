using Microsoft.EntityFrameworkCore;

namespace PlanSwap.Models
{
    public class PlantSwapContext : DbContext
    {
        public PlantSwapContext(DbContextOptions<PlantSwapContext> options) : base(options)
        {

        }

        public DbSet<Swap> Swaps { get; set; }

    }

}