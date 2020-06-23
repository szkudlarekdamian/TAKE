using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarioPizzeria.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Pizza name")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(0, 1000)]
        [DataType(DataType.Currency)]
        [DisplayName("Price of small pizza")]
        public double PriceS { get; set; }

        [Required]
        [Range(0, 1000)]
        [DataType(DataType.Currency)]
        [DisplayName("Price of medium pizza")]
        public double PriceM { get; set; }

        [Required]
        [Range(0, 1000)]
        [DataType(DataType.Currency)]
        [DisplayName("Price of large pizza")]
        public double PriceL { get; set; }

        [Required]
        public string Crust { get; set; }

        public virtual ICollection<PizzaIngredient> PizzaIngredients { get; set; }
    }
}
