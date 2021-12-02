using Restaurant.Foods.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Pizza
{
    class Pizza : Food
    {
        public PizzaType Type { get; set; } = PizzaType.MEDIUM;
        public bool CheeseEdge { get; set; }
        public bool Spicy { get; set; }

        public List<string> description = new List<string>();

        public string PrintPizza()
        {
            var pizzaString = new StringBuilder($"Pizza {Name} : {Price}$ \n (");
            
                for(int i=0;i<description.Count;i++)
            pizzaString.Append($"{description[i]}, ");
            pizzaString.Remove(pizzaString.Length-2,2);
            pizzaString.Append($")\n");

            return pizzaString.ToString();
        }
    }
}
