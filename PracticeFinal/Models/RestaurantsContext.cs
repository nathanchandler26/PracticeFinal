using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PracticeFinal.Models
{
    public class RestaurantsContext : DbContext
    {
        public RestaurantsContext (DbContextOptions<RestaurantsContext> options) : base (options)
        {

        }

        public DbSet<RestaurantInfo> Info { get; set; }
    }
}
