using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarioPizzeria.Models
{
    public class Pizza
    {
        public Pizza()
        {
            var list = new[]
            {
                new { Crust = "Cienkie", Value = "Cienkie" },
                new { Crust = "Grube", Value = "Grube" }
            }.ToList();
            CrustList = new SelectList(list, "Crust", "Value", "");
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public double PriceS { get; set; }

        [Required]
        public double PriceM { get; set; }

        [Required]
        public double PriceL { get; set; }

        public SelectList CrustList { get; set; }
        [Required]
        public string Crust { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
