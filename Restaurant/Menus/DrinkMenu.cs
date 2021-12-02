using Restaurant.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menus
{
    class DrinkMenu
    {
        public List<Drink> drinksList = new List<Drink>()
        {
            new NaturalDrink{Name="Lemonade", Price=12.5,
            ingredients={{new Foods.Ingredient{Name="lemon",Quantity=1}},
                        {new Foods.Ingredient{Name="sugar",Quantity=2}},
                        {new Foods.Ingredient{Name="mint",Quantity=4}}}},

            new SodaDrink{Name="Coca Cola", Price = 4.5},
            new SodaDrink{Name="Fanta", Price = 4.5},
            new SodaDrink{Name="Sprite", Price = 4.5},
            new SodaDrink{Name="Schweppes", Price = 4.5},
            new NaturalDrink{Name="Coffee", Price=7.4},
            new NaturalDrink{Name="Fresh", Price=12.5, 
                ingredients={{new Foods.Ingredient {Name="sugar",Quantity=2}},
                             {new Foods.Ingredient {Name="orange",Quantity=2}}}},
            new NaturalDrink{Name="Water", Price=3.0},
        };

        public void Print()
        {
            var stringDrink = new StringBuilder(" ----- DRINK MENU ----- \n\n");

            for(int i = 0; i < drinksList.Count; i++)
            {
                stringDrink.Append($"{i + 1}. {drinksList[i].Name} : {drinksList[i].Price}$ \n");
            }

            Console.WriteLine(stringDrink.ToString());
        }
    }
}
