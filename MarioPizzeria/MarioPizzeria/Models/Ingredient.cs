using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarioPizzeria.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Pizza> PizzasOn { get; set; }
    }
}
