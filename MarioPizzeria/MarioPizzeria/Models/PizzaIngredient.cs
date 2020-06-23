using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MarioPizzeria.Models
{
    public class PizzaIngredient
    {
        public int Id { get; set; }
        [DisplayName("Pizza")]
        public int PizzaId { get; set; }

        [DisplayName("Select Ingredient")]
        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
