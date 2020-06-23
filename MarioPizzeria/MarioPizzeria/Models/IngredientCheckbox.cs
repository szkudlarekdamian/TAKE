using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarioPizzeria.Models
{
    public class IngredientCheckbox
    {
        public IngredientCheckbox(int id, string name, bool ischecked)
        {
            this.IngredientId = id;
            this.Name = name;
            this.IsChecked = ischecked;
        }
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }


    }
}
