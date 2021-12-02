using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods
{
    class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; } = 0;
        public void AddStock(int number)
        {
            Quantity = Quantity + number;
        }
        public void RemoveStock(int number)
        {
            Quantity = Quantity - number;
        }
    }
}
