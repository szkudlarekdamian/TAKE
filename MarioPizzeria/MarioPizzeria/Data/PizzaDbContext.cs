using MarioPizzeria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarioPizzeria.Data
{
    public class PizzaDbContext : DbContext 
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) { } 
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredients { get; set; }


    }
}
